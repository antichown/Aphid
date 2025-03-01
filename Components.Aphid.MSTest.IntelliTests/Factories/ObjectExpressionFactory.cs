using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="ObjectExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ObjectExpression instances</summary>
    public static partial class ObjectExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ObjectExpression instances</summary>
        [PexFactoryMethod(typeof(ObjectExpression))]
        public static ObjectExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            List<BinaryOperatorExpression> pairs_list,
            IdentifierExpression identifier_identifierExpression,
            int value_i,
            int value_i1
        )
        {
            ObjectExpression objectExpression
               = new ObjectExpression(context_aphidExpressionContext,
                                      pairs_list, identifier_identifierExpression);
            ((AphidExpression)objectExpression).Index = value_i;
            ((AphidExpression)objectExpression).Length = value_i1;
            return objectExpression;

            // TODO: Edit factory method of ObjectExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
