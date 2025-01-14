using System.Runtime.Serialization;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.Interpreter;
using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Interpreter
{
    /// <summary>A factory for Components.Aphid.Interpreter.AphidRuntimeException instances</summary>
    public static partial class AphidRuntimeExceptionFactory
    {
        /// <summary>A factory for Components.Aphid.Interpreter.AphidRuntimeException instances</summary>
        [PexFactoryMethod(typeof(AphidRuntimeException))]
        public static AphidRuntimeException Create(
            AphidInterpreter interpreter_aphidInterpreter,
            AphidObject exceptionScope_aphidObject,
            AphidExpression currentStatement_aphidExpression,
            AphidExpression currentExpression_aphidExpression1,
            string details_s,
            object[] args_os,
            string value_s1,
            string value_s2,
            string value_s3,
            SerializationInfo info_serializationInfo,
            StreamingContext context_streamingContext
        )
        {
            AphidRuntimeException aphidRuntimeException
               = new AphidRuntimeException(interpreter_aphidInterpreter,
                                           exceptionScope_aphidObject, currentStatement_aphidExpression,
                                           currentExpression_aphidExpression1, details_s, args_os);
            aphidRuntimeException.Details = value_s1;
            ((Exception)aphidRuntimeException).HelpLink = value_s2;
            ((Exception)aphidRuntimeException).Source = value_s3;
            aphidRuntimeException.GetObjectData
                (info_serializationInfo, context_streamingContext);
            return aphidRuntimeException;

            // TODO: Edit factory method of AphidRuntimeException
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
