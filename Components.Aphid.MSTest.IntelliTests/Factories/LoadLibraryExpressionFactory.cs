using Components.Aphid.Parser;
// <copyright file="LoadLibraryExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.LoadLibraryExpression instances</summary>
    public static partial class LoadLibraryExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.LoadLibraryExpression instances</summary>
        [PexFactoryMethod(typeof(LoadLibraryExpression))]
        public static LoadLibraryExpression Create(
            AphidExpressionContext context_aphidExpressionContext,
            AphidExpression libraryExpression_aphidExpression,
            int value_i,
            int value_i1
        )
        {
            LoadLibraryExpression loadLibraryExpression = new LoadLibraryExpression
                                                              (context_aphidExpressionContext, libraryExpression_aphidExpression);
            ((AphidExpression)loadLibraryExpression).Index = value_i;
            ((AphidExpression)loadLibraryExpression).Length = value_i1;
            return loadLibraryExpression;

            // TODO: Edit factory method of LoadLibraryExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
