using Components.Aphid.Parser;
// <copyright file="GatorCloseExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.GatorCloseExpression instances</summary>
    public static partial class GatorCloseExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.GatorCloseExpression instances</summary>
        [PexFactoryMethod(typeof(GatorCloseExpression))]
        public static GatorCloseExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            int value_i,
            int value_i1
        )
        {
            GatorCloseExpression gatorCloseExpression
               = new GatorCloseExpression(context_aphidExpressionContext);
            ((AphidExpression)gatorCloseExpression).Index = value_i;
            ((AphidExpression)gatorCloseExpression).Length = value_i1;
            return gatorCloseExpression;

            // TODO: Edit factory method of GatorCloseExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
