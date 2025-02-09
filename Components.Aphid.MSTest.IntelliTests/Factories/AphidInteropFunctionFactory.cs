using System.Reflection;
using Components.Aphid.TypeSystem;
// <copyright file="AphidInteropFunctionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.TypeSystem
{
    /// <summary>A factory for Components.Aphid.TypeSystem.AphidInteropFunction instances</summary>
    public static partial class AphidInteropFunctionFactory
    {
        /// <summary>A factory for Components.Aphid.TypeSystem.AphidInteropFunction instances</summary>
        [PexFactoryMethod(typeof(AphidInteropFunction))]
        public static AphidInteropFunction Create(
            AphidInteropFunctionAttribute attribute_aphidInteropFunctionAttribute,
            MethodInfo method_methodInfo
        )
        {
            AphidInteropFunction aphidInteropFunction = new AphidInteropFunction
                                                            (attribute_aphidInteropFunctionAttribute, method_methodInfo);
            return aphidInteropFunction;

            // TODO: Edit factory method of AphidInteropFunction
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
