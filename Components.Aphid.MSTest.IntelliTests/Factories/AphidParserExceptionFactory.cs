using System.Runtime.Serialization;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using Microsoft.Pex.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.AphidParserException instances</summary>
    public static partial class AphidParserExceptionFactory
    {
        private static List<AphidToken>[] _strings = Components.Aphid.MSTest.IntelliTests.Factories.StringFactory.Strings
            .Select(x => new AphidLexer(new string(x.Take(10).ToArray())).GetTokens())
            .ToArray();        

        /// <summary>A factory for Components.Aphid.Parser.AphidParserException instances</summary>
        [PexFactoryMethod(typeof(AphidParserException))]
        public static AphidParserException Create(int seed)
        {
            try
            {
                new AphidParser(_strings[seed % _strings.Length]).Parse();
            }
            catch (AphidParserException e)
            {
                return e;
            }

            return null;
        }
    }
}
