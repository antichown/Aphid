using Components.Aphid.Parser;
// <copyright file="DynamicMemberExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.DynamicMemberExpression instances</summary>
    public static partial class DynamicMemberExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.DynamicMemberExpression instances</summary>
        [PexFactoryMethod(typeof(DynamicMemberExpression))]
        public static DynamicMemberExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression memberExpression_aphidExpression,
            int value_i,
            int value_i1
        )
        {
            DynamicMemberExpression dynamicMemberExpression = new DynamicMemberExpression
                                                                  (context_aphidExpressionContext, memberExpression_aphidExpression);
            ((AphidExpression)dynamicMemberExpression).Index = value_i;
            ((AphidExpression)dynamicMemberExpression).Length = value_i1;
            return dynamicMemberExpression;

            // TODO: Edit factory method of DynamicMemberExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
