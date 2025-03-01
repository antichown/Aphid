using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="PatternExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.PatternExpression instances</summary>
    public static partial class PatternExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.PatternExpression instances</summary>
        [PexFactoryMethod(typeof(PatternExpression))]
        public static PatternExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression value_aphidExpression,
            List<AphidExpression> patterns_list,
            int value_i,
            int value_i1
        )
        {
            PatternExpression patternExpression = new PatternExpression
                                                      (context_aphidExpressionContext, value_aphidExpression, patterns_list);
            ((AphidExpression)patternExpression).Index = value_i;
            ((AphidExpression)patternExpression).Length = value_i1;
            return patternExpression;

            // TODO: Edit factory method of PatternExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
