using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="WhileExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.WhileExpression instances</summary>
    public static partial class WhileExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.WhileExpression instances</summary>
        [PexFactoryMethod(typeof(WhileExpression))]
        public static WhileExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression condition_aphidExpression,
            List<AphidExpression> body_list,
            int value_i,
            int value_i1
        )
        {
            WhileExpression whileExpression = new WhileExpression
                                                  (context_aphidExpressionContext, condition_aphidExpression, body_list);
            ((AphidExpression)whileExpression).Index = value_i;
            ((AphidExpression)whileExpression).Length = value_i1;
            return whileExpression;

            // TODO: Edit factory method of WhileExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
