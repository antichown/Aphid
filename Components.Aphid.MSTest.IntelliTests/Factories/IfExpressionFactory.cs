using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="IfExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.IfExpression instances</summary>
    public static partial class IfExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.IfExpression instances</summary>
        [PexFactoryMethod(typeof(IfExpression))]
        public static IfExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression condition_aphidExpression,
            List<AphidExpression> body_list,
            List<AphidExpression> elseBody_list1,
            int value_i,
            int value_i1
        )
        {
            IfExpression ifExpression =
                                       new IfExpression(context_aphidExpressionContext, condition_aphidExpression,
                                                        body_list, elseBody_list1);
            ((AphidExpression)ifExpression).Index = value_i;
            ((AphidExpression)ifExpression).Length = value_i1;
            return ifExpression;

            // TODO: Edit factory method of IfExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
