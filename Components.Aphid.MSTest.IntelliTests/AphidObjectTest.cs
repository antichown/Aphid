using Components.Aphid.Interpreter;
using System.Runtime.Serialization;
using System.Reflection;
using System.Collections.Generic;
// <copyright file="AphidObjectTest.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    [TestClass]
    [PexClass(typeof(AphidObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidObjectTest
    {

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public AphidObject TryResolveParent([PexAssumeUnderTest]AphidObject target, string key)
        {
            AphidObject result = target.TryResolveParent(key);
            return result;
            // TODO: add assertions to method AphidObjectTest.TryResolveParent(AphidObject, String)
        }

        [PexMethod]
        [PexMethodUnderTest("GetPropertyInfo(Object, Boolean)")]
        internal IEnumerable<AphidPropertyInfo> GetPropertyInfo(object obj, bool allProperties)
        {
            object[] args = new object[2];
            args[0] = obj;
            args[1] = (object)allProperties;
            Type[] parameterTypes = new Type[2];
            parameterTypes[0] = typeof(object);
            parameterTypes[1] = typeof(bool);
            IEnumerable<AphidPropertyInfo> result0
               = ((MethodBase)(typeof(AphidObject).GetMethod("GetPropertyInfo",
                                                             BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic, (Binder)null,
                                                             CallingConventions.Standard, parameterTypes, (ParameterModifier[])null)))
                     .Invoke((object)null, args) as IEnumerable<AphidPropertyInfo>;
            IEnumerable<AphidPropertyInfo> result = result0;
            return result;
            // TODO: add assertions to method AphidObjectTest.GetPropertyInfo(Object, Boolean)
        }

        [PexMethod]
        public AphidObject Scope01(AphidObject parentScope)
        {
            AphidObject result = AphidObject.Scope(parentScope);
            return result;
            // TODO: add assertions to method AphidObjectTest.Scope01(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(IndexOutOfRangeException))]
        public void Bind(
            [PexAssumeUnderTest]AphidObject target,
            object obj,
            bool invokeEvents
        )
        {
            target.Bind(obj, invokeEvents);
            // TODO: add assertions to method AphidObjectTest.Bind(AphidObject, Object, Boolean)
        }

        [PexMethod]
        public AphidObject Complex()
        {
            AphidObject result = AphidObject.Complex();
            return result;
            // TODO: add assertions to method AphidObjectTest.Complex()
        }

        [PexMethod]
        public AphidObject Complex01(IEnumerable<KeyValuePair<string, AphidObject>> members)
        {
            AphidObject result = AphidObject.Complex(members);
            return result;
            // TODO: add assertions to method AphidObjectTest.Complex01(IEnumerable`1<KeyValuePair`2<String,AphidObject>>)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public AphidObject ConvertFrom(Type t, object o)
        {
            AphidObject result = AphidObject.ConvertFrom(t, o);
            return result;
            // TODO: add assertions to method AphidObjectTest.ConvertFrom(Type, Object)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public AphidObject ConvertFrom01(
            Type t,
            object o,
            bool allProperties
        )
        {
            AphidObject result = AphidObject.ConvertFrom(t, o, allProperties);
            return result;
            // TODO: add assertions to method AphidObjectTest.ConvertFrom01(Type, Object, Boolean)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public AphidObject ConvertFrom02<T>(T o)
        {
            AphidObject result = AphidObject.ConvertFrom<T>(o);
            return result;
            // TODO: add assertions to method AphidObjectTest.ConvertFrom02(!!0)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public T ConvertTo<T>([PexAssumeUnderTest]AphidObject target)
            where T : new()
        {
            T result = target.ConvertTo<T>();
            return result;
            // TODO: add assertions to method AphidObjectTest.ConvertTo(AphidObject)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public TElement[] ConvertToArray<TElement>([PexAssumeUnderTest]AphidObject target)
            where TElement : new()
        {
            TElement[] result = target.ConvertToArray<TElement>();
            return result;
            // TODO: add assertions to method AphidObjectTest.ConvertToArray(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(InvalidOperationException))]
        public void CopyTo([PexAssumeUnderTest]AphidObject target, AphidObject obj)
        {
            target.CopyTo(obj);
            // TODO: add assertions to method AphidObjectTest.CopyTo(AphidObject, AphidObject)
        }

        [PexMethod]
        public AphidObject CreateChild([PexAssumeUnderTest]AphidObject target)
        {
            AphidObject result = target.CreateChild();
            return result;
            // TODO: add assertions to method AphidObjectTest.CreateChild(AphidObject)
        }

        [PexMethod]
        public AphidObject[] FlattenScope([PexAssumeUnderTest]AphidObject target)
        {
            AphidObject[] result = target.FlattenScope();
            return result;
            // TODO: add assertions to method AphidObjectTest.FlattenScope(AphidObject)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(InvalidCastException))]
        public TValue Get<TValue>([PexAssumeUnderTest]AphidObject target)
        {
            TValue result = target.Get<TValue>();
            return result;
            // TODO: add assertions to method AphidObjectTest.Get(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(InvalidCastException))]
        public bool GetBool([PexAssumeUnderTest]AphidObject target)
        {
            bool result = target.GetBool();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetBool(AphidObject)
        }

        [PexMethod]
        public int GetDeepHashCode([PexAssumeUnderTest]AphidObject target)
        {
            int result = target.GetDeepHashCode();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetDeepHashCode(AphidObject)
        }

        [PexMethod]
        public AphidFunction GetFunction([PexAssumeUnderTest]AphidObject target)
        {
            AphidFunction result = target.GetFunction();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetFunction(AphidObject)
        }

        [PexMethod]
        public int GetHashCode01([PexAssumeUnderTest]AphidObject target)
        {
            int result = target.GetHashCode();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetHashCode01(AphidObject)
        }

        [PexMethod]
        public List<AphidObject> GetList([PexAssumeUnderTest]AphidObject target)
        {
            List<AphidObject> result = target.GetList();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetList(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(InvalidCastException))]
        public decimal GetNumber([PexAssumeUnderTest]AphidObject target)
        {
            decimal result = target.GetNumber();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetNumber(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public void GetObjectData(
            [PexAssumeUnderTest]AphidObject target,
            SerializationInfo info,
            StreamingContext context
        )
        {
            target.GetObjectData(info, context);
            // TODO: add assertions to method AphidObjectTest.GetObjectData(AphidObject, SerializationInfo, StreamingContext)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public List<AphidObject> GetScopeAncestors(AphidObject scope)
        {
            List<AphidObject> result = AphidObject.GetScopeAncestors(scope);
            return result;
            // TODO: add assertions to method AphidObjectTest.GetScopeAncestors(AphidObject)
        }

        [PexMethod]
        public string GetString([PexAssumeUnderTest]AphidObject target)
        {
            string result = target.GetString();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetString(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public IEnumerable<string> GetStringList([PexAssumeUnderTest]AphidObject target)
        {
            IEnumerable<string> result = target.GetStringList();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetStringList(AphidObject)
        }

        [PexMethod]
        public string GetTypeName([PexAssumeUnderTest]AphidObject target)
        {
            string result = target.GetTypeName();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetTypeName(AphidObject)
        }

        [PexMethod]
        public string GetValueType([PexAssumeUnderTest]AphidObject target)
        {
            string result = target.GetValueType();
            return result;
            // TODO: add assertions to method AphidObjectTest.GetValueType(AphidObject)
        }

        [PexMethod]
        public string GetValueType01([PexAssumeUnderTest]AphidObject target, bool includeClrTypes)
        {
            string result = target.GetValueType(includeClrTypes);
            return result;
            // TODO: add assertions to method AphidObjectTest.GetValueType01(AphidObject, Boolean)
        }

        [PexMethod]
        public bool IsAphidType([PexAssumeUnderTest]AphidObject target)
        {
            bool result = target.IsAphidType();
            return result;
            // TODO: add assertions to method AphidObjectTest.IsAphidType(AphidObject)
        }

        [PexMethod]
        public bool IsAphidType01(object obj)
        {
            bool result = AphidObject.IsAphidType(obj);
            return result;
            // TODO: add assertions to method AphidObjectTest.IsAphidType01(Object)
        }

        [PexMethod]
        public bool IsComplexitySetGet([PexAssumeUnderTest]AphidObject target)
        {
            bool result = target.IsComplexitySet;
            return result;
            // TODO: add assertions to method AphidObjectTest.IsComplexitySetGet(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public bool IsDefined([PexAssumeUnderTest]AphidObject target, string key)
        {
            bool result = target.IsDefined(key);
            return result;
            // TODO: add assertions to method AphidObjectTest.IsDefined(AphidObject, String)
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        [PexAllowedException(typeof(NullReferenceException))]
        public AphidObject Resolve(
            [PexAssumeUnderTest]AphidObject target,
            AphidInterpreter interpreter,
            string key,
            string errorMessage
        )
        {
            AphidObject result = target.Resolve(interpreter, key, errorMessage);
            return result;
            // TODO: add assertions to method AphidObjectTest.Resolve(AphidObject, AphidInterpreter, String, String)
        }

        [PexMethod]
        public AphidObject Scalar(object value)
        {
            AphidObject result = AphidObject.Scalar(value);
            return result;
            // TODO: add assertions to method AphidObjectTest.Scalar(Object)
        }

        [PexMethod]
        public AphidObject Scope()
        {
            AphidObject result = AphidObject.Scope();
            return result;
            // TODO: add assertions to method AphidObjectTest.Scope()
        }

        [PexMethod]
        public string ToString01([PexAssumeUnderTest]AphidObject target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method AphidObjectTest.ToString01(AphidObject)
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public bool TryResolve(
            [PexAssumeUnderTest]AphidObject target,
            string key,
            out AphidObject value
        )
        {
            bool result = target.TryResolve(key, out value);
            return result;
            // TODO: add assertions to method AphidObjectTest.TryResolve(AphidObject, String, AphidObject&)
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public bool TryResolveAndRemove([PexAssumeUnderTest]AphidObject target, string key)
        {
            bool result = target.TryResolveAndRemove(key);
            return result;
            // TODO: add assertions to method AphidObjectTest.TryResolveAndRemove(AphidObject, String)
        }
    }
}
