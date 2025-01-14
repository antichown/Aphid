using System.Collections.Generic;
using System;
using Components;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Tests
{
    /// <summary>This class contains parameterized unit tests for ArgLexer</summary>
    [TestClass]
    [PexClass(typeof(ArgLexer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArgLexerTest
    {

        /// <summary>Test stub for GetTokenInfo(String)</summary>
        [PexMethod]
        public List<ArgToken> GetTokenInfoTest(string args)
        {
            List<ArgToken> result = ArgLexer.GetTokenInfo(args);
            return result;
            // TODO: add assertions to method ArgLexerTest.GetTokenInfoTest(String)
        }

        /// <summary>Test stub for Tokenize(String)</summary>
        [PexMethod]
        public string[] TokenizeTest(string args)
        {
            string[] result = ArgLexer.Tokenize(args);
            return result;
            // TODO: add assertions to method ArgLexerTest.TokenizeTest(String)
        }

        
    }
}
