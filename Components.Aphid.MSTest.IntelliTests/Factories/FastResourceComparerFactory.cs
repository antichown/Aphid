// <copyright file="FastResourceComparerFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace System.Resources
{
    /// <summary>A factory for System.Resources.FastResourceComparer instances</summary>
    public static partial class FastResourceComparerFactory
    {
        /// <summary>A factory for System.Resources.FastResourceComparer instances</summary>
        [PexFactoryMethod(typeof(GC), "System.Resources.FastResourceComparer")]
        public static object Create()
        {
            throw new NotImplementedException();

            // TODO: Edit factory method of FastResourceComparer
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
