using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="DoWhileExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.DoWhileExpression instances</summary>
    public static partial class DoWhileExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.DoWhileExpression instances</summary>
        [PexFactoryMethod(typeof(DoWhileExpression))]
        public static DoWhileExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression condition_aphidExpression,
            List<AphidExpression> body_list,
            int value_i,
            int value_i1
        )
        {
            DoWhileExpression doWhileExpression = new DoWhileExpression
                                                      (context_aphidExpressionContext, condition_aphidExpression, body_list);
            ((AphidExpression)doWhileExpression).Index = value_i;
            ((AphidExpression)doWhileExpression).Length = value_i1;
            return doWhileExpression;

            // TODO: Edit factory method of DoWhileExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
