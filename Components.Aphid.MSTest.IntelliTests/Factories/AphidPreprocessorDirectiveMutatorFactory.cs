using Components.Aphid.Parser;
// <copyright file="AphidPreprocessorDirectiveMutatorFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A fa
    /// ctory for Components.Aphid.Parser.AphidPreprocessorDirectiveMutator instances</summary>
    public static partial class AphidPreprocessorDirectiveMutatorFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.AphidPreprocessorDirectiveMutator instances</summary>
        [PexFactoryMethod(typeof(AphidPreprocessorDirectiveMutator))]
        public static AphidPreprocessorDirectiveMutator Create()
        {
            AphidPreprocessorDirectiveMutator aphidPreprocessorDirectiveMutator
               = new AphidPreprocessorDirectiveMutator();
            return aphidPreprocessorDirectiveMutator;

            // TODO: Edit factory method of AphidPreprocessorDirectiveMutator
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
