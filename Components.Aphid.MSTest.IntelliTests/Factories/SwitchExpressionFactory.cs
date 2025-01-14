using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="SwitchExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.SwitchExpression instances</summary>
    public static partial class SwitchExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.SwitchExpression instances</summary>
        [PexFactoryMethod(typeof(SwitchExpression))]
        public static SwitchExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression expression_aphidExpression,
            List<SwitchCase> cases_list,
            List<AphidExpression> defaultCase_list1_,
            int value_i,
            int value_i1
        )
        {
            SwitchExpression switchExpression = new SwitchExpression
                                                    (context_aphidExpressionContext, expression_aphidExpression,
                                                     cases_list, defaultCase_list1_);
            ((AphidExpression)switchExpression).Index = value_i;
            ((AphidExpression)switchExpression).Length = value_i1;
            return switchExpression;

            // TODO: Edit factory method of SwitchExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
