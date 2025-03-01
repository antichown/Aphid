using Components.Aphid.Parser;
using System.Threading;
using Components.Aphid.Interpreter;
using System.Reflection;
// <copyright file="TypeExtenderTest.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    [TestClass]
    [PexClass(typeof(TypeExtender))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TypeExtenderTest
    {

        [PexMethod]
        [PexMethodUnderTest("GetGenericInteropName(Type)")]
        internal string GetGenericInteropName(Type t)
        {
            object[] args = new object[1];
            args[0] = (object)t;
            Type[] parameterTypes = new Type[1];
            parameterTypes[0] = typeof(Type);
            string result0 = ((MethodBase)(typeof(TypeExtender).GetMethod("GetGenericInteropName",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.Standard, parameterTypes, (ParameterModifier[])null)))
                                 .Invoke((object)null, args) as string;
            string result = result0;
            return result;
            // TODO: add assertions to method TypeExtenderTest.GetGenericInteropName(Type)
        }

        [PexMethod]
        public TypeExtender Constructor(AphidInterpreter interpreter, ReaderWriterLockSlim importsLock)
        {
            TypeExtender target = new TypeExtender(interpreter, importsLock);
            return target;
            // TODO: add assertions to method TypeExtenderTest.Constructor(AphidInterpreter, ReaderWriterLockSlim)
        }

        [PexMethod]
        public void Extend01(
            [PexAssumeUnderTest]TypeExtender target,
            string type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler
        )
        {
            target.Extend(type, extensions, ctorHandler, dynamicHandler);
            // TODO: add assertions to method TypeExtenderTest.Extend01(TypeExtender, String, AphidObject, String, String)
        }

        [PexMethod]
        public AphidObject TryResolve02(
            AphidObject scope,
            AphidObject obj,
            string[] classHierarchy,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool isStatic,
            bool returnRef
        )
        {
            AphidObject result = TypeExtender.TryResolve
                                     (scope, obj, classHierarchy, key, isAphidType, isCtor, isDynamic, isStatic, returnRef);
            return result;
            // TODO: add assertions to method TypeExtenderTest.TryResolve02(AphidObject, AphidObject, String[], String, Boolean, Boolean, Boolean, Boolean, Boolean)
        }

        [PexMethod]
        public AphidObject TryResolve01(
            AphidObject scope,
            Type staticType,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef
        )
        {
            AphidObject result
               = TypeExtender.TryResolve(scope, staticType, key, isAphidType, isCtor, isDynamic, returnRef);
            return result;
            // TODO: add assertions to method TypeExtenderTest.TryResolve01(AphidObject, Type, String, Boolean, Boolean, Boolean, Boolean)
        }

        [PexMethod]
        public AphidObject TryResolve(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef
        )
        {
            AphidObject result
               = TypeExtender.TryResolve(scope, obj, key, isAphidType, isCtor, isDynamic, returnRef);
            return result;
            // TODO: add assertions to method TypeExtenderTest.TryResolve(AphidObject, AphidObject, String, Boolean, Boolean, Boolean, Boolean)
        }

        [PexMethod]
        public string GetCtorName(string type)
        {
            string result = TypeExtender.GetCtorName(type);
            return result;
            // TODO: add assertions to method TypeExtenderTest.GetCtorName(String)
        }

        [PexMethod]
        public void Extend02(
            [PexAssumeUnderTest]TypeExtender target,
            string type,
            string[] attributes,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler
        )
        {
            target.Extend(type, attributes, extensions, ctorHandler, dynamicHandler);
            // TODO: add assertions to method TypeExtenderTest.Extend02(TypeExtender, String, String[], AphidObject, String, String)
        }

        /// <summary>Test stub for .ctor(AphidInterpreter, ReaderWriterLockSlim)</summary>
        [PexMethod]
        public TypeExtender ConstructorTest(AphidInterpreter interpreter, ReaderWriterLockSlim importsLock)
        {
            TypeExtender target = new TypeExtender(interpreter, importsLock);
            return target;
            // TODO: add assertions to method TypeExtenderTest.ConstructorTest(AphidInterpreter, ReaderWriterLockSlim)
        }

        /// <summary>Test stub for Extend(IdentifierExpression, AphidObject, String, String)</summary>
        [PexMethod]
        public void ExtendTest(
            [PexAssumeUnderTest]TypeExtender target,
            IdentifierExpression type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler
        )
        {
            target.Extend(type, extensions, ctorHandler, dynamicHandler);
            // TODO: add assertions to method TypeExtenderTest.ExtendTest(TypeExtender, IdentifierExpression, AphidObject, String, String)
        }

        /// <summary>Test stub for Extend(String, AphidObject, String, String)</summary>
        [PexMethod]
        public void ExtendTest01(
            [PexAssumeUnderTest]TypeExtender target,
            string type,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler
        )
        {
            target.Extend(type, extensions, ctorHandler, dynamicHandler);
            // TODO: add assertions to method TypeExtenderTest.ExtendTest01(TypeExtender, String, AphidObject, String, String)
        }

        /// <summary>Test stub for Extend(String, String[], AphidObject, String, String)</summary>
        [PexMethod]
        public void ExtendTest02(
            [PexAssumeUnderTest]TypeExtender target,
            string type,
            string[] attributes,
            AphidObject extensions,
            string ctorHandler,
            string dynamicHandler
        )
        {
            target.Extend(type, attributes, extensions, ctorHandler, dynamicHandler);
            // TODO: add assertions to method TypeExtenderTest.ExtendTest02(TypeExtender, String, String[], AphidObject, String, String)
        }

        /// <summary>Test stub for GetCtorName(String)</summary>
        [PexMethod]
        public string GetCtorNameTest(string type)
        {
            string result = TypeExtender.GetCtorName(type);
            return result;
            // TODO: add assertions to method TypeExtenderTest.GetCtorNameTest(String)
        }

        /// <summary>Test stub for TryResolve(AphidObject, AphidObject, String, Boolean, Boolean, Boolean, Boolean)</summary>
        [PexMethod]
        public AphidObject TryResolveTest(
            AphidObject scope,
            AphidObject obj,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef
        )
        {
            AphidObject result
               = TypeExtender.TryResolve(scope, obj, key, isAphidType, isCtor, isDynamic, returnRef);
            return result;
            // TODO: add assertions to method TypeExtenderTest.TryResolveTest(AphidObject, AphidObject, String, Boolean, Boolean, Boolean, Boolean)
        }

        /// <summary>Test stub for TryResolve(AphidObject, Type, String, Boolean, Boolean, Boolean, Boolean)</summary>
        [PexMethod]
        public AphidObject TryResolveTest01(
            AphidObject scope,
            Type staticType,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool returnRef
        )
        {
            AphidObject result
               = TypeExtender.TryResolve(scope, staticType, key, isAphidType, isCtor, isDynamic, returnRef);
            return result;
            // TODO: add assertions to method TypeExtenderTest.TryResolveTest01(AphidObject, Type, String, Boolean, Boolean, Boolean, Boolean)
        }

        /// <summary>Test stub for TryResolve(AphidObject, AphidObject, String[], String, Boolean, Boolean, Boolean, Boolean, Boolean)</summary>
        [PexMethod]
        public AphidObject TryResolveTest02(
            AphidObject scope,
            AphidObject obj,
            string[] classHierarchy,
            string key,
            bool isAphidType,
            bool isCtor,
            bool isDynamic,
            bool isStatic,
            bool returnRef
        )
        {
            AphidObject result = TypeExtender.TryResolve
                                     (scope, obj, classHierarchy, key, isAphidType, isCtor, isDynamic, isStatic, returnRef);
            return result;
            // TODO: add assertions to method TypeExtenderTest.TryResolveTest02(AphidObject, AphidObject, String[], String, Boolean, Boolean, Boolean, Boolean, Boolean)
        }

        /// <summary>Test stub for .ctor(AphidInterpreter, ReaderWriterLockSlim)</summary>
        
    }
}
