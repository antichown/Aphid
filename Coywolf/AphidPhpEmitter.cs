﻿using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Coywolf.Visitors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Coywolf
{
    public class AphidPhpEmitter : AphidStringEmitter
    {
        private AphidExpression _lastStatement;

        private readonly string[] _builtInFunctions = File.ReadAllLines(@"C:\source\Aphid\Coywolf\phpFunctions.txt");

        private Dictionary<AphidTokenType, string> _unaryPrefixOperators = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.retKeyword, "return " },
        };

        private int _varNumber = 0;

        private bool _isPhp = false;

        private const string _header = @"<?php
if (!function_exists('__add')) {
    function __add($lhs, $rhs) {
	    return gettype($lhs) == 'string' || gettype($rhs) == 'string' ?
		    $lhs . $rhs :
		    $lhs + $rhs;
    }
}
?>";

        private bool IsBuildInFunction(string id)
        {
            return _builtInFunctions.Contains(id);
        }

        public override string Compile(List<AphidExpression> ast)
        {
            var mutators = new AphidMutator[] 
            {
                new IncludeMutator(),
                new AphidMacroMutator(),
                new PipelineToCallMutator(),
            };

            foreach (var mutator in mutators)
            {
                ast = mutator.MutateRecursively(ast);
            }

            return base.Compile(ast);
        }

        protected override void EmitHeader()
        {
            Append(_header.Replace("{", "{{").Replace("}", "}}"));

            base.EmitHeader();
        }

        protected override void BeginStatement(AphidExpression expression)
        {
            if (expression.Type != AphidExpressionType.GatorEmitExpression &&
                expression.Type != AphidExpressionType.GatorOpenExpression &&
                expression.Type != AphidExpressionType.GatorCloseExpression &&
                expression.Type != AphidExpressionType.TextExpression)
            {
                Append(GetTabs());
            }
            
            base.BeginStatement(expression);
        }

        protected override void BeginExpression(AphidExpression expression)
        {
            if (_isPhp && expression.Type == AphidExpressionType.TextExpression)
            {
                //Append("?>");
                _isPhp = false;
            }
            else if (expression.Type == AphidExpressionType.GatorEmitExpression)
            {
                if (_isPhp)
                {
                    //Append("?>");
                }
                else
                {
                    _isPhp = true;
                }
            }
            else if (!_isPhp &&
                expression.Type != AphidExpressionType.TextExpression &&
                expression.Type != AphidExpressionType.GatorEmitExpression)
            {
                //Append("<?php\r\n");
                _isPhp = true;
            }

            base.BeginExpression(expression);
        }

        protected override void EndExpression(AphidExpression expression)
        {
            if (expression.Type == AphidExpressionType.GatorEmitExpression)
            {
                _isPhp = false;
            }

            base.EndExpression(expression);
        }

        public override void Emit(List<AphidExpression> statements)
        {
            base.Emit(statements);

            if (!_isPhp)
            {
                _isPhp = true;
                //Append("<?php ");
            }
        }

        protected override void Emit(AphidExpression expression, bool isStatement = false)
        {
            base.Emit(expression, isStatement);

            if (isStatement &&
                expression.Type != AphidExpressionType.TextExpression &&
                expression.Type != AphidExpressionType.GatorOpenExpression &&
                expression.Type != AphidExpressionType.GatorCloseExpression &&
                expression.Type != AphidExpressionType.GatorEmitExpression &&
                expression.Type != AphidExpressionType.IfExpression &&
                expression.Type != AphidExpressionType.WhileExpression &&
                expression.Type != AphidExpressionType.ForEachExpression)
            {
                Append(";\r\n");
            }
        }

        protected override void EmitGatorOpenExpression(GatorOpenExpression expression, bool isStatement = false)
        {
            Append("<?php\r\n");
        }

        protected override void EmitGatorCloseExpression(GatorCloseExpression expression, bool isStatement = false)
        {
            Append("?>");
        }

        protected override void EmitTextExpression(TextExpression expression, bool isStatement = false)
        {
            Append(expression.Text);
        }

        protected override void EmitGatorEmitExpression(GatorEmitExpression expression, bool isStatement = false)
        {
            Append("<?= ");
            Append("htmlentities(");
            Emit(expression.Expression, isStatement: false);
            Append(", ENT_QUOTES)");
            Append(" ?>");
        }

        protected override void EmitIdentifierExpression(IdentifierExpression expression, bool isStatement = false)
        {
            //if (expression.Attributes.Any())
            //{
            //    throw new NotImplementedException();
            //}

            foreach (var attr in expression.Attributes)
            {
                Append("{0} ", attr.Identifier);
            }

            Append(
                "{0}{1}",
                !IsBuildInFunction(expression.Identifier) ? "$" : "",
                expression.Identifier);
        }

        protected override void EmitUnaryOperatorExpression(UnaryOperatorExpression expression, bool isStatement = false)
        {
            string value;

            if (!_unaryPrefixOperators.TryGetValue(expression.Operator, out value))
            {
                base.EmitUnaryOperatorExpression(expression, isStatement);
            }
            else
            {
                Append(value);
                Emit(expression.Operand);
            }
        }

        protected override void EmitBinaryOperatorExpression(BinaryOperatorExpression expression, bool isStatement = false)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.AdditionOperator:
                    Append("__add(");
                    Emit(expression.LeftOperand);
                    Append(", ");
                    Emit(expression.RightOperand);
                    Append(")");
                    break;

                case AphidTokenType.MemberOperator:
                    Emit(expression.LeftOperand);
                    Append("->");
                    if (expression.RightOperand.Type == AphidExpressionType.IdentifierExpression)
                    {
                        Append(expression.RightOperand.ToIdentifier().Identifier);
                    }
                    else
                    {
                        Emit(expression.RightOperand);
                    }
                    break;

                default:
                    base.EmitBinaryOperatorExpression(expression, isStatement);
                    break;
            }
        }

        protected override void EmitTernaryOperatorExpression(TernaryOperatorExpression expression, bool isStatement = false)
        {
            Append("((");            
            Emit(expression.FirstOperand);
            Append(")");
            Append(" ? ");
            Append("(");
            Emit(expression.SecondOperand);
            Append(") : (");
            Emit(expression.ThirdOperand);
            Append("))");
        }

        protected override void EmitStringExpression(StringExpression expression, bool isStatement = false)
        {
            var escaped = StringParser
                .Parse(expression.Value)
                .Replace("\\", "\\\\")
                .Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\"", "\\\"")
                .Replace("$", "\\$");

            Append("\"{0}\"", escaped);
        }

        protected override void EmitFunctionExpression(FunctionExpression expression, bool isStatement = false)
        {
            Append("function (");
            EmitTuple(expression.Args);
            Append(") ");
            EmitUsed(expression.Args, expression.Body);
            Append("{\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append(GetTabs() + "}");
        }

        protected override void EmitPartialFunctionExpression(PartialFunctionExpression expression, bool isStatement = false)
        {
            var arg = NextId();
            Append("(function(${0}) ", arg);

            EmitUsed(
                new List<AphidExpression>(),
                expression.GetChildren().ToList());

            Append("{ return ");

            var callArgs = expression.Call.Args
                .Concat(new[] { new IdentifierExpression(arg) })
                .ToList();

            Emit(new CallExpression(
                expression.Call.FunctionExpression,
                callArgs.ToList()));

            Append("; })");
        }

        protected void EmitUsed(List<AphidExpression> args, List<AphidExpression> body)
        {
            var argIds = args
                .Select(x => x.ToIdentifier())
                .ToArray();

            var parentVariables = Scope
                .SelectMany(x => x)
                .Select(DeclarationHelper.GetDeclaredIdentifier)
                .Where(x => x != null && !argIds.Any(y => x.Identifier == y.Identifier))
                .Distinct()
                .ToArray();

            var locals = new LocalFinder()
                .Find(body)
                .Where(x => !parentVariables.Any(y => x.Identifier == y.Identifier))
                .ToArray();

            var used = new PhpUseIdFinder()
                .Find(body)
                .Cast<IdentifierExpression>()
                .Select(x => x.Identifier)
                .Distinct()
                .Where(x =>
                    !argIds
                        .Concat(locals)
                        .Any(y => y.Identifier == x) &&
                    !IsBuildInFunction(x))
                .Select(x => new IdentifierExpression(x))
                .ToArray();

            if (used.Any())
            {
                Append("use (");
                EmitTuple(used, prefix: "&");
                Append(") ");
            }
        }

        protected override void EmitCallExpression(CallExpression expression, bool isStatement = false)
        {
            switch (expression.FunctionExpression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    switch (expression.FunctionExpression.ToIdentifier().Identifier)
                    {
                        case "echo":
                            EmitEchoStatement(expression);
                            return;
                    }

                    break;

                case AphidExpressionType.FunctionExpression:
                case AphidExpressionType.PartialFunctionExpression:
                    Append("call_user_func(\r\n");
                    Indent();
                    AppendTabs();
                    Emit(expression.FunctionExpression);
                    if (expression.Args.Any())
                    {
                        Append(",\r\n{0}", GetTabs());
                        EmitTuple(expression.Args);
                    }
                    Unindent();
                    Append(")");
                    return;
            }

            base.EmitCallExpression(expression, isStatement);
        }

        protected override void EmitForEachExpression(ForEachExpression expression, bool isStatement = false)
        {
            Append("foreach (");
            Emit(expression.Collection);
            Append(" as ");
            Emit(expression.Element);
            Append("){\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append(GetTabs() + "}\r\n");
        }

        protected override void EmitIfExpression(IfExpression expression, bool isStatement = false)
        {
            Append("if (");
            Emit(expression.Condition);
            Append(") {\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append(GetTabs() + "}");

            if (expression.ElseBody != null)
            {
                Append(" else {\r\n");
                Indent();
                Emit(expression.ElseBody);
                Unindent();
                Append(GetTabs() + "}");
            }

            Append("\r\n");
        }

        protected override void EmitWhileExpression(WhileExpression expression, bool isStatement = false)
        {
            Append("while (");
            Emit(expression.Condition);
            Append(") {\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append("{0}}}\r\n", GetTabs());
        }

        protected override void EmitObjectExpression(ObjectExpression expression, bool isStatement = false)
        {
            if (expression.Identifier != null)
            {
                if (expression.Identifier.Attributes.Any())
                {
                    throw new NotImplementedException();
                }

                switch (expression.Identifier.Identifier)
                {
                    case "new":
                        Append("(object)");
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
                
            Append("[");
            var isFirst = true;

            foreach (var kvp in expression.Pairs)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    Append(", ");
                }

                var key = kvp.LeftOperand.Type == AphidExpressionType.IdentifierExpression ?
                    new StringExpression(string.Format(
                        "'{0}'",
                        kvp.LeftOperand.ToIdentifier().Identifier)) :
                    (StringExpression)kvp.LeftOperand;

                Emit(key);
                Append(" => ");
                Emit(kvp.RightOperand);
            }

            Append("]");
        }

        protected void EmitEchoStatement(CallExpression expression)
        {
            Append("echo ");
            EmitTuple(expression.Args);
        }

        private string NextId()
        {
            return string.Format("id_{0:X8}", _varNumber++);
        }
    }

}
