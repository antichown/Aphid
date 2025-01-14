using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="TernaryOperatorExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.TernaryOperatorExpression instances</summary>
    public static partial class TernaryOperatorExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.TernaryOperatorExpression instances</summary>
        [PexFactoryMethod(typeof(TernaryOperatorExpression))]
        public static TernaryOperatorExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidTokenType operator_w,
            AphidExpression firstOperand_aphidExpression,
            AphidExpression secondOperand_aphidExpression1,
            AphidExpression thirdOperand_aphidExpression2,
            int value_i,
            int value_i1
        )
        {
            TernaryOperatorExpression ternaryOperatorExpression
               = new TernaryOperatorExpression(context_aphidExpressionContext, operator_w,
                                               firstOperand_aphidExpression,
                                               secondOperand_aphidExpression1, thirdOperand_aphidExpression2);
            ((AphidExpression)ternaryOperatorExpression).Index = value_i;
            ((AphidExpression)ternaryOperatorExpression).Length = value_i1;
            return ternaryOperatorExpression;

            // TODO: Edit factory method of TernaryOperatorExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
