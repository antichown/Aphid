﻿using System;

namespace LLex
{
    public class CharExpression : RegexExpression
    {
        public char Char { get; }

        public CharExpression(char c) => Char = c;

        public override string ToString() =>
            System.Text.RegularExpressions.Regex.Escape(Char.ToString()) + base.ToString();
    }
}
