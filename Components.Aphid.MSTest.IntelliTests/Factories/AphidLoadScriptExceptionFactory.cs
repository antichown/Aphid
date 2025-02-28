using System.Runtime.Serialization;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.Interpreter;
using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Interpreter
{
    /// <summary>A factory for Components.Aphid.Interpreter.AphidLoadScriptException instances</summary>
    public static partial class AphidLoadScriptExceptionFactory
    {
        /// <summary>A factory for Components.Aphid.Interpreter.AphidLoadScriptException instances</summary>
        [PexFactoryMethod(typeof(AphidLoadScriptException))]
        public static AphidLoadScriptException Create(
            AphidInterpreter interpreter_aphidInterpreter,
            AphidObject exceptionScope_aphidObject,
            AphidExpression currentStatement_aphidExpression,
            AphidExpression currentExpression_aphidExpression1,
            string scriptFile_s,
            Exception runtimeException_exception,
            AphidParserException value_aphidParserException,
            AphidRuntimeException value_aphidRuntimeException,
            string value_s1,
            string value_s2,
            string value_s3,
            SerializationInfo info_serializationInfo,
            StreamingContext context_streamingContext
        )
        {
            AphidLoadScriptException aphidLoadScriptException
               = new AphidLoadScriptException(interpreter_aphidInterpreter,
                                              exceptionScope_aphidObject, currentStatement_aphidExpression,
                                              currentExpression_aphidExpression1,
                                              scriptFile_s, runtimeException_exception);
            aphidLoadScriptException.ParserException = value_aphidParserException;
            aphidLoadScriptException.AphidRuntimeException = value_aphidRuntimeException;
            ((AphidRuntimeException)aphidLoadScriptException).Details = value_s1;
            ((Exception)aphidLoadScriptException).HelpLink = value_s2;
            ((Exception)aphidLoadScriptException).Source = value_s3;
            ((AphidRuntimeException)aphidLoadScriptException).GetObjectData
                (info_serializationInfo, context_streamingContext);
            return aphidLoadScriptException;

            // TODO: Edit factory method of AphidLoadScriptException
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
