﻿using Components.Aphid.Lexer;
using Components.Aphid.TypeSystem;
using System;

namespace Components.Aphid.Parser
{
    [Serializable]
    public class AphidParserException : Exception, IAphidException
    {
        public AphidExceptionType Type => AphidExceptionType.ParserException;

        public AphidToken UnexpectedToken { get; set; }

        public AphidTokenType ExpectedToken { get; set; }

        public AphidExpression Expression { get; set; }

        private readonly string _message;

        public override string Message => _message;

        public string Filename { get; set; }

        public AphidParserException(in AphidToken unexpectedToken)
        {
            UnexpectedToken = unexpectedToken;
            _message = CreateUnexpectedMessage(unexpectedToken) + ".";
        }

        public AphidParserException(in AphidToken unexpectedToken, AphidTokenType expectedToken)
        {
            UnexpectedToken = unexpectedToken;
            ExpectedToken = expectedToken;

            _message = string.Format(
                "{0}; expected {1}.",
                CreateUnexpectedMessage(unexpectedToken),
                expectedToken);
        }

        public AphidParserException(string error, AphidExpression expression)
        {
            Expression = expression;
            _message = string.Format("{0}: {1}", error, expression);
        }

        public AphidParserException(AphidExpression expression)
            : this(string.Format("Invalid {0}", expression.Type), expression)
        {
        }

        public AphidParserException(string format, params object[] args)
        {
            if (args?.Length > 0)
            {
                _message = string.Format(format, args);
            }
            else
            {
                _message = format;
            }
        }

        public AphidParserException() : base()
        {
        }

        public AphidParserException(string message) : base(message)
        {
        }

        public AphidParserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        private static string CreateUnexpectedMessage(in AphidToken token) => string.Format(
                "Unexpected {0} ({1}) at offset {2}",
                token.TokenType,
                token.Lexeme,
                token.Index);
    }
}
