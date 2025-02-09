using System.Reflection;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidInteropMethodArg</summary>
    [TestClass]
    [PexClass(typeof(AphidInteropMethodArg))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidInteropMethodArgTest
    {

        /// <summary>Test stub for .ctor(Object, ParameterInfoCache)</summary>
        [PexMethod]
        public AphidInteropMethodArg ConstructorTest(object argument, ParameterInfoCache parameterInfo)
        {
            AphidInteropMethodArg target = new AphidInteropMethodArg(argument, parameterInfo);
            return target;
            // TODO: add assertions to method AphidInteropMethodArgTest.ConstructorTest(Object, ParameterInfoCache)
        }

        /// <summary>Test stub for .ctor(Object, ParameterInfoCache, Nullable`1&lt;Boolean&gt;)</summary>
        [PexMethod]
        public AphidInteropMethodArg ConstructorTest01(
            object argument,
            ParameterInfoCache parameterInfo,
            bool? constructsParamArray
        )
        {
            AphidInteropMethodArg target
               = new AphidInteropMethodArg(argument, parameterInfo, constructsParamArray);
            return target;
            // TODO: add assertions to method AphidInteropMethodArgTest.ConstructorTest01(Object, ParameterInfoCache, Nullable`1<Boolean>)
        }

        /// <summary>Test stub for get_ExplicitConversionOperator()</summary>
        [PexMethod]
        public MethodInfo ExplicitConversionOperatorGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            MethodInfo result = target.ExplicitConversionOperator;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.ExplicitConversionOperatorGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_HasExplicitConversion()</summary>
        [PexMethod]
        public bool HasExplicitConversionGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.HasExplicitConversion;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.HasExplicitConversionGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_HasImplicitConversion()</summary>
        [PexMethod]
        public bool HasImplicitConversionGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.HasImplicitConversion;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.HasImplicitConversionGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_HasParamArray()</summary>
        [PexMethod]
        public bool HasParamArrayGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.HasParamArray;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.HasParamArrayGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_HasToStringConversion()</summary>
        [PexMethod]
        public bool HasToStringConversionGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.HasToStringConversion;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.HasToStringConversionGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_ImplicitConversionOperator()</summary>
        [PexMethod]
        public MethodInfo ImplicitConversionOperatorGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            MethodInfo result = target.ImplicitConversionOperator;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.ImplicitConversionOperatorGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_IsDerivedFromUserReferenceType()</summary>
        [PexMethod]
        public bool IsDerivedFromUserReferenceTypeGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.IsDerivedFromUserReferenceType;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.IsDerivedFromUserReferenceTypeGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_IsExactTypeMatch()</summary>
        [PexMethod]
        public bool IsExactTypeMatchGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.IsExactTypeMatch;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.IsExactTypeMatchGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_IsNonRootImplementationOfTarget()</summary>
        [PexMethod]
        public bool IsNonRootImplementationOfTargetGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.IsNonRootImplementationOfTarget;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.IsNonRootImplementationOfTargetGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_IsPrecisionLost()</summary>
        [PexMethod]
        public bool IsPrecisionLostGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.IsPrecisionLost;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.IsPrecisionLostGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_IsSafeConvertibleNumberPair()</summary>
        [PexMethod]
        public bool IsSafeConvertibleNumberPairGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.IsSafeConvertibleNumberPair;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.IsSafeConvertibleNumberPairGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_IsUnsafeConvertibleNumberPair()</summary>
        [PexMethod]
        public bool IsUnsafeConvertibleNumberPairGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            bool result = target.IsUnsafeConvertibleNumberPair;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.IsUnsafeConvertibleNumberPairGetTest(AphidInteropMethodArg)
        }

        /// <summary>Test stub for get_TargetType()</summary>
        [PexMethod]
        public Type TargetTypeGetTest([PexAssumeUnderTest]AphidInteropMethodArg target)
        {
            Type result = target.TargetType;
            return result;
            // TODO: add assertions to method AphidInteropMethodArgTest.TargetTypeGetTest(AphidInteropMethodArg)
        }
    }
}
