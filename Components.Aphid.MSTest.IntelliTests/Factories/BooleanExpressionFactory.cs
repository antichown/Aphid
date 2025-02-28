using Components.Aphid.Parser;
// <copyright file="BooleanExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.BooleanExpression instances</summary>
    public static partial class BooleanExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.BooleanExpression instances</summary>
        [PexFactoryMethod(typeof(BooleanExpression))]
        public static BooleanExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            bool value_b,
            int value_i,
            int value_i1
        )
        {
            BooleanExpression booleanExpression
               = new BooleanExpression(context_aphidExpressionContext, value_b);
            ((AphidExpression)booleanExpression).Index = value_i;
            ((AphidExpression)booleanExpression).Length = value_i1;
            return booleanExpression;

            // TODO: Edit factory method of BooleanExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
