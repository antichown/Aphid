using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="CallExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.CallExpression instances</summary>
    public static partial class CallExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.CallExpression instances</summary>
        [PexFactoryMethod(typeof(CallExpression))]
        public static CallExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression functionExpression_aphidExpression,
            List<AphidExpression> args_list,
            int value_i,
            int value_i1
        )
        {
            CallExpression callExpression
               = new CallExpression(context_aphidExpressionContext,
                                    functionExpression_aphidExpression, args_list);
            ((AphidExpression)callExpression).Index = value_i;
            ((AphidExpression)callExpression).Length = value_i1;
            return callExpression;

            // TODO: Edit factory method of CallExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
