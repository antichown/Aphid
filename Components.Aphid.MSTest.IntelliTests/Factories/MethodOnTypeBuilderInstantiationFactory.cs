// <copyright file="MethodOnTypeBuilderInstantiationFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace System.Reflection.Emit
{
    /// <summary>A factory for System.Reflection.Emit.MethodOnTypeBuilderInstantiation instances</summary>
    public static partial class MethodOnTypeBuilderInstantiationFactory
    {
        /// <summary>A factory for System.Reflection.Emit.MethodOnTypeBuilderInstantiation instances</summary>
        [PexFactoryMethod(typeof(GC), "System.Reflection.Emit.MethodOnTypeBuilderInstantiation")]
        public static object Create()
        {
            throw new NotImplementedException();

            // TODO: Edit factory method of MethodOnTypeBuilderInstantiation
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
