using Components.Aphid.Parser;
// <copyright file="LoadScriptExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.LoadScriptExpression instances</summary>
    public static partial class LoadScriptExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.LoadScriptExpression instances</summary>
        [PexFactoryMethod(typeof(LoadScriptExpression))]
        public static LoadScriptExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression fileExpression_aphidExpression,
            int value_i,
            int value_i1
        )
        {
            LoadScriptExpression loadScriptExpression = new LoadScriptExpression
                                                            (context_aphidExpressionContext, fileExpression_aphidExpression);
            ((AphidExpression)loadScriptExpression).Index = value_i;
            ((AphidExpression)loadScriptExpression).Length = value_i1;
            return loadScriptExpression;

            // TODO: Edit factory method of LoadScriptExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
