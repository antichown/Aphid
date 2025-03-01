using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="PatternMatchingExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.PatternMatchingExpression instances</summary>
    public static partial class PatternMatchingExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.PatternMatchingExpression instances</summary>
        [PexFactoryMethod(typeof(PatternMatchingExpression))]
        public static PatternMatchingExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression testExpression_aphidExpression,
            List<PatternExpression> patterns_list,
            int value_i,
            int value_i1
        )
        {
            PatternMatchingExpression patternMatchingExpression
               = new PatternMatchingExpression(context_aphidExpressionContext,
                                               testExpression_aphidExpression, patterns_list);
            ((AphidExpression)patternMatchingExpression).Index = value_i;
            ((AphidExpression)patternMatchingExpression).Length = value_i1;
            return patternMatchingExpression;

            // TODO: Edit factory method of PatternMatchingExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
