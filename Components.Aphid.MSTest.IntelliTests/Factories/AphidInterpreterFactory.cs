using System.Collections.Generic;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.Interpreter;
// <copyright file="AphidInterpreterFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Interpreter
{
    /// <summary>A factory for Components.Aphid.Interpreter.AphidInterpreter instances</summary>
    public static partial class AphidInterpreterFactory
    {
        [PexFactoryMethod(typeof(AphidInterpreter))]
        public static AphidInterpreter Create() => new AphidInterpreter();

        /// <summary>A factory for Components.Aphid.Interpreter.AphidInterpreter instances</summary>
        [PexFactoryMethod(typeof(AphidInterpreter))]
        public static AphidInterpreter Create(bool createLoader
            
        )
        {
            var aphidInterpreter = new AphidInterpreter(createLoader);
            return aphidInterpreter;

            // TODO: Edit factory method of AphidInterpreter
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
