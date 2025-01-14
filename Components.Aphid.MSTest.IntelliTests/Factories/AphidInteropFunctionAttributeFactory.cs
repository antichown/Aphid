using Components.Aphid.TypeSystem;
// <copyright file="AphidInteropFunctionAttributeFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.TypeSystem
{
    /// <summary>A factory for Components.Aphid.TypeSystem.AphidInteropFunctionAttribute instances</summary>
    public static partial class AphidInteropFunctionAttributeFactory
    {
        /// <summary>A factory for Components.Aphid.TypeSystem.AphidInteropFunctionAttribute instances</summary>
        [PexFactoryMethod(typeof(AphidInteropFunctionAttribute))]
        public static AphidInteropFunctionAttribute Create(string name_s, bool value_b)
        {
            AphidInteropFunctionAttribute aphidInteropFunctionAttribute
               = new AphidInteropFunctionAttribute(name_s);
            aphidInteropFunctionAttribute.PassInterpreter = value_b;
            return aphidInteropFunctionAttribute;

            // TODO: Edit factory method of AphidInteropFunctionAttribute
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
