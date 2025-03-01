using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="TryExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.TryExpression instances</summary>
    public static partial class TryExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.TryExpression instances</summary>
        [PexFactoryMethod(typeof(TryExpression))]
        public static TryExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            List<AphidExpression> tryBody_list,
            IdentifierExpression catchArg_identifierExpression,
            List<AphidExpression> catchBody_list1,
            List<AphidExpression> finallyBody_list2,
            int value_i,
            int value_i1
        )
        {
            TryExpression tryExpression
               = new TryExpression(context_aphidExpressionContext, tryBody_list,
                                   catchArg_identifierExpression, catchBody_list1, finallyBody_list2);
            ((AphidExpression)tryExpression).Index = value_i;
            ((AphidExpression)tryExpression).Length = value_i1;
            return tryExpression;

            // TODO: Edit factory method of TryExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
