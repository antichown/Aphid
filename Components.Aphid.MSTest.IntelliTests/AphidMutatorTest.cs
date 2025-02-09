using System.Collections.Generic;
// <copyright file="AphidMutatorTest.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Components.Aphid.Parser;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Aphid.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(AphidMutator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AphidMutatorTest
    {

        [PexMethod(Timeout = 240)]
        [PexAllowedException(typeof(NullReferenceException))]
        public List<AphidExpression> Mutate([PexAssumeNotNull]AphidMutator target, List<AphidExpression> ast)
        {
            List<AphidExpression> result = target.Mutate(ast);
            return result;
            // TODO: add assertions to method AphidMutatorTest.Mutate(AphidMutator, List`1<AphidExpression>)
        }

        [PexMethod(Timeout = 240)]
        [PexAllowedException(typeof(NullReferenceException))]
        public List<AphidExpression> MutateRecursively([PexAssumeNotNull]AphidMutator target, List<AphidExpression> expression)
        {
            List<AphidExpression> result = target.MutateRecursively(expression);
            return result;
            // TODO: add assertions to method AphidMutatorTest.MutateRecursively(AphidMutator, List`1<AphidExpression>)
        }

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(ArgumentNullException))]
        [PexAllowedException(typeof(NotImplementedException))]
        public AphidExpression MutateSingle([PexAssumeNotNull]AphidMutator target, AphidExpression expression)
        {
            AphidExpression result = target.MutateSingle(expression);
            return result;
            // TODO: add assertions to method AphidMutatorTest.MutateSingle(AphidMutator, AphidExpression)
        }

        [PexMethod]
        public void Reset([PexAssumeNotNull]AphidMutator target)
        {
            target.Reset();
            // TODO: add assertions to method AphidMutatorTest.Reset(AphidMutator)
        }
    }
}
