using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="ArrayAccessExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ArrayAccessExpression instances</summary>
    public static partial class ArrayAccessExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ArrayAccessExpression instances</summary>
        [PexFactoryMethod(typeof(ArrayAccessExpression))]
        public static ArrayAccessExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression arrayExpression_aphidExpression,
            List<AphidExpression> keyExpressions_list,
            int value_i,
            int value_i1
        )
        {
            ArrayAccessExpression arrayAccessExpression
               = new ArrayAccessExpression(context_aphidExpressionContext,
                                           arrayExpression_aphidExpression, keyExpressions_list);
            ((AphidExpression)arrayAccessExpression).Index = value_i;
            ((AphidExpression)arrayAccessExpression).Length = value_i1;
            return arrayAccessExpression;

            // TODO: Edit factory method of ArrayAccessExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
