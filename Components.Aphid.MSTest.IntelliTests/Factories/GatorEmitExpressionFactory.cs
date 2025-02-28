using Components.Aphid.Parser;
// <copyright file="GatorEmitExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.GatorEmitExpression instances</summary>
    public static partial class GatorEmitExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.GatorEmitExpression instances</summary>
        [PexFactoryMethod(typeof(GatorEmitExpression))]
        public static GatorEmitExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression expression_aphidExpression,
            int value_i,
            int value_i1
        )
        {
            GatorEmitExpression gatorEmitExpression = new GatorEmitExpression
                                                          (context_aphidExpressionContext, expression_aphidExpression);
            ((AphidExpression)gatorEmitExpression).Index = value_i;
            ((AphidExpression)gatorEmitExpression).Length = value_i1;
            return gatorEmitExpression;

            // TODO: Edit factory method of GatorEmitExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
