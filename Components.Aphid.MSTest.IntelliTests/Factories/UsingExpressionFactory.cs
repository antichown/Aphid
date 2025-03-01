using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="UsingExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.UsingExpression instances</summary>
    public static partial class UsingExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.UsingExpression instances</summary>
        [PexFactoryMethod(typeof(UsingExpression))]
        public static UsingExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression disposable_aphidExpression,
            List<AphidExpression> body_list,
            int value_i,
            int value_i1
        )
        {
            UsingExpression usingExpression = new UsingExpression
                                                  (context_aphidExpressionContext, disposable_aphidExpression, body_list);
            ((AphidExpression)usingExpression).Index = value_i;
            ((AphidExpression)usingExpression).Length = value_i1;
            return usingExpression;

            // TODO: Edit factory method of UsingExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
