using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="ImplicitArgumentsExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ImplicitArgumentsExpression instances</summary>
    public static partial class ImplicitArgumentsExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ImplicitArgumentsExpression instances</summary>
        [PexFactoryMethod(typeof(ImplicitArgumentsExpression))]
        public static ImplicitArgumentsExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidTokenType operator_w,
            int value_i,
            int value_i1
        )
        {
            ImplicitArgumentsExpression implicitArgumentsExpression
               = new ImplicitArgumentsExpression(context_aphidExpressionContext, operator_w);
            ((AphidExpression)implicitArgumentsExpression).Index = value_i;
            ((AphidExpression)implicitArgumentsExpression).Length = value_i1;
            return implicitArgumentsExpression;

            // TODO: Edit factory method of ImplicitArgumentsExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
