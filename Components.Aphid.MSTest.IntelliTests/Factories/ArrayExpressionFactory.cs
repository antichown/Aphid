using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="ArrayExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ArrayExpression instances</summary>
    public static partial class ArrayExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ArrayExpression instances</summary>
        [PexFactoryMethod(typeof(ArrayExpression))]
        public static ArrayExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            List<AphidExpression> elements_list,
            int value_i,
            int value_i1
        )
        {
            ArrayExpression arrayExpression
               = new ArrayExpression(context_aphidExpressionContext, elements_list);
            ((AphidExpression)arrayExpression).Index = value_i;
            ((AphidExpression)arrayExpression).Length = value_i1;
            return arrayExpression;

            // TODO: Edit factory method of ArrayExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
