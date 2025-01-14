using System.Runtime.Serialization;
using System.Reflection;
using System;
using Microsoft.Pex.Framework;

namespace System.Reflection
{
    /// <summary>A factory for System.Reflection.TargetInvocationException instances</summary>
    public static partial class TargetInvocationExceptionFactory
    {
        /// <summary>A factory for System.Reflection.TargetInvocationException instances</summary>
        [PexFactoryMethod(typeof(TargetInvocationException))]
        public static TargetInvocationException Create(
            string message_s,
            Exception inner_exception,
            string value_s1,
            string value_s2,
            SerializationInfo info_serializationInfo,
            StreamingContext context_streamingContext
        )
        {
            TargetInvocationException targetInvocationException
               = new TargetInvocationException(message_s, inner_exception);
            ((Exception)targetInvocationException).HelpLink = value_s1;
            ((Exception)targetInvocationException).Source = value_s2;
            ((Exception)targetInvocationException).GetObjectData
                (info_serializationInfo, context_streamingContext);
            return targetInvocationException;

            // TODO: Edit factory method of TargetInvocationException
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
