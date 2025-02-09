using Components.Aphid.Lexer;
using System;
using Microsoft.Pex.Framework;

namespace Components.Aphid.Lexer
{
    /// <summary>A factory for Components.Aphid.Lexer.AphidLexer instances</summary>
    public static partial class AphidLexerFactory
    {
        /// <summary>A factory for Components.Aphid.Lexer.AphidLexer instances</summary>
        [PexFactoryMethod(typeof(AphidLexer))]
        public static AphidLexer Create(string text_s) => new AphidLexer(text_s);
    }
}
