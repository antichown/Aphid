using System.Threading;
using System.Collections.Generic;
using Components.Aphid.Interpreter;
using System;
using Components.Aphid.TypeSystem;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.TypeSystem.Tests
{
    /// <summary>This class contains parameterized unit tests for InteropTypeResolver</summary>
    [TestClass]
    [PexClass(typeof(InteropTypeResolver))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class InteropTypeResolverTest
    {

        /// <summary>Test stub for .ctor(AphidInterpreter)</summary>
        [PexMethod]
        public InteropTypeResolver ConstructorTest(AphidInterpreter interpreter)
        {
            InteropTypeResolver target = new InteropTypeResolver(interpreter);
            return target;
            // TODO: add assertions to method InteropTypeResolverTest.ConstructorTest(AphidInterpreter)
        }

        /// <summary>Test stub for ResolveType(HashSet`1&lt;String&gt;, ReaderWriterLockSlim, String[], Boolean, Boolean)</summary>
        [PexMethod]
        public Type ResolveTypeTest(
            [PexAssumeUnderTest]InteropTypeResolver target,
            HashSet<string> imports,
            ReaderWriterLockSlim importsLock,
            string[] path,
            bool isFatal,
            bool isType
        )
        {
            Type result = target.ResolveType(imports, importsLock, path, isFatal, isType);
            return result;
            // TODO: add assertions to method InteropTypeResolverTest.ResolveTypeTest(InteropTypeResolver, HashSet`1<String>, ReaderWriterLockSlim, String[], Boolean, Boolean)
        }

        /// <summary>Test stub for ResolveType(String)</summary>
        [PexMethod]
        public Type ResolveTypeTest01(string name)
        {
            Type result = InteropTypeResolver.ResolveType(name);
            return result;
            // TODO: add assertions to method InteropTypeResolverTest.ResolveTypeTest01(String)
        }

        /// <summary>Test stub for TryResolveType(HashSet`1&lt;String&gt;, ReaderWriterLockSlim, String[], Boolean)</summary>
        [PexMethod]
        public Type TryResolveTypeTest(
            [PexAssumeUnderTest]InteropTypeResolver target,
            HashSet<string> imports,
            ReaderWriterLockSlim importsLock,
            string[] path,
            bool isType
        )
        {
            Type result = target.TryResolveType(imports, importsLock, path, isType);
            return result;
            // TODO: add assertions to method InteropTypeResolverTest.TryResolveTypeTest(InteropTypeResolver, HashSet`1<String>, ReaderWriterLockSlim, String[], Boolean)
        }

        /// <summary>Test stub for Unalias(String)</summary>
        [PexMethod]
        public string UnaliasTest(string name)
        {
            string result = InteropTypeResolver.Unalias(name);
            return result;
            // TODO: add assertions to method InteropTypeResolverTest.UnaliasTest(String)
        }
    }
}
