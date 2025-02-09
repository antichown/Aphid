﻿using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidPatternMatching"), Parallelizable(ParallelScope.All)]
    public class PatternMatchingTests : AphidTests
    {
        [Test]
        public void PatternMatchingTest1() =>
            Assert9("var x = 'bar'; ret $(x) 'foo':0, 'bar':9, 1;");

        [Test]
        public void PatternMatchingTest2() =>
            Assert9("var x = 'asdf'; ret $(x) 'foo':0, 'bar':1, 9;");

        [Test]
        public void PatternMatchingTest3() =>
            Assert9("var x = 'foo'; ret $(x) 'foo':9, 'bar':1, 0;");

        [Test]
        public void PatternMatchingIdentifierCaseTest() =>
            Assert9("var f = 'foo'; var x = 'foo'; ret $(x) 'bar':1, f:9, 0;");

        [Test]
        public void PatternMatchingDecimalIntTest() =>
            Assert9("using System; var x = 10; ret $(x) Convert.ToInt32(10): 9, 20: 1, 0;");

        [Test]
        public void PatternMatchingIntDecimalTest() =>
            Assert9("using System; var x = Convert.ToInt32(10); ret $(x) 10: 9, 20: 1, 0;");

        [Test]
        public void PatternMatchingDecimalUnsignedIntTest() =>
            Assert9("using System; var x = 10; ret $(x) Convert.ToUInt32(10): 9, 20: 1, 0;");

        [Test]
        public void PatternMatchingUnsignedIntDecimalTest() =>
            Assert9("using System; var x = Convert.ToUInt32(10); ret $(x) 10: 9, 20: 1, 0;");

        [Test]
        public void PatternMatchingNullCaseTest() =>
            Assert9("var x = 'foo'; ret $(x) null: 0, 'foo':9, 'bar':1, 0;");

        [Test]
        public void PatternMatchingNullTest() =>
            Assert9("var x = null; ret $(x) 10: 1, null: 9, 0;");

        [Test]
        public void PatternMatchingNullDefaultTest() =>
            Assert9("var x = null; ret $(x) 10: 1, 2: 0, 9;");
    }
}
