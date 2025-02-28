using System.Text;
using System.Collections.Generic;
using System;
using Components.External.ConsolePlus;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.External.ConsolePlus.Tests
{
    /// <summary>This class contains parameterized unit tests for Cli</summary>
    [TestClass]
    [PexClass(typeof(Cli))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CliTest
    {

        /// <summary>Test stub for Clear()</summary>
        [PexMethod]
        public void ClearTest()
        {
            Cli.Clear();
            // TODO: add assertions to method CliTest.ClearTest()
        }

        /// <summary>Test stub for CreateTable(Object, Boolean)</summary>
        [PexMethod]
        public IEnumerable<KeyValuePair<string, string>> CreateTableTest(object obj, bool escapeLines)
        {
            IEnumerable<KeyValuePair<string, string>> result = Cli.CreateTable(obj, escapeLines);
            return result;
            // TODO: add assertions to method CliTest.CreateTableTest(Object, Boolean)
        }

        /// <summary>Test stub for Dump(!!0, DumpMode)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void DumpTest<T>(T obj, DumpMode mode)
        {
            Cli.Dump<T>(obj, mode);
            // TODO: add assertions to method CliTest.DumpTest(!!0, DumpMode)
        }

        /// <summary>Test stub for Dump(!!0)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void DumpTest01<T>(T obj)
        {
            Cli.Dump<T>(obj);
            // TODO: add assertions to method CliTest.DumpTest01(!!0)
        }

        /// <summary>Test stub for DumpTable(IEnumerable`1&lt;KeyValuePair`2&lt;String,String&gt;&gt;)</summary>
        [PexMethod]
        public void DumpTableTest(IEnumerable<KeyValuePair<string, string>> nameValuePairs)
        {
            Cli.DumpTable(nameValuePairs);
            // TODO: add assertions to method CliTest.DumpTableTest(IEnumerable`1<KeyValuePair`2<String,String>>)
        }

        /// <summary>Test stub for EraseStyles(String)</summary>
        [PexMethod]
        public string EraseStylesTest(string text)
        {
            string result = Cli.EraseStyles(text);
            return result;
            // TODO: add assertions to method CliTest.EraseStylesTest(String)
        }

        /// <summary>Test stub for EraseStyles(String, Func`2&lt;StringBuilder,StringBuilder&gt;)</summary>
        [PexMethod]
        public void EraseStylesTest01(string text, Func<StringBuilder, StringBuilder> callback)
        {
            Cli.EraseStyles(text, callback);
            // TODO: add assertions to method CliTest.EraseStylesTest01(String, Func`2<StringBuilder,StringBuilder>)
        }

        /// <summary>Test stub for Escape(String)</summary>
        [PexMethod]
        public string EscapeTest(string value)
        {
            string result = Cli.Escape(value);
            return result;
            // TODO: add assertions to method CliTest.EscapeTest(String)
        }

        /// <summary>Test stub for FormatEscape(String)</summary>
        [PexMethod]
        public string FormatEscapeTest(string value)
        {
            string result = Cli.FormatEscape(value);
            return result;
            // TODO: add assertions to method CliTest.FormatEscapeTest(String)
        }

        /// <summary>Test stub for FormatEscape(Object)</summary>
        [PexMethod]
        public string FormatEscapeTest01(object value)
        {
            string result = Cli.FormatEscape(value);
            return result;
            // TODO: add assertions to method CliTest.FormatEscapeTest01(Object)
        }

        /// <summary>Test stub for Lock(Action)</summary>
        [PexMethod]
        public void LockTest(Action action)
        {
            Cli.Lock(action);
            // TODO: add assertions to method CliTest.LockTest(Action)
        }

        /// <summary>Test stub for StyleEscape(Object)</summary>
        [PexMethod]
        public string StyleEscapeTest(object value)
        {
            string result = Cli.StyleEscape(value);
            return result;
            // TODO: add assertions to method CliTest.StyleEscapeTest(Object)
        }

        /// <summary>Test stub for StyleEscape(String)</summary>
        [PexMethod]
        public string StyleEscapeTest01(string value)
        {
            string result = Cli.StyleEscape(value);
            return result;
            // TODO: add assertions to method CliTest.StyleEscapeTest01(String)
        }

        /// <summary>Test stub for Write(String, Object)</summary>
        [PexMethod]
        public void WriteTest(string format, object arg0)
        {
            Cli.Write(format, arg0);
            // TODO: add assertions to method CliTest.WriteTest(String, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object)</summary>
        [PexMethod]
        public void WriteTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.Write(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteTest01(String, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.Write(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.Write(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.Write(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.Write(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.Write(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.Write(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for Write(String, Object[])</summary>
        [PexMethod]
        public void WriteTest08(string format, object[] arg)
        {
            Cli.Write(format, arg);
            // TODO: add assertions to method CliTest.WriteTest08(String, Object[])
        }

        /// <summary>Test stub for Write(String)</summary>
        [PexMethod]
        public void WriteTest09(string message)
        {
            Cli.Write(message);
            // TODO: add assertions to method CliTest.WriteTest09(String)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest(string format, object arg0)
        {
            Cli.WriteCriticalErrorMessage(format, arg0);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest(String, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest01(String, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.WriteCriticalErrorMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String)</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest08(string message)
        {
            Cli.WriteCriticalErrorMessage(message);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest08(String)
        }

        /// <summary>Test stub for WriteCriticalErrorMessage(String, Object[])</summary>
        [PexMethod]
        public void WriteCriticalErrorMessageTest09(string format, object[] arg)
        {
            Cli.WriteCriticalErrorMessage(format, arg);
            // TODO: add assertions to method CliTest.WriteCriticalErrorMessageTest09(String, Object[])
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest(string format, object arg0)
        {
            Cli.WriteErrorMessage(format, arg0);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest(String, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest01(String, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteErrorMessageTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.WriteErrorMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteErrorMessage(String)</summary>
        [PexMethod]
        public void WriteErrorMessageTest08(string message)
        {
            Cli.WriteErrorMessage(message);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest08(String)
        }

        /// <summary>Test stub for WriteErrorMessage(String, Object[])</summary>
        [PexMethod]
        public void WriteErrorMessageTest09(string format, object[] arg)
        {
            Cli.WriteErrorMessage(format, arg);
            // TODO: add assertions to method CliTest.WriteErrorMessageTest09(String, Object[])
        }

        /// <summary>Test stub for WriteHeader(String, String)</summary>
        [PexMethod]
        public void WriteHeaderTest(string text, string style)
        {
            Cli.WriteHeader(text, style);
            // TODO: add assertions to method CliTest.WriteHeaderTest(String, String)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest(string format, object arg0)
        {
            Cli.WriteInfoMessage(format, arg0);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest(String, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest01(String, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteInfoMessageTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.WriteInfoMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteInfoMessage(String)</summary>
        [PexMethod]
        public void WriteInfoMessageTest08(string message)
        {
            Cli.WriteInfoMessage(message);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest08(String)
        }

        /// <summary>Test stub for WriteInfoMessage(String, Object[])</summary>
        [PexMethod]
        public void WriteInfoMessageTest09(string format, object[] arg)
        {
            Cli.WriteInfoMessage(format, arg);
            // TODO: add assertions to method CliTest.WriteInfoMessageTest09(String, Object[])
        }

        /// <summary>Test stub for WriteLine(String, Object)</summary>
        [PexMethod]
        public void WriteLineTest(string format, object arg0)
        {
            Cli.WriteLine(format, arg0);
            // TODO: add assertions to method CliTest.WriteLineTest(String, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.WriteLine(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteLineTest01(String, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.WriteLine(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteLineTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.WriteLine(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteLineTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.WriteLine(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteLineTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.WriteLine(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteLineTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.WriteLine(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteLineTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteLineTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.WriteLine(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteLineTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteLine(String, Object[])</summary>
        [PexMethod]
        public void WriteLineTest08(string format, object[] arg)
        {
            Cli.WriteLine(format, arg);
            // TODO: add assertions to method CliTest.WriteLineTest08(String, Object[])
        }

        /// <summary>Test stub for WriteLine(String)</summary>
        [PexMethod]
        public void WriteLineTest09(string message)
        {
            Cli.WriteLine(message);
            // TODO: add assertions to method CliTest.WriteLineTest09(String)
        }

        /// <summary>Test stub for WriteLine()</summary>
        [PexMethod]
        public void WriteLineTest10()
        {
            Cli.WriteLine();
            // TODO: add assertions to method CliTest.WriteLineTest10()
        }

        /// <summary>Test stub for WriteMessage(ConsoleColor, Char, String, Object[])</summary>
        [PexMethod]
        public void WriteMessageTest(
            ConsoleColor tokenColor,
            char token,
            string format,
            object[] arg
        )
        {
            Cli.WriteMessage(tokenColor, token, format, arg);
            // TODO: add assertions to method CliTest.WriteMessageTest(ConsoleColor, Char, String, Object[])
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest(string format, object arg0)
        {
            Cli.WriteQueryMessage(format, arg0);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest(String, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest01(String, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteQueryMessageTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.WriteQueryMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteQueryMessage(String)</summary>
        [PexMethod]
        public void WriteQueryMessageTest08(string message)
        {
            Cli.WriteQueryMessage(message);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest08(String)
        }

        /// <summary>Test stub for WriteQueryMessage(String, Object[])</summary>
        [PexMethod]
        public void WriteQueryMessageTest09(string format, object[] arg)
        {
            Cli.WriteQueryMessage(format, arg);
            // TODO: add assertions to method CliTest.WriteQueryMessageTest09(String, Object[])
        }

        /// <summary>Test stub for WriteSubheader(String, String)</summary>
        [PexMethod]
        public void WriteSubheaderTest(string text, string style)
        {
            Cli.WriteSubheader(text, style);
            // TODO: add assertions to method CliTest.WriteSubheaderTest(String, String)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest(string format, object arg0)
        {
            Cli.WriteSuccessMessage(format, arg0);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest(String, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest01(
            string format,
            object arg0,
            object arg1
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest01(String, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest02(
            string format,
            object arg0,
            object arg1,
            object arg2
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1, arg2);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest02(String, Object, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest03(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1, arg2, arg3);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest03(String, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest04(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1, arg2, arg3, arg4);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest04(String, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest05(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1, arg2, arg3, arg4, arg5);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest05(String, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest06(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest06(String, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object, Object, Object, Object, Object, Object, Object, Object)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest07(
            string format,
            object arg0,
            object arg1,
            object arg2,
            object arg3,
            object arg4,
            object arg5,
            object arg6,
            object arg7
        )
        {
            Cli.WriteSuccessMessage(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest07(String, Object, Object, Object, Object, Object, Object, Object, Object)
        }

        /// <summary>Test stub for WriteSuccessMessage(String)</summary>
        [PexMethod]
        public void WriteSuccessMessageTest08(string message)
        {
            Cli.WriteSuccessMessage(message);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest08(String)
        }

        /// <summary>Test stub for WriteSuccessMessage(String, Object[])</summary>
        [PexMethod]
        public void WriteSuccessMessageTest09(string format, object[] arg)
        {
            Cli.WriteSuccessMessage(format, arg);
            // TODO: add assertions to method CliTest.WriteSuccessMessageTest09(String, Object[])
        }

        /// <summary>Test stub for get_BufferHeight()</summary>
        [PexMethod]
        public int BufferHeightGetTest()
        {
            int result = Cli.BufferHeight;
            return result;
            // TODO: add assertions to method CliTest.BufferHeightGetTest()
        }

        /// <summary>Test stub for get_BufferWidth()</summary>
        [PexMethod]
        public int BufferWidthGetTest()
        {
            int result = Cli.BufferWidth;
            return result;
            // TODO: add assertions to method CliTest.BufferWidthGetTest()
        }

        /// <summary>Test stub for get_HasConsole()</summary>
        [PexMethod]
        public bool HasConsoleGetTest()
        {
            bool result = Cli.HasConsole;
            return result;
            // TODO: add assertions to method CliTest.HasConsoleGetTest()
        }

        /// <summary>Test stub for get_UseTrace()</summary>
        [PexMethod]
        public bool UseTraceGetTest()
        {
            bool result = Cli.UseTrace;
            return result;
            // TODO: add assertions to method CliTest.UseTraceGetTest()
        }

        /// <summary>Test stub for set_UseTrace(Boolean)</summary>
        [PexMethod]
        public void UseTraceSetTest(bool value)
        {
            Cli.UseTrace = value;
            // TODO: add assertions to method CliTest.UseTraceSetTest(Boolean)
        }
    }
}
