using Components.Aphid.Lexer;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Components.Aphid.Lexer.Tests
{
    public partial class TokenHelperTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01344()
{
    string s;
    s = this.GetCodeExcerptTest01((string)null, 0, 0);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01776()
{
    string s;
    s = this.GetCodeExcerptTest01("", 0, 0);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01585()
{
    string s;
    s = this.GetCodeExcerptTest01("Ā", -1, 0);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01755()
{
    string s;
    s = this.GetCodeExcerptTest01("\t", 0, 0);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01963()
{
    string s;
    s = this.GetCodeExcerptTest01("Ā", 0, 0);
    Assert.AreEqual<string>("(1) Ā\r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01705()
{
    string s;
    s = this.GetCodeExcerptTest01("Ā", 0, 7);
    Assert.AreEqual<string>("(1) Ā\r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01979()
{
    string s;
    s = this.GetCodeExcerptTest01("", 0, 0);
    Assert.AreEqual<string>("(1) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01814()
{
    string s;
    s = this.GetCodeExcerptTest01("\r", 0, 0);
    Assert.AreEqual<string>("(2) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01857()
{
    string s;
    s = this.GetCodeExcerptTest01("\r", int.MinValue, 0);
    Assert.AreEqual<string>("(1) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01962()
{
    string s;
    s = this.GetCodeExcerptTest01("\nĀ", 0, 0);
    Assert.AreEqual<string>("(2) Ā\r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest0139()
{
    string s;
    s = this.GetCodeExcerptTest01("ĀĀ", -1, 0);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01248()
{
    string s;
    s = this.GetCodeExcerptTest01("Ā\r", 0, 0);
    Assert.AreEqual<string>("(1) Ā\r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01430()
{
    string s;
    s = this.GetCodeExcerptTest01("\rĀ", int.MinValue, 7);
    Assert.AreEqual<string>("(1) \r\n(2) Ā\r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01710()
{
    string s;
    s = this.GetCodeExcerptTest01("\n\r", 0, 0);
    Assert.AreEqual<string>("(2) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01305()
{
    string s;
    s = this.GetCodeExcerptTest01("\n\r\r", 0, 0);
    Assert.AreEqual<string>("(2) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01440()
{
    string s;
    s = this.GetCodeExcerptTest01("\n\r\r\r", 0, 0);
    Assert.AreEqual<string>("(2) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01203()
{
    string s;
    s = this.GetCodeExcerptTest01("\r\r\r", 0, 0);
    Assert.AreEqual<string>("(1) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01720()
{
    string s;
    s = this.GetCodeExcerptTest01("\r\r\r\r", 0, 0);
    Assert.AreEqual<string>("(1) \r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest01974()
{
    string s;
    s = this.GetCodeExcerptTest01("I\r\n", 0, 0);
    Assert.AreEqual<string>("(1) I\r\n", s);
}

[TestMethod]
[PexGeneratedBy(typeof(TokenHelperTest))]
public void GetCodeExcerptTest03()
{
    string s;
    AphidToken aphidToken = default(AphidToken);
    s = this.GetCodeExcerptTest("\t", in aphidToken, 0);
    Assert.AreEqual<string>((string)null, s);
}
    }
}
