using Components.Aphid.Parser;
// <copyright file="PartialFunctionExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.PartialFunctionExpression instances</summary>
    public static partial class PartialFunctionExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.PartialFunctionExpression instances</summary>
        [PexFactoryMethod(typeof(PartialFunctionExpression))]
        public static PartialFunctionExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            CallExpression call_callExpression,
            int value_i,
            int value_i1
        )
        {
            PartialFunctionExpression partialFunctionExpression
               = new PartialFunctionExpression
                     (context_aphidExpressionContext, call_callExpression);
            ((AphidExpression)partialFunctionExpression).Index = value_i;
            ((AphidExpression)partialFunctionExpression).Length = value_i1;
            return partialFunctionExpression;

            // TODO: Edit factory method of PartialFunctionExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
