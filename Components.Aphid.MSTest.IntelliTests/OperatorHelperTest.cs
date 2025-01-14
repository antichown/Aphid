using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for OperatorHelper</summary>
    [TestClass]
    [PexClass(typeof(OperatorHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OperatorHelperTest
    {

        /// <summary>Test stub for .ctor(AphidInterpreter)</summary>
        [PexMethod]
        public OperatorHelper ConstructorTest(AphidInterpreter interpreter)
        {
            OperatorHelper target = new OperatorHelper(interpreter);
            return target;
            // TODO: add assertions to method OperatorHelperTest.ConstructorTest(AphidInterpreter)
        }

        /// <summary>Test stub for Add(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject AddTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Add(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.AddTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for BinaryAnd(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject BinaryAndTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.BinaryAnd(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.BinaryAndTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for BinaryOr(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject BinaryOrTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.BinaryOr(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.BinaryOrTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for BinaryShiftLeft(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject BinaryShiftLeftTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.BinaryShiftLeft(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.BinaryShiftLeftTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for BinaryShiftRight(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject BinaryShiftRightTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.BinaryShiftRight(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.BinaryShiftRightTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for Divide(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject DivideTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Divide(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.DivideTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for Equals(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject EqualsTest(AphidObject x, AphidObject y)
        {
            AphidObject result = OperatorHelper.Equals(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.EqualsTest(AphidObject, AphidObject)
        }

        /// <summary>Test stub for Equals(AphidInterpreter, Object, Object)</summary>
        [PexMethod]
        public bool EqualsTest01(
            AphidInterpreter instance,
            object left,
            object right
        )
        {
            bool result = OperatorHelper.Equals(instance, left, right);
            return result;
            // TODO: add assertions to method OperatorHelperTest.EqualsTest01(AphidInterpreter, Object, Object)
        }

        /// <summary>Test stub for EqualsCore(AphidObject, AphidObject)</summary>
        [PexMethod]
        public bool EqualsCoreTest(AphidObject x, AphidObject y)
        {
            bool result = OperatorHelper.EqualsCore(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.EqualsCoreTest(AphidObject, AphidObject)
        }

        /// <summary>Test stub for Mod(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject ModTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Mod(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.ModTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for Multiply(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject MultiplyTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Multiply(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.MultiplyTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for NotEqual(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject NotEqualTest(AphidObject x, AphidObject y)
        {
            AphidObject result = OperatorHelper.NotEqual(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.NotEqualTest(AphidObject, AphidObject)
        }

        /// <summary>Test stub for Range(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject RangeTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Range(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.RangeTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for Subtract(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject SubtractTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Subtract(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.SubtractTest(OperatorHelper, AphidObject, AphidObject)
        }

        /// <summary>Test stub for Xor(AphidObject, AphidObject)</summary>
        [PexMethod]
        public AphidObject XorTest(
            [PexAssumeUnderTest]OperatorHelper target,
            AphidObject x,
            AphidObject y
        )
        {
            AphidObject result = target.Xor(x, y);
            return result;
            // TODO: add assertions to method OperatorHelperTest.XorTest(OperatorHelper, AphidObject, AphidObject)
        }
    }
}
