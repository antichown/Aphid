using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="PartialOperatorExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.PartialOperatorExpression instances</summary>
    public static partial class PartialOperatorExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.PartialOperatorExpression instances</summary>
        [PexFactoryMethod(typeof(PartialOperatorExpression))]
        public static PartialOperatorExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidTokenType operator_w,
            AphidExpression operand_aphidExpression,
            int value_i,
            int value_i1
        )
        {
            PartialOperatorExpression partialOperatorExpression
               = new PartialOperatorExpression
                     (context_aphidExpressionContext, operator_w, operand_aphidExpression);
            ((AphidExpression)partialOperatorExpression).Index = value_i;
            ((AphidExpression)partialOperatorExpression).Length = value_i1;
            return partialOperatorExpression;

            // TODO: Edit factory method of PartialOperatorExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
