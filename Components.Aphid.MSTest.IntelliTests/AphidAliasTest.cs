using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidAlias</summary>
    [TestClass]
    [PexClass(typeof(AphidAlias))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidAliasTest
    {

        /// <summary>Test stub for Resolve(Type)</summary>
        [PexMethod]
        public string ResolveTest(Type type)
        {
            string result = AphidAlias.Resolve(type);
            return result;
            // TODO: add assertions to method AphidAliasTest.ResolveTest(Type)
        }

        /// <summary>Test stub for Resolve(String)</summary>
        [PexMethod]
        public string ResolveTest01(string name)
        {
            string result = AphidAlias.Resolve(name);
            return result;
            // TODO: add assertions to method AphidAliasTest.ResolveTest01(String)
        }
    }
}
