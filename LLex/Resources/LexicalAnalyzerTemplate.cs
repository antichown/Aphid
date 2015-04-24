//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by llex.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 0162
using System;
using System.Collections.Generic;

namespace {LexerNamespace}
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("llex", "1")]
    public enum {TokenType} : short
    {
        {Enums}
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("llex", "1")]
    public struct {Token}
    {
        public {TokenType} TokenType;
        public string Lexeme;
        public int Index;

        public {Token}({TokenType} tokenType, string lexeme, int index)
        {
            TokenType = tokenType;
            Lexeme = lexeme;
            Index = index;
        }
        
        public override string ToString()
        {
            return string.Format("[{0}] {1}: {2}", Index, TokenType, Lexeme);
        }

        public bool IsKeyword()
        {
            return {IsKeyword};
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("llex", "1")]
    public partial class {Lexer}
    {
        private string text = "";

        public string Text
        {
            get { return text; }
            set 
            { 
                text = value;
                lastIndex = text.Length - 1;
            }
        }

        int lastIndex = -1;

        int charIndex = -1;

        int mode = 0;

        int state = 0;

        char currentChar = (char)0;

        public {Lexer}()
        {
        }

        public {Lexer}(string text)
        {
            Text = text;
        }

        bool NextChar()
        {
            if (charIndex < lastIndex)
            {
                currentChar = text[++charIndex];
                return true;
            }

            return false;
        }

        private {TokenType} GetToken()
        {
            {Root}

            return {TokenType}.EndOfFile;
        }

        public List<{Token}> GetTokens()
        {
            charIndex = -1;

            {TokenType} tokenType;

            int lastIndex = -1;

            var tokens = new List<{Token}>();

            while ((tokenType = GetToken()) != {TokenType}.EndOfFile)
            {
                {Body}

                lastIndex = charIndex;                
            }

            return tokens;
        }

        public List<{Token}> GetAllTokens()
        {
            charIndex = -1;

            {TokenType} tokenType;

            int lastIndex = -1;

            var tokens = new List<{Token}>();

            while ((tokenType = GetToken()) != {TokenType}.EndOfFile)
            {
                {AllBody}

                lastIndex = charIndex;                
            }

            return tokens;
        }
    }
}
#pragma warning restore 0162