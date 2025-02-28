using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="LockExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.LockExpression instances</summary>
    public static partial class LockExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.LockExpression instances</summary>
        [PexFactoryMethod(typeof(LockExpression))]
        public static LockExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            List<AphidExpression> expressions_list,
            List<AphidExpression> body_list1,
            int value_i,
            int value_i1
        )
        {
            LockExpression lockExpression = new LockExpression
                                                (context_aphidExpressionContext, expressions_list, body_list1);
            ((AphidExpression)lockExpression).Index = value_i;
            ((AphidExpression)lockExpression).Length = value_i1;
            return lockExpression;

            // TODO: Edit factory method of LockExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
