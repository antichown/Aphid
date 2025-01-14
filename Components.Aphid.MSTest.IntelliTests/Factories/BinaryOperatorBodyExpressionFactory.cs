using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="BinaryOperatorBodyExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.BinaryOperatorBodyExpression instances</summary>
    public static partial class BinaryOperatorBodyExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.BinaryOperatorBodyExpression instances</summary>
        [PexFactoryMethod(typeof(BinaryOperatorBodyExpression))]
        public static BinaryOperatorBodyExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidTokenType operator_w,
            FunctionExpression function_functionExpression,
            int value_i,
            int value_i1
        )
        {
            BinaryOperatorBodyExpression binaryOperatorBodyExpression
               = new BinaryOperatorBodyExpression
                     (context_aphidExpressionContext, operator_w, function_functionExpression);
            ((AphidExpression)binaryOperatorBodyExpression).Index = value_i;
            ((AphidExpression)binaryOperatorBodyExpression).Length = value_i1;
            return binaryOperatorBodyExpression;

            // TODO: Edit factory method of BinaryOperatorBodyExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
