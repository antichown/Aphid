using Mantispid;
// <copyright file="CallIdentifierMutatorFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Mantispid
{
    /// <summary>A factory for Mantispid.CallIdentifierMutator instances</summary>
    public static partial class CallIdentifierMutatorFactory
    {
        /// <summary>A factory for Mantispid.CallIdentifierMutator instances</summary>
        [PexFactoryMethod(typeof(CallIdentifierMutator))]
        public static CallIdentifierMutator Create(string[] parseFunctions_ss)
        {
            CallIdentifierMutator callIdentifierMutator
               = new CallIdentifierMutator(parseFunctions_ss);
            return callIdentifierMutator;

            // TODO: Edit factory method of CallIdentifierMutator
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
