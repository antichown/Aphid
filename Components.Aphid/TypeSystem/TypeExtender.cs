﻿using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public class TypeExtender : AphidRuntimeComponent
    {
        private static Memoizer<Type, string[]>
            _staticTypeMemoizer = new Memoizer<Type,string[]>(),
            _fanInteropTypeMemoizer = new Memoizer<Type, string[]>(),
            _fanAphidTypeMemoizer = new Memoizer<Type, string[]>();

        private bool _isUnknownExtended = false;

        private List<string> _typesExtended = new List<string>(0x100);

        public TypeExtender(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public string GetCtorName(string type)
        {
            return "$ext." + type + ".$ctor";
        }

        private string GetDynamicName(string type)
        {
            return "$ext." + type;
        }

        private string GetName(string type, string nameStr)
        {
            if (nameStr != null)
            {
                return "$ext." + type + "." + nameStr;
            }
            else
            {
                return "$ext." + type;
            }
        }

        private string[] FanStaticInteropTypeName(Type type)
        {
            if (type != null)
            {
                return _staticTypeMemoizer.Call(FanStaticInteropTypeNameCore, type);
            }
            else
            {
                return new string[0];
            }
        }

        private string[] FanStaticInteropTypeNameCore(Type type)
        {
            var names = new List<string>();

            while (type != null)
            {
                names.Add(GetInteropName(type));
                type = type.BaseType;
            }

            return names.ToArray();
        }

        private string[] FanAphidName(AphidObject obj)
        {
            if (obj.IsScalar)
            {
                if (obj.Value != null)
                {
                    return _fanAphidTypeMemoizer.Call(FanAphidName, obj.Value.GetType());
                }
                else
                {
                    return new string[0];
                }
            }
            else
            {
                return new string[]
                {
                    AphidType.Object,
                    typeof(AphidObject).FullName,
                    AphidType.Unknown
                };
            }
        }

        private string[] FanInteropName(AphidObject obj)
        {
            if (obj.IsScalar)
            {
                if (obj.Value != null)
                {
                    return _fanInteropTypeMemoizer.Call(FanInteropName, obj.Value.GetType());
                }
                else
                {
                    return new string[0];
                }
            }
            else
            {
                return new string[] { typeof(AphidObject).FullName, AphidType.Unknown };
            }
        }

        private string[] FanInteropName(Type t)
        {
            var names = new List<string>();

            do
            {
                names.Add(GetInteropName(t));
                t = t.BaseType;
            } while (t != null);

            names.Add(AphidType.Unknown);

            return names.ToArray();
        }
        
        private string[] FanAphidName(Type t)
        {
            var names = new List<string>();

            string aphidType;

            do
            {
                if ((aphidType = AphidAlias.Resolve(t)) != null)
                {
                    names.Add(aphidType);
                }

                names.Add(GetInteropName(t));
                t = t.BaseType;
            } while (t != null);

            names.Add(AphidType.Unknown);

            return names.ToArray();
        }

        private string GetInteropName(Type t)
        {
            if (!t.IsGenericType)
            {
                return t.FullName;
            }
            else
            {
                var isFirstTypeArg = true;
                var sb = new StringBuilder(t.FullName);
                sb.Append('[');

                foreach (var p in t.GetGenericArguments())
                {
                    if (isFirstTypeArg)
                    {
                        isFirstTypeArg = false;
                    }
                    else
                    {
                        sb.Append(',');
                    }

                    sb.Append(p.FullName);
                }

                sb.Append(']');

                return sb.ToString();
            }
        }

        public void Extend(
            IdentifierExpression type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            Extend(
                type.Identifier,
                type.Attributes.Select(x => x.Identifier).ToArray(),
                extensions,
                ctorHandler,
                dynamicHandler);
        }

        public void Extend(
            string type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            Extend(type, new string[0], extensions, ctorHandler, dynamicHandler);
        }

        public void Extend(
            string type,
            string[] attributes,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler)
        {
            if (AphidAlias.Resolve(type) == null)
            {
                var interopType = Interpreter.InteropTypeResolver.ResolveType(
                    Interpreter.GetImports().ToArray(),
                    new[] { type },
                    isType: true);

                if (attributes != null)
                {
                    if (attributes.Length == 1)
                    {
                        if (attributes[0] == AphidType.List)
                        {
                            interopType = typeof(List<>).MakeGenericType(interopType);
                        }
                        else
                        {
                            throw GetInteropTypeException(attributes, type);
                        }
                    }
                    else if (attributes.Length != 0)
                    {
                        throw GetInteropTypeException(attributes, type);
                    }
                }

                type = GetInteropName(interopType);
            }

            if (type == AphidType.Unknown || type == typeof(object).FullName)
            {
                _isUnknownExtended = true;
            }
            else if (!_typesExtended.Contains(type))
            {
                _typesExtended.Add(type);
            }

            foreach (var extension in extensions)
            {
                var nameStr = extension.Key;
                var keys = new List<string> { GetName(type, nameStr) };

                if (nameStr == dynamicHandler)
                {
                    keys.Add(GetDynamicName(type));
                }

                if (nameStr == ctorHandler)
                {
                    keys.Add(GetCtorName(type));
                }

                foreach (var key in keys)
                {
                    if (Interpreter.CurrentScope.ContainsKey(key))
                    {
                        Interpreter.CurrentScope[key] = extension.Value;
                    }
                    else
                    {
                        Interpreter.CurrentScope.Add(key, extension.Value);
                    }
                }
            }
        }

        private AphidRuntimeException GetInteropTypeException(string[] attributes, string type)
        {
            return Interpreter.CreateRuntimeException(
                "Unexpected attribute(s) '{0}' for type '{1}'. Expected attribute 'list' or none.",
                string.Join(", ", attributes),
                type);
        }

        public AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef)
        {
            if (isAphidType)
            {
                return TryResolve(
                    scope,
                    obj,
                    FanAphidName(obj),
                    key,
                    isAphidType,
                    isCtor,
                    isDynamic,
                    isStatic: false,
                    returnRef: returnRef);
            }
            else
            {
                return TryResolve(
                    scope,
                    obj,
                    FanInteropName(obj),
                    key,
                    isAphidType,
                    isCtor,
                    isDynamic,
                    isStatic: false,
                    returnRef: returnRef);
            }
        }

        public AphidObject TryResolve(
            AphidObject scope,
            Type staticType,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef)
        {
            return TryResolve(
                scope,
                null,
                FanStaticInteropTypeName(staticType),
                key,
                isAphidType,
                isCtor,
                isDynamic,
                isStatic: true,
                returnRef: returnRef);
        }

        public AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string[] classHierarchy,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool isStatic,
            bool returnRef)
        {
            if (!_isUnknownExtended)
            {
                var isTypeExtended = false;

                for (var i = 0; i < classHierarchy.Length - 2; i++)
                {
                    if (_typesExtended.Contains(classHierarchy[i]))
                    {
                        isTypeExtended = true;
                        break;
                    }
                }

                if (!isTypeExtended)
                {
                    return null;
                }
            }

            AphidObject val = null;

            if (isDynamic)
            {
                for (var i = 0; i < classHierarchy.Length; i++)
                {
                    if (scope.TryResolve(GetDynamicName(classHierarchy[i]), out val))
                    {
                        break;
                    }
                }

                if (val == null)
                {
                    return null;
                }
            }
            else if (isCtor)
            {
                for (var i = 0; i < classHierarchy.Length; i++)
                {
                    if (scope.TryResolve(GetCtorName(classHierarchy[i]), out val))
                    {
                        break;
                    }
                }

                if (val == null)
                {
                    return null;
                }
            }
            else
            {
                for (var i = 0; i < classHierarchy.Length; i++)
                {
                    if (scope.TryResolve(GetName(classHierarchy[i], key), out val))
                    {
                        break;
                    }
                }

                if (val == null)
                {
                    return null;
                }
            }

            AphidObject result;
            var func = val.Value as AphidFunction;

            if (func != null)
            {
                var function = func.Clone();
                //var function = func;
                var skipOffset = isStatic ? 1 : 0;

                function.ParentScope = AphidObject.Scope(scope);

                if (!isStatic)
                {
                    function.ParentScope.Add(AphidName.ImplicitArg, obj);
                }

                function.ParentScope.Add(AphidName.Extension, AphidObject.Scalar(true));
                function.ParentScope.Add(AphidName.StaticExtension, AphidObject.Scalar(isStatic));

                if (function.Args.Any())
                {
                    if (!isStatic)
                    {
                        function.ParentScope.Add(function.Args[0], obj);
                    }

                    int skip;

                    if (isDynamic && function.Args.Length >= 2 - skipOffset)
                    {
                        function.ParentScope.Add(
                            function.Args[1 - skipOffset],
                            AphidObject.Scalar(key));

                        skip = 2 - skipOffset;
                    }
                    else
                    {
                        skip = 1 - skipOffset;
                    }

                    function.Args = function.Args.Skip(skip).ToArray();
                }

                result = AphidObject.Scalar(function);
            }
            else
            {
                if (!returnRef)
                {
                    if (!val.ContainsKey(key))
                    {
                        result = null;
                    }
                    else
                    {
                        result = val[key];
                    }
                }
                else
                {
                    result = val;
                }
            }

            return !returnRef ? result : AphidObject.Scalar(new AphidRef() { Name = key, Object = result });
        }
    }
}
