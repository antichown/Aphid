using System;
using Components.Aphid.Lexer;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.Lexer.Tests
{
    /// <summary>This class contains parameterized unit tests for TokenHelper</summary>
    [TestClass]
    [PexClass(typeof(TokenHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TokenHelperTest
    {

        /// <summary>Test stub for GetBraces(String, Int32, Int32)</summary>
        [PexMethod]
        public int[][] GetBracesTest(
            string text,
            int line,
            int col
        )
        {
            int[][] result = TokenHelper.GetBraces(text, line, col);
            return result;
            // TODO: add assertions to method TokenHelperTest.GetBracesTest(String, Int32, Int32)
        }

        /// <summary>Test stub for GetCodeExcerpt(String, AphidToken&amp;, Int32)</summary>
        [PexMethod]
        public string GetCodeExcerptTest(
            string code,
            in AphidToken token,
            int surroundingLines
        )
        {
            string result = TokenHelper.GetCodeExcerpt(code, in token, surroundingLines);
            return result;
            // TODO: add assertions to method TokenHelperTest.GetCodeExcerptTest(String, AphidToken&, Int32)
        }

        /// <summary>Test stub for GetCodeExcerpt(String, Int32, Int32)</summary>
        [PexMethod]
        public string GetCodeExcerptTest01(
            string code,
            int index,
            int surroundingLines
        )
        {
            string result = TokenHelper.GetCodeExcerpt(code, index, surroundingLines);
            return result;
            // TODO: add assertions to method TokenHelperTest.GetCodeExcerptTest01(String, Int32, Int32)
        }

        /// <summary>Test stub for GetIndex(String, Int32, Int32)</summary>
        [PexMethod]
        public int GetIndexTest(
            string text,
            int line,
            int col
        )
        {
            int result = TokenHelper.GetIndex(text, line, col);
            return result;
            // TODO: add assertions to method TokenHelperTest.GetIndexTest(String, Int32, Int32)
        }

        /// <summary>Test stub for GetIndexPosition(String, Int32)</summary>
        [PexMethod]
        public Tuple<int, int> GetIndexPositionTest(string text, int index)
        {
            Tuple<int, int> result = TokenHelper.GetIndexPosition(text, index);
            return result;
            // TODO: add assertions to method TokenHelperTest.GetIndexPositionTest(String, Int32)
        }
    }
}
