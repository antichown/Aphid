using Components.Aphid.Parser;
// <copyright file="NullExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.NullExpression instances</summary>
    public static partial class NullExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.NullExpression instances</summary>
        [PexFactoryMethod(typeof(NullExpression))]
        public static NullExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            int value_i,
            int value_i1
        )
        {
            NullExpression nullExpression
               = new NullExpression(context_aphidExpressionContext);
            ((AphidExpression)nullExpression).Index = value_i;
            ((AphidExpression)nullExpression).Length = value_i1;
            return nullExpression;

            // TODO: Edit factory method of NullExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
