using Components.Aphid.Parser;
// <copyright file="BreakExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.BreakExpression instances</summary>
    public static partial class BreakExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.BreakExpression instances</summary>
        [PexFactoryMethod(typeof(BreakExpression))]
        public static BreakExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            int value_i,
            int value_i1
        )
        {
            BreakExpression breakExpression
               = new BreakExpression(context_aphidExpressionContext);
            ((AphidExpression)breakExpression).Index = value_i;
            ((AphidExpression)breakExpression).Length = value_i1;
            return breakExpression;

            // TODO: Edit factory method of BreakExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
