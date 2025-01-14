using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Components.Aphid.Library;

namespace Components.Aphid.TypeSystem
{
    /// <summary>A factory for Components.Aphid.TypeSystem.AphidObject instances</summary>
    [PexClass]
    public static partial class AphidObjectFactory
    {
        /// <summary>A factory for Components.Aphid.TypeSystem.AphidObject instances</summary>
        [PexFactoryMethod(typeof(AphidObject))]
        public static object Create(int seed)
        {
            var t = seed % 5;

            return t == 0 ? AphidObject.Scalar("test") :
                t == 1 ? AphidObject.Complex() :
                t == 2 ? AphidObject.ConvertFrom(new ExecOptions
                {
                    RedirectOutput = true,
                    WaitForExit = false,
                    Working = @"c:\temp",
                }) :
                t == 3 ? AphidObject.Scope() :
                t == 4 ? AphidObject.Scope(AphidObject.Scope()) :
                null;

            // TODO: Edit factory method of AphidObject
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
        /// <summary>A factory for Components.Aphid.TypeSystem.AphidObject instances</summary>
        [PexFactoryMethod(typeof(AphidObject))]
        public static object Create() => AphidObject.ConvertFrom(new ExecOptions
        {
            RedirectOutput = true,
            WaitForExit = false,
            Working = @"c:\temp",
        });// TODO: Edit factory method of AphidObject// This method should be able to configure the object in all possible ways.// Add as many parameters as needed,// and assign their values to each field by using the API.
    }
}
