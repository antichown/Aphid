using Components.Aphid.Parser;
// <copyright file="ContinueExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ContinueExpression instances</summary>
    public static partial class ContinueExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ContinueExpression instances</summary>
        [PexFactoryMethod(typeof(ContinueExpression))]
        public static ContinueExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            int value_i,
            int value_i1
        )
        {
            ContinueExpression continueExpression
               = new ContinueExpression(context_aphidExpressionContext);
            ((AphidExpression)continueExpression).Index = value_i;
            ((AphidExpression)continueExpression).Length = value_i1;
            return continueExpression;

            // TODO: Edit factory method of ContinueExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
