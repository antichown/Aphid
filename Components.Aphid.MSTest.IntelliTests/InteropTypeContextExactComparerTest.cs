using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for InteropTypeContextExactComparer</summary>
    [TestClass]
    [PexClass(typeof(InteropTypeContextExactComparer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class InteropTypeContextExactComparerTest
    {

        /// <summary>Test stub for Equals(InteropTypeContext, InteropTypeContext)</summary>
        [PexMethod]
        public bool EqualsTest(
            [PexAssumeUnderTest]InteropTypeContextExactComparer target,
            InteropTypeContext x,
            InteropTypeContext y
        )
        {
            bool result = target.Equals(x, y);
            return result;
            // TODO: add assertions to method InteropTypeContextExactComparerTest.EqualsTest(InteropTypeContextExactComparer, InteropTypeContext, InteropTypeContext)
        }

        /// <summary>Test stub for GetHashCode(InteropTypeContext)</summary>
        [PexMethod]
        public int GetHashCodeTest([PexAssumeUnderTest]InteropTypeContextExactComparer target, InteropTypeContext obj)
        {
            int result = target.GetHashCode(obj);
            return result;
            // TODO: add assertions to method InteropTypeContextExactComparerTest.GetHashCodeTest(InteropTypeContextExactComparer, InteropTypeContext)
        }
    }
}
