using Components.Aphid.Parser;
// <copyright file="ExtendExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ExtendExpression instances</summary>
    public static partial class ExtendExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ExtendExpression instances</summary>
        [PexFactoryMethod(typeof(ExtendExpression))]
        public static ExtendExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            IdentifierExpression extendType_identifierExpression,
            ObjectExpression object_objectExpression,
            int value_i,
            int value_i1
        )
        {
            ExtendExpression extendExpression
               = new ExtendExpression(context_aphidExpressionContext,
                                      extendType_identifierExpression, object_objectExpression);
            ((AphidExpression)extendExpression).Index = value_i;
            ((AphidExpression)extendExpression).Length = value_i1;
            return extendExpression;

            // TODO: Edit factory method of ExtendExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
