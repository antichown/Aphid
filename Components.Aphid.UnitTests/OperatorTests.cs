﻿using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;
namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidOperator"), Parallelizable(ParallelScope.All)]
    public class OperatorTests : AphidTests
    {
        public override bool LoadStd => true;

        [Test] public void StringConcatTest() =>
            AssertFoo("ret 'fo'+'o';");
        [Test] public void AdditionTest() =>
            Assert9("ret 2+7;");
        [Test] public void SubtractionTest() =>
            Assert9("ret 11-2;");
        [Test] public void MultiplicationTest() =>
            AssertEquals(20m, "ret 10*2;");
        [Test] public void DivisionTest() =>
            Assert9("ret 27 / 3;");
        [Test] public void ModulusTest() =>
            Assert9("ret 39 % 30;");
        [Test] public void BinaryAndTest() =>
            Assert9("ret 9 & 11;");
        [Test] public void BinaryOrTest() =>
            Assert9("ret 9 | 1;");
        [Test] public void BinaryOrTest2() =>
            Assert9("ret 8 | 1;");
        [Test] public void BinaryXorTest() =>
            Assert9("ret 32 ^ 41;");
        [Test] public void BinaryShiftLeftTest() =>
            Assert9("ret (4 << 1) + 1;");
        [Test] public void BinaryShiftRightTest() =>
            Assert9("ret 36 >> 2;");
        [Test] public void AdditionAndAssignmentTest() =>
            Assert9("var x = 2; x += 7; ret x;");
        [Test] public void AdditionAndAssignmentRetTest() =>
            Assert9("var x = 2; ret x += 7;");
        [Test] public void SubtractionAndAssignmentTest() =>
            Assert9("var x = 11; x -= 2; ret x;");
        [Test] public void MultiplicationAndAssignmentTest() =>
            Assert9("var x = 4.5; x *= 2; ret x;");
        [Test] public void DivisionAndAssignmentTest() =>
            Assert9("var x = 18; x /= 2; ret x;");
        [Test] public void ModulusAndAssignmentTest() =>
            Assert9("var x = 19; x %= 10; ret x;");
        [Test] public void BinaryAndAssignmentTest() =>
            Assert9("var x = 9; x &= 11; ret x;");
        [Test] public void BinaryOrAssignmentTest() =>
            Assert9("var x = 9; x |= 1; ret x;");
        [Test] public void BinaryXorAssignmentTest() =>
            Assert9("var x = 32; x ^= 41; ret x;");
        [Test] public void BinaryShiftLeftAssignmentTest() =>
            Assert9("var x = 4; x <<= 1; ret ++x;");
        [Test] public void BinaryShiftRightAssignmentTest() =>
            Assert9("var x = 36; x >>= 2; ret x;");
        [Test] public void ConditionalTest() =>
            Assert9("ret true ? 9 : 10;");
        [Test] public void ConditionalTest2() =>
            Assert9("ret false ? 10 : 9;");
        [Test] public void ConditionalTest3() =>
            Assert9("ret false ? 10 : true ? 9 : 8;");
        [Test] public void ConditionalTest4() =>
            Assert9("ret false ? 10 : false ? 8 : 9;");
        [Test] public void RangeTest() =>
            Assert9("ret (0 .. 9) #!;");
        [Test] public void RangeTest2() =>
            AssertEquals(0m, "ret (0 .. 9)[0];");
        [Test] public void RangeTest3() =>
            Assert9("ret (0 .. 10)[9];");
        [Test] public void PrefixIncrementTest() =>
            Assert9("var x = 8; x++; ret x;");
        [Test] public void PrefixIncrementTest2() =>
            Assert9("var x = 9; ret x++;");
        [Test] public void PostfixIncrementTest() =>
            Assert9("var x = 8; ++x; ret x;");
        [Test] public void PostfixIncrementTest2() =>
            Assert9("var x = 8; ret ++x;");
        [Test] public void PrefixIncrementObjTest() =>
            Assert9("var o={x: 8}; o.x++; ret o.x;");
        [Test] public void PrefixIncrementObjTest2() =>
            Assert9("var o={x: 9}; ret o.x++;");
        [Test] public void PostfixIncrementObjTest() =>
            Assert9("var o={x: 8}; ++o.x; ret o.x;");
        [Test] public void PostfixIncrementObjTest2() =>
            Assert9("var o={x: 8}; ret ++o.x;");
        [Test] public void OnesComplementTest() =>
            Assert9("ret ~18446744073709551606;");
        [Test] public void OnesComplementTest2() =>
            Assert9("ret ~(18446744073709530566 + 0x5230);");
        [Test] public void OnesComplementTest3() =>
            Assert9("ret ~(18446744069973623047 + 0xdeadbeef);");
        [Test] public void SelectOperatorTest() =>
            AssertExp9(@"([ '1', '2', '9']->(@(x) num(x)))[2]");
        [Test] public void SelectManyOperatorTest() =>
            AssertExp9(@"([ 2, 3 ]-<(@(x) [ x, x*x ]))[3]");
        [Test] public void WhereOperatorTest() =>
            AssertExp9("([ 2, 9, 10, 20 ]-?(@(x) (x & 1) == 1))[0]");
        [Test] public void AggregateOperatorTest() =>
            AssertExpFoo("[ 'f', 'o' ]+>(@(x, y) x + 'o' + y)");
        [Test] public void AnyOperatorTest() =>
            AssertExpTrue("'hello world'.chars()=?(@(x) x == 'r')");
        [Test] public void AnyOperatorTest2() =>
            AssertExpFalse("'hello world'.chars()=?(@(x) x == 'z')");
        [Test] public void DistinctOperatorTest() =>
            AssertExpEquals(1, "([ 2, 2, 2, ]!?).count()");
        [Test] public void DistinctOperatorTest2() =>
            AssertExpEquals(3, "([ 1, 1, 1, 2, 2, 2, 3, 3, 3 ]!?).count()");
    }
}
