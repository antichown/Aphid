using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="UnaryOperatorExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.UnaryOperatorExpression instances</summary>
    public static partial class UnaryOperatorExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.UnaryOperatorExpression instances</summary>
        [PexFactoryMethod(typeof(UnaryOperatorExpression))]
        public static UnaryOperatorExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidTokenType operator_w,
            AphidExpression operand_aphidExpression,
            bool isPostfix_b,
            int value_i,
            int value_i1
        )
        {
            UnaryOperatorExpression unaryOperatorExpression
               = new UnaryOperatorExpression(context_aphidExpressionContext, operator_w,
                                             operand_aphidExpression, isPostfix_b);
            ((AphidExpression)unaryOperatorExpression).Index = value_i;
            ((AphidExpression)unaryOperatorExpression).Length = value_i1;
            return unaryOperatorExpression;

            // TODO: Edit factory method of UnaryOperatorExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
