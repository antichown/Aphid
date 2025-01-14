using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for ArgumentTypeCache</summary>
    [TestClass]
    [PexClass(typeof(ArgumentTypeCache))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArgumentTypeCacheTest
    {

        /// <summary>Test stub for .ctor(Type, ParameterInfoCache, Type)</summary>
        [PexMethod]
        public ArgumentTypeCache ConstructorTest(
            Type argumentType,
            ParameterInfoCache targetParam,
            Type targetType
        )
        {
            ArgumentTypeCache target = new ArgumentTypeCache(argumentType, targetParam, targetType);
            return target;
            // TODO: add assertions to method ArgumentTypeCacheTest.ConstructorTest(Type, ParameterInfoCache, Type)
        }
    }
}
