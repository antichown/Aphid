﻿using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidDefinedOperator"), Parallelizable(ParallelScope.All)]
    public class DefinedOperatorTests : AphidTests
    {
        [Test]
        public void DefinedTest() =>
            AssertTrue("var x; ret x defined;");

        [Test]
        public void DefinedTest2() =>
            AssertFalse("var test=@(){var x='foo'; ret x;}; test(); ret x defined;");

        [Test]
        public void DefinedTest3() =>
            AssertFalse("var test=@()var x='foo'; test(); ret x defined;");

        [Test]
        public void DefinedTest4() =>
            AssertTrue("var x='foo'; ret x defined;");

        [Test]
        public void DefinedTest5() =>
            AssertFalse("if (true) { var x = 1; } ret x defined;");

        [Test]
        public void DefinedTest6() =>
            AssertTrue("var x = 0; if (true) { x = 1; } ret x defined;");

        [Test]
        public void DefinedMemberTest() =>
            AssertTrue("var x = { y: 10 }; ret x.y defined;");

        [Test]
        public void DefinedMemberTest2() =>
            AssertTrue("var x = { y: { z: 10 } }; ret x.y.z defined;");

        [Test]
        public void DefinedMemberTest3() =>
            AssertTrue("var x = { y: { z: 10 } }; ret x.y defined;");

        [Test]
        public void DefinedMemberTest4() =>
            AssertTrue("var x = { y: { z: 10 } }; ret x defined;");

        [Test]
        public void DefinedMemberAssignTest() =>
            AssertTrue("var x = { }; x.y = 10; ret x.y defined;");

        [Test]
        public void DefinedMemberAssignTest2() =>
            AssertTrue("var x = { }; x.y = {}; x.y.z = 10; ret x.y.z defined;");

        [Test]
        public void DefinedMemberAssignTest3() =>
            AssertTrue("var x = { }; x.y = {}; x.y.z = 10; ret x.y defined;");

        [Test]
        public void DefinedMemberAssignTest4() =>
            AssertTrue("var x = { }; x.y = {}; x.y.z = 10; ret x defined;");
    }
}
