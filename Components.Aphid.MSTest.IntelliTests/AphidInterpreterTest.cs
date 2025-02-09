using Components.Aphid.Parser;
using System.Collections.Generic;
using Components.Aphid.TypeSystem;
// <copyright file="AphidInterpreterTest.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Components.Aphid.Interpreter;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Components.Aphid.Interpreter.Tests
{
    [TestClass]
    [PexClass(typeof(AphidInterpreter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidInterpreterTest
    {

        [PexMethod]
        public AphidInterpreter Constructor()
        {
            AphidInterpreter target = new AphidInterpreter();
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor()
        }

        [PexMethod]
        public AphidInterpreter Constructor01(bool createLoader)
        {
            AphidInterpreter target = new AphidInterpreter(createLoader);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor01(Boolean)
        }

        [PexMethod]
        public AphidInterpreter Constructor02(AphidObject currentScope)
        {
            AphidInterpreter target = new AphidInterpreter(currentScope);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor02(AphidObject)
        }

        [PexMethod]
        public AphidInterpreter Constructor04(AphidLoader loader)
        {
            AphidInterpreter target = new AphidInterpreter(loader);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor04(AphidLoader)
        }

        [PexMethod]
        public AphidInterpreter Constructor05(AphidObject currentScope, AphidLoader loader)
        {
            AphidInterpreter target = new AphidInterpreter(currentScope, loader);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor05(AphidObject, AphidLoader)
        }

        [PexMethod]
        public AphidInterpreter Constructor06(AphidObject currentScope, Stack<AphidFrame> frames)
        {
            AphidInterpreter target = new AphidInterpreter(currentScope, frames);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor06(AphidObject, Stack`1<AphidFrame>)
        }

        [PexMethod]
        public AphidInterpreter Constructor07(
            AphidObject currentScope,
            bool createLoader,
            Stack<AphidFrame> frames
        )
        {
            AphidInterpreter target = new AphidInterpreter(currentScope, createLoader, frames);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor07(AphidObject, Boolean, Stack`1<AphidFrame>)
        }

        [PexMethod]
        public Type GetIpcContextType()
        {
            Type result = AphidInterpreter.GetIpcContextType();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetIpcContextType()
        }

        [PexMethod]
        public AphidInterpreter Constructor03([PexAssumeUnderTest]AphidObject currentScope, bool createLoader)
        {
            AphidInterpreter target = new AphidInterpreter(currentScope, createLoader);
            return target;
            // TODO: add assertions to method AphidInterpreterTest.Constructor03(AphidObject, Boolean)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(InvalidCastException))]
        [PexAllowedException(typeof(IndexOutOfRangeException))]
        public AphidObject Interpret([PexAssumeUnderTest]AphidInterpreter target, [PexAssumeUnderTest]AphidExpression expression)
        {
            AphidObject result = target.Interpret(expression);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.Interpret(AphidInterpreter, AphidExpression)
        }

        [PexMethod(MaxConstraintSolverTime = 4)]
        [PexAllowedException(typeof(AphidParserException))]
        [PexAllowedException(typeof(NullReferenceException))]
        public void Interpret01([PexAssumeUnderTest]AphidInterpreter target, [PexAssumeUnderTest]string code)
        {
            target.Interpret(code);
            // TODO: add assertions to method AphidInterpreterTest.Interpret01(AphidInterpreter, String)
        }

        [PexMethod(MaxConstraintSolverTime = 4)]
        [PexAllowedException(typeof(NullReferenceException))]
        public void Interpret02([PexAssumeUnderTest]AphidInterpreter target, [PexAssumeUnderTest]List<AphidExpression> expressions)
        {
            target.Interpret(expressions);
            // TODO: add assertions to method AphidInterpreterTest.Interpret02(AphidInterpreter, List`1<AphidExpression>)
        }

        [PexMethod(MaxConstraintSolverTime = 2)]
        public void AddImport([PexAssumeUnderTest]AphidInterpreter target, string name)
        {
            PexSymbolicValue.Ignore(target.OwnerThread);
            PexSymbolicValue.Ignore(target.AsmBuilder.AssemblyName);
            PexSymbolicValue.Ignore(target.AsmBuilder.AssemblyFilename);
            target.AddImport(name);
            // TODO: add assertions to method AphidInterpreterTest.AddImport(AphidInterpreter, String)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(AphidRuntimeException))]
        public AphidObject CallFunction02(
            [PexAssumeUnderTest]AphidInterpreter target,
            AphidObject function,
            object[] args
        )
        {
            AphidObject result = target.CallFunction(function, args);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CallFunction02(AphidInterpreter, AphidObject, Object[])
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public AphidObject CallFunction01(
            [PexAssumeUnderTest]AphidInterpreter target,
            AphidFunction function,
            object[] parms
        )
        {
            AphidObject result = target.CallFunction(function, parms);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CallFunction01(AphidInterpreter, AphidFunction, Object[])
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public AphidObject CallFunctionWithScope(
            [PexAssumeUnderTest]AphidInterpreter target,
            AphidFunction function,
            AphidObject scope,
            object[] parms
        )
        {
            AphidObject result = target.CallFunctionWithScope(function, scope, parms);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CallFunctionWithScope(AphidInterpreter, AphidFunction, AphidObject, Object[])
        }

        [PexMethod(MaxConstraintSolverTime = 2)]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(AphidParserException))]
        public void Interpret(
            [PexAssumeUnderTest]AphidInterpreter target,
            string code,
            bool isTextDocument
        )
        {
            target.Interpret(code, isTextDocument);
            // TODO: add assertions to method AphidInterpreterTest.Interpret(AphidInterpreter, String, Boolean)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(AphidParserException))]
        public void Interpret01(
            [PexAssumeUnderTest]AphidInterpreter target,
            string code,
            string filename,
            bool isTextDocument
        )
        {
            target.Interpret(code, filename, isTextDocument);
            // TODO: add assertions to method AphidInterpreterTest.Interpret01(AphidInterpreter, String, String, Boolean)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public AphidObject CallInteropFunction(
            [PexAssumeUnderTest]AphidInterpreter target,
            AphidExpression callExpression,
            AphidInteropMethodInfo methodInfo,
            AphidInteropMember interopMembers
        )
        {
            AphidObject result = target.CallInteropFunction(callExpression, methodInfo, interopMembers);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CallInteropFunction(AphidInterpreter, AphidExpression, AphidInteropMethodInfo, AphidInteropMember)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public AphidObject CallStaticInteropFunction([PexAssumeUnderTest]AphidInterpreter target, CallExpression callExpression)
        {
            AphidObject result = target.CallStaticInteropFunction(callExpression);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CallStaticInteropFunction(AphidInterpreter, CallExpression)
        }

        [PexMethod]
        internal AphidFrame CreateEntryFrame([PexAssumeUnderTest]AphidInterpreter target)
        {
            AphidFrame result = target.CreateEntryFrame();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateEntryFrame(AphidInterpreter)
        }

        [PexMethod]
        public AphidRuntimeException CreateExpressionException(
            [PexAssumeUnderTest]AphidInterpreter target,
            AphidExpression expression,
            object obj,
            string message,
            object[] args
        )
        {
            AphidRuntimeException result = target.CreateExpressionException(expression, obj, message, args);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateExpressionException(AphidInterpreter, AphidExpression, Object, String, Object[])
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public AphidRuntimeException CreateInternalException(
            [PexAssumeUnderTest]AphidInterpreter target,
            string message,
            object[] args
        )
        {
            AphidRuntimeException result = target.CreateInternalException(message, args);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateInternalException(AphidInterpreter, String, Object[])
        }

        [PexMethod]
        [PexAllowedException(typeof(InvalidOperationException))]
        public AphidIpcContext CreateIpcClientContext([PexAssumeUnderTest]AphidInterpreter target)
        {
            AphidIpcContext result = target.CreateIpcClientContext();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateIpcClientContext(AphidInterpreter)
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public AphidRuntimeException CreateRuntimeException(
            [PexAssumeUnderTest]AphidInterpreter target,
            string message,
            object[] args
        )
        {
            AphidRuntimeException result = target.CreateRuntimeException(message, args);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateRuntimeException(AphidInterpreter, String, Object[])
        }

        [PexMethod]
        public AphidRuntimeException CreateRuntimeException01(
            [PexAssumeUnderTest]AphidInterpreter target,
            AphidExpression expression,
            object obj
        )
        {
            AphidRuntimeException result = target.CreateRuntimeException(expression, obj);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateRuntimeException01(AphidInterpreter, AphidExpression, Object)
        }

        [PexMethod]
        public AphidRuntimeException CreateValueException(
            [PexAssumeUnderTest]AphidInterpreter target,
            object obj,
            string message,
            object[] args
        )
        {
            AphidRuntimeException result = target.CreateValueException(obj, message, args);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CreateValueException(AphidInterpreter, Object, String, Object[])
        }

        [PexMethod]
        public AphidObject CurrentScopeGet([PexAssumeUnderTest]AphidInterpreter target)
        {
            AphidObject result = target.CurrentScope;
            return result;
            // TODO: add assertions to method AphidInterpreterTest.CurrentScopeGet(AphidInterpreter)
        }

        [PexMethod]
        public void EnterScope([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.EnterScope();
            // TODO: add assertions to method AphidInterpreterTest.EnterScope(AphidInterpreter)
        }

        [PexMethod]
        public Func<AphidFrame[]> GetFrameArrayGet([PexAssumeUnderTest]AphidInterpreter target)
        {
            Func<AphidFrame[]> result = target.GetFrameArray;
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetFrameArrayGet(AphidInterpreter)
        }

        [PexMethod]
        public HashSet<string> GetImports([PexAssumeUnderTest]AphidInterpreter target)
        {
            HashSet<string> result = target.GetImports();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetImports(AphidInterpreter)
        }

        [PexMethod]
        public AphidObject GetReturnValue([PexAssumeUnderTest]AphidInterpreter target)
        {
            AphidObject result = target.GetReturnValue();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetReturnValue(AphidInterpreter)
        }

        [PexMethod]
        public string GetScriptFilename([PexAssumeUnderTest]AphidInterpreter target)
        {
            string result = target.GetScriptFilename();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetScriptFilename(AphidInterpreter)
        }

        [PexMethod]
        public AphidFrame GetStackFrame([PexAssumeUnderTest]AphidInterpreter target, int offset)
        {
            AphidFrame result = target.GetStackFrame(offset);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetStackFrame(AphidInterpreter, Int32)
        }

        [PexMethod]
        [PexAllowedException(typeof(IndexOutOfRangeException))]
        public AphidFrame GetStackFrame01([PexAssumeUnderTest]AphidInterpreter target)
        {
            AphidFrame result = target.GetStackFrame();
            return result;
            // TODO: add assertions to method AphidInterpreterTest.GetStackFrame01(AphidInterpreter)
        }

        [PexMethod]
        public void InsertNext([PexAssumeUnderTest]AphidInterpreter target, IEnumerable<AphidExpression> block)
        {
            target.InsertNext(block);
            // TODO: add assertions to method AphidInterpreterTest.InsertNext(AphidInterpreter, IEnumerable`1<AphidExpression>)
        }

        [PexMethod]
        public void InterpretFile([PexAssumeUnderTest]AphidInterpreter target, string filename)
        {
            target.InterpretFile(filename);
            // TODO: add assertions to method AphidInterpreterTest.InterpretFile(AphidInterpreter, String)
        }

        [PexMethod]
        public void InterpretFile01(
            [PexAssumeUnderTest]AphidInterpreter target,
            string filename,
            bool isTextDocument
        )
        {
            target.InterpretFile(filename, isTextDocument);
            // TODO: add assertions to method AphidInterpreterTest.InterpretFile01(AphidInterpreter, String, Boolean)
        }

        [PexMethod]
        public AphidObject InterpretStream([PexAssumeUnderTest]AphidInterpreter target, string code)
        {
            AphidObject result = target.InterpretStream(code);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.InterpretStream(AphidInterpreter, String)
        }

        [PexMethod]
        public bool LeaveScope([PexAssumeUnderTest]AphidInterpreter target, bool bubbleReturnValue)
        {
            bool result = target.LeaveScope(bubbleReturnValue);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.LeaveScope(AphidInterpreter, Boolean)
        }

        [PexMethod]
        [PexAllowedException(typeof(AphidRuntimeException))]
        public void LeaveSharedScope([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.LeaveSharedScope();
            // TODO: add assertions to method AphidInterpreterTest.LeaveSharedScope(AphidInterpreter)
        }

        [PexMethod]
        public void PopFrame([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.PopFrame();
            // TODO: add assertions to method AphidInterpreterTest.PopFrame(AphidInterpreter)
        }

        [PexMethod]
        public void PopQueuedFrames([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.PopQueuedFrames();
            // TODO: add assertions to method AphidInterpreterTest.PopQueuedFrames(AphidInterpreter)
        }

        [PexMethod]
        public void PopQueuedFrames01([PexAssumeUnderTest]AphidInterpreter target, int offset)
        {
            target.PopQueuedFrames(offset);
            // TODO: add assertions to method AphidInterpreterTest.PopQueuedFrames01(AphidInterpreter, Int32)
        }

        [PexMethod]
        public AphidObject PreviousScopeGet([PexAssumeUnderTest]AphidInterpreter target)
        {
            AphidObject result = target.PreviousScope;
            return result;
            // TODO: add assertions to method AphidInterpreterTest.PreviousScopeGet(AphidInterpreter)
        }

        [PexMethod]
        public void RegisterIpcServer([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.RegisterIpcServer();
            // TODO: add assertions to method AphidInterpreterTest.RegisterIpcServer(AphidInterpreter)
        }

        [PexMethod]
        public void ResetState([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.ResetState();
            // TODO: add assertions to method AphidInterpreterTest.ResetState(AphidInterpreter)
        }

        [PexMethod]
        public void SetInitialScope([PexAssumeUnderTest]AphidInterpreter target, AphidObject scope)
        {
            target.SetInitialScope(scope);
            // TODO: add assertions to method AphidInterpreterTest.SetInitialScope(AphidInterpreter, AphidObject)
        }

        [PexMethod]
        public bool SetIsInTryCatchFinally([PexAssumeUnderTest]AphidInterpreter target, bool value)
        {
            bool result = target.SetIsInTryCatchFinally(value);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.SetIsInTryCatchFinally(AphidInterpreter, Boolean)
        }

        [PexMethod]
        public void SetScriptFilename([PexAssumeUnderTest]AphidInterpreter target, string filename)
        {
            target.SetScriptFilename(filename);
            // TODO: add assertions to method AphidInterpreterTest.SetScriptFilename(AphidInterpreter, String)
        }

        [PexMethod]
        public void TakeOwnership([PexAssumeUnderTest]AphidInterpreter target)
        {
            target.TakeOwnership();
            // TODO: add assertions to method AphidInterpreterTest.TakeOwnership(AphidInterpreter)
        }

        [PexMethod]
        [PexAllowedException(typeof(AphidRuntimeException))]
        public AphidObject WrapInteropValue([PexAssumeUnderTest]AphidInterpreter target, object value)
        {
            AphidObject result = target.WrapInteropValue(value);
            return result;
            // TODO: add assertions to method AphidInterpreterTest.WrapInteropValue(AphidInterpreter, Object)
        }

        [PexMethod]
        public void WriteOut([PexAssumeUnderTest]AphidInterpreter target, string text)
        {
            target.WriteOut(text);
            // TODO: add assertions to method AphidInterpreterTest.WriteOut(AphidInterpreter, String)
        }
    }
}
