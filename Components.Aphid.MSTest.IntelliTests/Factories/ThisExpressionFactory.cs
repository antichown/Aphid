using Components.Aphid.Parser;
// <copyright file="ThisExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ThisExpression instances</summary>
    public static partial class ThisExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ThisExpression instances</summary>
        [PexFactoryMethod(typeof(ThisExpression))]
        public static ThisExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            int value_i,
            int value_i1
        )
        {
            ThisExpression thisExpression
               = new ThisExpression(context_aphidExpressionContext);
            ((AphidExpression)thisExpression).Index = value_i;
            ((AphidExpression)thisExpression).Length = value_i1;
            return thisExpression;

            // TODO: Edit factory method of ThisExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
