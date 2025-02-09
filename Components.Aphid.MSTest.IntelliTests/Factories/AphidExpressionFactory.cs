using System.Collections.Generic;
using Components.Aphid.Parser;
// <copyright file="ArrayAccessExpressionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Components.Aphid.Lexer;
using System.Collections.ObjectModel;

namespace Components.Aphid.Parser
{
    /// <summary>A factory for Components.Aphid.Parser.ArrayAccessExpression instances</summary>
    /// 
    public static partial class AphidExpressionFactory
    {
        /// <summary>A factory for Components.Aphid.Parser.ArrayAccessExpression instances</summary>
        //[PexFactoryMethod(typeof(AphidExpression))]
        public static AphidExpression Create(int seed)
        {
            //var flatten = @(b) { var cur = new List[AphidExpression](); b->cur.Add; while (((b = AphidParent.Flatten(b | Enumerable.ToArray))#!) > 0) { b->cur.Add; } ret cur };
            return Block[seed % Block.Count];

            // TODO: Edit factory method of ArrayAccessExpression
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }

        public static ReadOnlyCollection<AphidExpression> Block { get; set; } = new ReadOnlyCollection<AphidExpression>(new AphidParser(new AphidLexer(@"
var getCommand = @() Environment.CommandLine;
var getCommandLineArgs = @() Environment.GetCommandLineArgs();

var fixColors = @{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.Black;
};

var console;
var head = @(msg){ Cli.WriteHeader($_, console.defaultHeaderStyle) };
var header = head;
var subhead = @(msg) { Cli.WriteSubheader(msg, console.defaultSubheaderStyle) };
var subheader = subhead;

_ci = macro(@(a) { if (exists()) { a } });
_bp = macro(@{ Console.SetCursorPosition(0, state.startPos + barYOffset) });

@{
    using Components.PInvoke;
    using Components.ConsolePlus;

    console = {
        head,
        header,
        subhead,
        subheader,
        defaultHeaderStyle: '~|Blue~~White~',
        defaultSubheaderStyle: defaultHeaderStyle,
    
        free: @{            
            Cli.UseTrace = true;
            Kernel32.FreeConsole();
        },

        getWindow: Kernel32.GetConsoleWindow,
        exists: getWindow @> @!= IntPtr.Zero,
        runWindowCmd: @User32.ShowWindow(getWindow()),
        show: @() runWindowCmd(ShowWindowCommands.SW_SHOW),
        hide: @() runWindowCmd(ShowWindowCommands.SW_HIDE),

        bindKeyAsync: @(key, action) {
            using System.Threading;

            var t = new Thread(@{
                while (true) {
                    action();

                    while (Console.ReadKey(true).Key != key) {
                    }
                }
            });

            t.IsBackground = true;
            t.Start();

            ret t;
        },

        clear: @() _ci(Console.Clear()),

        setTitle: @(title) _ci(Console.Title = title),

        progress: {
            create: @(total) {
                var p = {
                    state: {
                        startPos: null,
                        msg: '',
                        progress: null,
                    },
                    
                    barYOffset: 1,
                    msgYOffset: 4,

                    init: @(total){    
                        state.startPos = Console.CursorTop;

                        if (Console.CursorTop >= Console.BufferHeight + msgYOffset + 2) {
                            Console.BufferHeight = Console.CursorTop + msgYOffset + 2;
                        }

                        state.progress = new CliProgressBar(total);
                    },

                    writeBar: @{
                        _bp();
                        state.progress.Write();
                    },

                    writeMsg: @{
                        var maxWidth = Console.WindowWidth - 2;

                        if (state.msg.Length > maxWidth) {
                            state.msg = state.msg.Remove(maxWidth - 3) + '...';
                        }

                        Console.SetCursorPosition(
                            Console.WindowWidth / 2 - state.msg.Length / 2 |> Math.Floor,
                            state.startPos + msgYOffset - barYOffset);
                        
                        Console.Write(state.msg);
                        Console.SetCursorPosition(0, state.startPos);
                    },

                    inc: @{
                        _bp();
                        state.progress.IncrementAndWrite();
                    },

                    update: @{
                        if ($args.Count > 0) {
                            setValue($_);
                            $args.RemoveAt(0);
                            apply(setStatus, $args);
                        }
                    },

                    setValue: @(value) {
                        state.progress.Value = value;
                        writeBar();
                    },

                    setStatus: @{
                        var lastLen = state.msg.Length;                
                        
                        switch ($args.Count) {
                            0: state.msg = '';
                            1: state.msg = $_;
                            default: {
                                var fmt = $_;
                                $args.RemoveAt(0);
                                state.msg = format(fmt, $args);
                            }
                        }

                        if (state.msg.Length < lastLen) {
                            Console.SetCursorPosition(
                                0,
                                state.startPos + msgYOffset - barYOffset);

                            Console.Write(new string(' ', Console.WindowWidth));
                        }

                        writeMsg();
                    },

                    finish: @{
                        Console.SetCursorPosition(0, state.startPos + msgYOffset + 1);
                    }
                };

                p.init(total);
                p.writeBar();
                ret p;
            },
        },
        pipeline: {
            process: @(func, source) {
                Console.CursorVisible = false;

                try {
                    var total = source #!;
                    var result = [];
                    var cur = 0;
                    var p = console.progress.create(total.double());
                    var next = @{
                        var m = '{0:n0}/{1:n0} ({2:p2})' :: [ cur.int(), total.int(), (total != 0 ? (cur / total) : 0).double() ];
                        p.update(cur++, m);
                    };

                    p.setStatus('Starting task');

                    source for {
                        next();
                        result.add(func($_));
                    };

                    next();
                    p.finish();
                    
                    ret result;
                } finally {
                    Console.CursorVisible = true;
                }
            },
        },
    };
}();

var cls = console.clear;

var stdScope = this;

if (!(stdScope.dump defined)) {
    stdScope.dump = @(o){
        (o != null ?
            !isNonNullObject(o) && toJson defined ? toJson(o) : serialize(o) :
            'null')
        | (VT100.IsEnabled ? SyntaxHighlightingFormatter.Format : @() $_)
        | Console.WriteLine;
    };
}

var dumpe = @{ 
    $_ |> dump;
    exit(0);
};

var exit = @() ($args.Count != 0 ? $_ : 0) |> Environment.Exit;

var fatal = @{
    var msg = 'Fatal error';
    throw $($args.Count) 0: msg, '{0}: {1}' :: [ msg, $args[0] :: ($args @aq.skip(1)) ];
};
").GetTokens()).Parse());
    }
}
