using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="IdentifierExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.IdentifierExpression instances</summary>
    public static partial class IdentifierExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.IdentifierExpression instances</summary>
        [PexFactoryMethod(typeof(IdentifierExpression))]
        public static IdentifierExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            string identifier_s,
            List<IdentifierExpression> attributes_list,
            int value_i,
            int value_i1
        )
        {
            IdentifierExpression identifierExpression = new IdentifierExpression
                                                            (context_aphidExpressionContext, identifier_s, attributes_list);
            ((AphidExpression)identifierExpression).Index = value_i;
            ((AphidExpression)identifierExpression).Length = value_i1;
            return identifierExpression;

            // TODO: Edit factory method of IdentifierExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
