using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.TypeSystem;
// <copyright file="TypeExtenderTest.TryResolve02.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;
using Microsoft.Pex.Engine.Exceptions;

namespace Components.Aphid.TypeSystem.Tests
{
    public partial class TypeExtenderTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve02139()
{
    AphidObject aphidObject;
    string[] ss = new string[4];
    aphidObject =
      this.TryResolve02((AphidObject)null, (AphidObject)null, ss, (string)null, 
                        false, true, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve02677()
{
    AphidObject aphidObject;
    string[] ss = new string[0];
    aphidObject =
      this.TryResolve02((AphidObject)null, (AphidObject)null, ss, (string)null, 
                        false, true, false, true, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve02151()
{
    AphidObject aphidObject;
    string[] ss = new string[0];
    aphidObject =
      this.TryResolve02((AphidObject)null, (AphidObject)null, ss, (string)null, 
                        false, false, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void TryResolve02ThrowsNullReferenceException327()
{
    AphidObject aphidObject;
    aphidObject = this.TryResolve02
                      ((AphidObject)null, (AphidObject)null, (string[])null, (string)null, 
                       false, false, false, true, false);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void TryResolve02ThrowsNullReferenceException334()
{
    AphidObject aphidObject;
    aphidObject = this.TryResolve02
                      ((AphidObject)null, (AphidObject)null, (string[])null, (string)null, 
                       false, false, true, false, false);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void TryResolveThrowsNullReferenceException688()
{
    AphidObject aphidObject;
    aphidObject =
      this.TryResolve((AphidObject)null, (AphidObject)null, (string)null, 
                      false, false, false, false);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void TryResolveThrowsNullReferenceException254()
{
    AphidObject aphidObject;
    aphidObject =
      this.TryResolve((AphidObject)null, (AphidObject)null, (string)null, 
                      true, false, false, false);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve927()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(0);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve178()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(0);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, true, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve76()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(0);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, false, true, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve92701()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(1);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve92702()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(24);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve697()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(12);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve69701()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create();
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  false, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve955()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(0);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  true, false, false, false);
    Assert.IsNull((object)aphidObject);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
public void TryResolve95501()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(1);
    aphidObject = this.TryResolve((AphidObject)null, (AphidObject)o, (string)null, 
                                  true, false, false, false);
    Assert.IsNull((object)aphidObject);
}
    }
}
