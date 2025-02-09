using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="ForExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ForExpression instances</summary>
    public static partial class ForExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ForExpression instances</summary>
        [PexFactoryMethod(typeof(ForExpression))]
        public static ForExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression initialization_aphidExpression,
            AphidExpression condition_aphidExpression1,
            AphidExpression afterthought_aphidExpression2,
            List<AphidExpression> body_list,
            int value_i,
            int value_i1
        )
        {
            ForExpression forExpression = new ForExpression
                                              (context_aphidExpressionContext, initialization_aphidExpression,
                                               condition_aphidExpression1, afterthought_aphidExpression2, body_list);
            ((AphidExpression)forExpression).Index = value_i;
            ((AphidExpression)forExpression).Length = value_i1;
            return forExpression;

            // TODO: Edit factory method of ForExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
