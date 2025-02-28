using System.Linq;

using Components.Aphid.Lexer;
using Components.Aphid.Parser;
// <copyright file="BinaryOperatorExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;
using System.Collections.ObjectModel;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.BinaryOperatorExpression instances</summary>
    public static partial class BinaryOperatorExpressionFactory
    {
        public static ReadOnlyCollection<BinaryOperatorExpression> Expressions { get; } = new ReadOnlyCollection<BinaryOperatorExpression>(AphidExpressionFactory.Block.Where(x => typeof(BinaryOperatorExpression).IsAssignableFrom(x.GetType())).Cast<BinaryOperatorExpression>().ToArray());
        /// <summary>A factory for Components.Aphid.Parser.BinaryOperatorExpression instances</summary>
        [PexFactoryMethod(typeof(BinaryOperatorExpression))]
        public static BinaryOperatorExpression Create(int seed) => Expressions[seed % Expressions.Count];
    }
}
