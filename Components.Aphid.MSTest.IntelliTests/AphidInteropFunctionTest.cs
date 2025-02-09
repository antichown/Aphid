using System.Reflection;
using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidInteropFunction</summary>
    [TestClass]
    [PexClass(typeof(AphidInteropFunction))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidInteropFunctionTest
    {

        /// <summary>Test stub for .ctor(Func`3&lt;AphidInterpreter,Object[],Object&gt;)</summary>
        [PexMethod]
        public AphidInteropFunction ConstructorTest(Func<AphidInterpreter, object[], object> function)
        {
            AphidInteropFunction target = new AphidInteropFunction(function);
            return target;
            // TODO: add assertions to method AphidInteropFunctionTest.ConstructorTest(Func`3<AphidInterpreter,Object[],Object>)
        }

        /// <summary>Test stub for .ctor(AphidInteropFunctionAttribute, MethodInfo)</summary>
        [PexMethod]
        public AphidInteropFunction ConstructorTest01(AphidInteropFunctionAttribute attribute, MethodInfo method)
        {
            AphidInteropFunction target = new AphidInteropFunction(attribute, method);
            return target;
            // TODO: add assertions to method AphidInteropFunctionTest.ConstructorTest01(AphidInteropFunctionAttribute, MethodInfo)
        }

        /// <summary>Test stub for Invoke(AphidInterpreter, Object[])</summary>
        [PexMethod]
        public object InvokeTest(
            [PexAssumeUnderTest]AphidInteropFunction target,
            AphidInterpreter interpreter,
            object[] parms
        )
        {
            object result = target.Invoke(interpreter, parms);
            return result;
            // TODO: add assertions to method AphidInteropFunctionTest.InvokeTest(AphidInteropFunction, AphidInterpreter, Object[])
        }
    }
}
