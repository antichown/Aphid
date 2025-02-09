using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="ForEachExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ForEachExpression instances</summary>
    public static partial class ForEachExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ForEachExpression instances</summary>
        [PexFactoryMethod(typeof(ForEachExpression))]
        public static ForEachExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression collection_aphidExpression,
            List<AphidExpression> body_list,
            AphidExpression element_aphidExpression1,
            int value_i,
            int value_i1
        )
        {
            ForEachExpression forEachExpression = new ForEachExpression
                                                      (context_aphidExpressionContext, collection_aphidExpression,
                                                       body_list, element_aphidExpression1);
            ((AphidExpression)forEachExpression).Index = value_i;
            ((AphidExpression)forEachExpression).Length = value_i1;
            return forEachExpression;

            // TODO: Edit factory method of ForEachExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
