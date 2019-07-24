using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Mantispid;
using Microsoft.Pex.Framework.Using;
using System;
// <copyright file="PexAssemblyInfo.cs">Copyright © AutoSec Tools LLC 2019</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Components.Aphid.Debug")]
[assembly: PexInstrumentAssembly("System.Configuration")]
[assembly: PexInstrumentAssembly("Microsoft.CSharp")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("System.Runtime.Serialization")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Configuration")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CSharp")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Runtime.Serialization")]
[assembly: PexInstrumentType(typeof(Environment))]
[assembly: PexUseType(typeof(CallIdentifierMutator))]
[assembly: PexUseType(typeof(DeclarativeStatementMutator))]
[assembly: PexUseType(typeof(IndexTrackingMutator))]
[assembly: PexUseType(typeof(PlusEqualMutator))]
[assembly: PexUseType(typeof(TypeInferenceMutator))]
[assembly: PexUseType(typeof(AphidObjectThisKeywordMutator))]
[assembly: PexUseType(typeof(IncludeMutator))]
[assembly: PexUseType(typeof(PartialOperatorMutator))]
[assembly: PexUseType(typeof(PipelineToCallMutator))]
[assembly: PexUseType(typeof(ScriptMutator))]
[assembly: PexUseType(typeof(AphidPreprocessorDirectiveMutator))]
[assembly: PexUseType(typeof(AphidMacroBodyMutator))]
[assembly: PexUseType(typeof(AphidMacroMutator))]
[assembly: PexUseType(typeof(BuildConstMutator))]
[assembly: PexUseType(typeof(ConstantFoldingMutator))]
[assembly: PexUseType(typeof(CallExpression))]
[assembly: PexUseType(typeof(ArrayAccessExpression))]
[assembly: PexUseType(typeof(ArrayExpression))]
[assembly: PexUseType(typeof(BinaryOperatorExpression))]
[assembly: PexUseType(typeof(BinaryOperatorBodyExpression))]
[assembly: PexUseType(typeof(BooleanExpression))]
[assembly: PexUseType(typeof(BreakExpression))]
[assembly: PexUseType(typeof(ContinueExpression))]
[assembly: PexUseType(typeof(DoWhileExpression))]
[assembly: PexUseType(typeof(DynamicMemberExpression))]
[assembly: PexUseType(typeof(ExtendExpression))]
[assembly: PexUseType(typeof(ForEachExpression))]
[assembly: PexUseType(typeof(ForExpression))]
[assembly: PexUseType(typeof(FunctionExpression))]
[assembly: PexUseType(typeof(GatorOpenExpression))]
[assembly: PexUseType(typeof(GatorCloseExpression))]
[assembly: PexUseType(typeof(GatorEmitExpression))]
[assembly: PexUseType(typeof(IdentifierExpression))]
[assembly: PexUseType(typeof(IfExpression))]
[assembly: PexUseType(typeof(ImplicitArgumentExpression))]
[assembly: PexUseType(typeof(ImplicitArgumentsExpression))]
[assembly: PexUseType(typeof(LoadLibraryExpression))]
[assembly: PexUseType(typeof(LoadScriptExpression))]
[assembly: PexUseType(typeof(LockExpression))]
[assembly: PexUseType(typeof(NullExpression))]
[assembly: PexUseType(typeof(NumberExpression))]
[assembly: PexUseType(typeof(ObjectExpression))]
[assembly: PexUseType(typeof(PartialFunctionExpression))]
[assembly: PexUseType(typeof(PartialOperatorExpression))]
[assembly: PexUseType(typeof(PatternExpression))]
[assembly: PexUseType(typeof(PatternMatchingExpression))]
[assembly: PexUseType(typeof(UnaryOperatorExpression))]
[assembly: PexUseType(typeof(UsingExpression))]
[assembly: PexUseType(typeof(StringExpression))]
[assembly: PexUseType(typeof(SwitchCase))]
[assembly: PexUseType(typeof(SwitchExpression))]
[assembly: PexUseType(typeof(TernaryOperatorExpression))]
[assembly: PexUseType(typeof(TextExpression))]
[assembly: PexUseType(typeof(ThisExpression))]
[assembly: PexUseType(typeof(TryExpression))]
[assembly: PexUseType(typeof(WhileExpression))]

