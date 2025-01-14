using System.Reflection;
using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidFunctionConverter</summary>
    [TestClass]
    [PexClass(typeof(AphidFunctionConverter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidFunctionConverterTest
    {

        /// <summary>Test stub for .ctor(AphidInterpreter)</summary>
        [PexMethod]
        public AphidFunctionConverter ConstructorTest(AphidInterpreter interpreter)
        {
            AphidFunctionConverter target = new AphidFunctionConverter(interpreter);
            return target;
            // TODO: add assertions to method AphidFunctionConverterTest.ConstructorTest(AphidInterpreter)
        }

        /// <summary>Test stub for Convert(Type, Object, Type[])</summary>
        [PexMethod]
        public Delegate ConvertTest(
            [PexAssumeUnderTest]AphidFunctionConverter target,
            Type methodType,
            object function,
            Type[] genericArguments
        )
        {
            Delegate result = target.Convert(methodType, function, genericArguments);
            return result;
            // TODO: add assertions to method AphidFunctionConverterTest.ConvertTest(AphidFunctionConverter, Type, Object, Type[])
        }

        /// <summary>Test stub for ConvertFunctionWrapper(MethodInfo, Type, AphidFunction, Type[])</summary>
        [PexMethod]
        public Delegate ConvertFunctionWrapperTest(
            [PexAssumeUnderTest]AphidFunctionConverter target,
            MethodInfo method,
            Type delegateType,
            AphidFunction function,
            Type[] genericArguments
        )
        {
            Delegate result = target.ConvertFunctionWrapper(method, delegateType, function, genericArguments);
            return result;
            // TODO: add assertions to method AphidFunctionConverterTest.ConvertFunctionWrapperTest(AphidFunctionConverter, MethodInfo, Type, AphidFunction, Type[])
        }
    }
}
