using Components.Aphid.Parser;
// <copyright file="TextExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.TextExpression instances</summary>
    public static partial class TextExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.TextExpression instances</summary>
        [PexFactoryMethod(typeof(TextExpression))]
        public static TextExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            string text_s,
            int value_i,
            int value_i1
        )
        {
            TextExpression textExpression
               = new TextExpression(context_aphidExpressionContext, text_s);
            ((AphidExpression)textExpression).Index = value_i;
            ((AphidExpression)textExpression).Length = value_i1;
            return textExpression;

            // TODO: Edit factory method of TextExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
