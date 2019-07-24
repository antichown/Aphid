using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="BinaryOperatorExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.BinaryOperatorExpression instances</summary>
    public static partial class BinaryOperatorExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.BinaryOperatorExpression instances</summary>
        [PexFactoryMethod(typeof(BinaryOperatorExpression))]
        public static BinaryOperatorExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression leftOperand_aphidExpression,
            AphidTokenType operator_w,
            AphidExpression rightOperand_aphidExpression1,
            int value_i,
            int value_i1
        )
        {
            BinaryOperatorExpression binaryOperatorExpression = new BinaryOperatorExpression
                                                                    (context_aphidExpressionContext, leftOperand_aphidExpression,
                                                                     operator_w, rightOperand_aphidExpression1);
            ((AphidExpression)binaryOperatorExpression).Index = value_i;
            ((AphidExpression)binaryOperatorExpression).Length = value_i1;
            return binaryOperatorExpression;

            // TODO: Edit factory method of BinaryOperatorExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
