using System;
using Components.External.ConsolePlus;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.External.ConsolePlus.Tests
{
    /// <summary>This class contains parameterized unit tests for AutocompleteConsole</summary>
    [TestClass]
    [PexClass(typeof(AutocompleteConsole))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AutocompleteConsoleTest
    {

        /// <summary>Test stub for .ctor(String, IScanner, ISyntaxHighlighter, IAutocompletionSource, Boolean)</summary>
        [PexMethod]
        public AutocompleteConsole ConstructorTest(
            string prompt,
            IScanner scanner,
            ISyntaxHighlighter highlighter,
            IAutocompletionSource sources,
            bool useNativeApi
        )
        {
            AutocompleteConsole target
               = new AutocompleteConsole(prompt, scanner, highlighter, sources, useNativeApi);
            return target;
            // TODO: add assertions to method AutocompleteConsoleTest.ConstructorTest(String, IScanner, ISyntaxHighlighter, IAutocompletionSource, Boolean)
        }

        /// <summary>Test stub for ReadLine()</summary>
        [PexMethod]
        public string ReadLineTest([PexAssumeUnderTest]AutocompleteConsole target)
        {
            string result = target.ReadLine();
            return result;
            // TODO: add assertions to method AutocompleteConsoleTest.ReadLineTest(AutocompleteConsole)
        }
    }
}
