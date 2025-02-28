using System.Collections.Generic;
using Components.External.ConsolePlus;
using Components.Aphid.TypeSystem;
using System;
using Components.Aphid.UI;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.UI.Tests
{
    /// <summary>This class contains parameterized unit tests for AphidScopeObjectAutocompletionSource</summary>
    [TestClass]
    [PexClass(typeof(AphidScopeObjectAutocompletionSource))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidScopeObjectAutocompletionSourceTest
    {

        /// <summary>Test stub for .ctor(AphidObject)</summary>
        [PexMethod]
        public AphidScopeObjectAutocompletionSource ConstructorTest(AphidObject currentScope)
        {
            AphidScopeObjectAutocompletionSource target = new AphidScopeObjectAutocompletionSource(currentScope)
              ;
            return target;
            // TODO: add assertions to method AphidScopeObjectAutocompletionSourceTest.ConstructorTest(AphidObject)
        }

        /// <summary>Test stub for Dispose()</summary>
        [PexMethod]
        public void DisposeTest([PexAssumeUnderTest]AphidScopeObjectAutocompletionSource target)
        {
            target.Dispose();
            // TODO: add assertions to method AphidScopeObjectAutocompletionSourceTest.DisposeTest(AphidScopeObjectAutocompletionSource)
        }

        /// <summary>Test stub for GetWords(String, Int32, Boolean, String&amp;)</summary>
        [PexMethod]
        public IEnumerable<Autocomplete> GetWordsTest(
            [PexAssumeUnderTest]AphidScopeObjectAutocompletionSource target,
            string text,
            int offset,
            bool allowEmptySearch,
            out string searchBuffer
        )
        {
            IEnumerable<Autocomplete> result = target.GetWords(text, offset, allowEmptySearch, out searchBuffer)
              ;
            return result;
            // TODO: add assertions to method AphidScopeObjectAutocompletionSourceTest.GetWordsTest(AphidScopeObjectAutocompletionSource, String, Int32, Boolean, String&)
        }
    }
}
