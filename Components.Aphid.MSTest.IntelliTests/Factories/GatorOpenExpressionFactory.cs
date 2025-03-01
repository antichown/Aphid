using Components.Aphid.Parser;
// <copyright file="GatorOpenExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.GatorOpenExpression instances</summary>
    public static partial class GatorOpenExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.GatorOpenExpression instances</summary>
        [PexFactoryMethod(typeof(GatorOpenExpression))]
        public static GatorOpenExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            int value_i,
            int value_i1
        )
        {
            GatorOpenExpression gatorOpenExpression
               = new GatorOpenExpression(context_aphidExpressionContext);
            ((AphidExpression)gatorOpenExpression).Index = value_i;
            ((AphidExpression)gatorOpenExpression).Length = value_i1;
            return gatorOpenExpression;

            // TODO: Edit factory method of GatorOpenExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
