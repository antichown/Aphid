using System.Reflection;
using Components.Aphid.TypeSystem;
// <copyright file="AphidInteropMethodInfoFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.TypeSystem
{
    /// <summary>A factory for Components.Aphid.TypeSystem.AphidInteropMethodInfo instances</summary>
    public static partial class AphidInteropMethodInfoFactory
    {
        /// <summary>A factory for Components.Aphid.TypeSystem.AphidInteropMethodInfo instances</summary>
        [PexFactoryMethod(typeof(AphidInteropMethodInfo))]
        public static AphidInteropMethodInfo Create(
            MethodBase method_methodBase,
            Type[] genericArguments_types,
            AphidInteropMethodArg[] arguments_aphidInteropMethodArgs
        )
        {
            AphidInteropMethodInfo aphidInteropMethodInfo
               = new AphidInteropMethodInfo(method_methodBase,
                                            genericArguments_types, arguments_aphidInteropMethodArgs);
            return aphidInteropMethodInfo;

            // TODO: Edit factory method of AphidInteropMethodInfo
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
