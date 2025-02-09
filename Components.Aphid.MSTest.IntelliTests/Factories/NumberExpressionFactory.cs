using Components.Aphid.Parser;
// <copyright file="NumberExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.NumberExpression instances</summary>
    public static partial class NumberExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.NumberExpression instances</summary>
        [PexFactoryMethod(typeof(NumberExpression))]
        public static NumberExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            decimal value_d,
            int value_i,
            int value_i1
        )
        {
            NumberExpression numberExpression
               = new NumberExpression(context_aphidExpressionContext, value_d);
            ((AphidExpression)numberExpression).Index = value_i;
            ((AphidExpression)numberExpression).Length = value_i1;
            return numberExpression;

            // TODO: Edit factory method of NumberExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
