using Mantispid;
// <copyright file="IndexTrackingMutatorFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Mantispid
{
    /// <summary>A factory for Mantispid.IndexTrackingMutator instances</summary>
    public static partial class IndexTrackingMutatorFactory
    {
        /// <summary>A factory for Mantispid.IndexTrackingMutator instances</summary>
        [PexFactoryMethod(typeof(IndexTrackingMutator))]
        public static IndexTrackingMutator Create(string[] nonListRules_ss)
        {
            IndexTrackingMutator indexTrackingMutator
               = new IndexTrackingMutator(nonListRules_ss);
            return indexTrackingMutator;

            // TODO: Edit factory method of IndexTrackingMutator
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
