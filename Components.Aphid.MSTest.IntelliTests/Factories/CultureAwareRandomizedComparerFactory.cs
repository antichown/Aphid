using System;
using Microsoft.Pex.Framework;

namespace System
{
    /// <summary>A factory for System.CultureAwareRandomizedComparer instances</summary>
    public static partial class CultureAwareRandomizedComparerFactory
    {
        /// <summary>A factory for System.CultureAwareRandomizedComparer instances</summary>
        [PexFactoryMethod(typeof(GC), "System.CultureAwareRandomizedComparer")]
        public static object Create()
        {
            return StringComparer.CurrentCulture;

            // TODO: Edit factory method of CultureAwareRandomizedComparer
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
