﻿using Components.Aphid.UnitTests.Shared;
using NUnit.Framework;

namespace Components.Aphid.UnitTests
{
    [TestFixture(Category = "AphidThis"), Parallelizable(ParallelScope.All)]
    public class ThisTests : AphidTests
    {
        public override bool LoadStd => true;

        [Test]
        public void ThisTest1() =>
            Assert9("var x=9; var f=@(a)a.x; ret f(this);");

        [Test]
        public void ThisTest2() =>
            Assert9(@"
                var f=@() {
	                var x = 9;
	                ret this;
                };
                ret f().x;                
            ");

        [Test]
        public void ThisTest3() =>
            Assert9(@"
                var x = 8;

                var f=@() {

                    var f2=@() {
                        ret this;
                    };
	                
                    ret f2();
                };
                
                ret f().x + 1;                
            ");

        [Test]
        public void ThisTest4() =>
            Assert9(@"
                var f = @() {
                    var z = 8;
                    ret this;
                };

                var f2=@(y) {

                    var f3=@(x) {
                        ret this;
                    };
	                
                    ret f3(this);
                };
                
                ret f2(f()).x.y.z + 1;                
            ");
    }
}
