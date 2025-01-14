using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="FunctionExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.FunctionExpression instances</summary>
    public static partial class FunctionExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.FunctionExpression instances</summary>
        [PexFactoryMethod(typeof(FunctionExpression))]
        public static FunctionExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            List<AphidExpression> args_list,
            List<AphidExpression> body_list1,
            int value_i,
            int value_i1
        )
        {
            FunctionExpression functionExpression = new FunctionExpression
                                                        (context_aphidExpressionContext, args_list, body_list1);
            ((AphidExpression)functionExpression).Index = value_i;
            ((AphidExpression)functionExpression).Length = value_i1;
            return functionExpression;

            // TODO: Edit factory method of FunctionExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
