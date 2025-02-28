using Components.Aphid.Parser;
// <copyright file="StringExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.StringExpression instances</summary>
    public static partial class StringExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.StringExpression instances</summary>
        [PexFactoryMethod(typeof(StringExpression))]
        public static StringExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            string value_s,
            int value_i,
            int value_i1
        )
        {
            StringExpression stringExpression
               = new StringExpression(context_aphidExpressionContext, value_s);
            ((AphidExpression)stringExpression).Index = value_i;
            ((AphidExpression)stringExpression).Length = value_i1;
            return stringExpression;

            // TODO: Edit factory method of StringExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
