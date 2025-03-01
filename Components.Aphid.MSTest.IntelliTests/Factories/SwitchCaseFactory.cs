using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="SwitchCaseFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.SwitchCase instances</summary>
    public static partial class SwitchCaseFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.SwitchCase instances</summary>
        [PexFactoryMethod(typeof(SwitchCase))]
        public static SwitchCase Create(
            AphidExpressionContext context_aphidExpressionContext,
            List<AphidExpression> cases_list,
            List<AphidExpression> body_list1,
            int value_i,
            int value_i1
        )
        {
            SwitchCase switchCase
               = new SwitchCase(context_aphidExpressionContext, cases_list, body_list1);
            ((AphidExpression)switchCase).Index = value_i;
            ((AphidExpression)switchCase).Length = value_i1;
            return switchCase;

            // TODO: Edit factory method of SwitchCase
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
