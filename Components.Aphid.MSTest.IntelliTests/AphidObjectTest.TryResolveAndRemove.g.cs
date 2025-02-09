using System.Collections.Generic;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.TryResolveAndRemove.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
    public partial class AphidObjectTest
    {

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void TryResolveAndRemoveThrowsArgumentNullException78101()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(1);
    b = this.TryResolveAndRemove((AphidObject)o, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void TryResolveAndRemoveThrowsArgumentNullException781()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(0);
    b = this.TryResolveAndRemove((AphidObject)o, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
public void TryResolveAndRemove623()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(170);
    b = this.TryResolveAndRemove((AphidObject)o, "");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull(o);
    Assert.AreEqual<bool>(true, ((AphidObject)o).IsScalar);
    Assert.AreEqual<bool>(false, ((AphidObject)o).IsComplex);
    Assert.AreEqual<bool>(true, ((AphidObject)o).IsComplexitySet);
    Assert.IsNotNull(((AphidObject)o).Value);
    Assert.IsNull(((AphidObject)o).Parent);
    Assert.IsNotNull(((Dictionary<string, AphidObject>)o).Comparer);
    Assert.AreEqual<int>(0, ((Dictionary<string, AphidObject>)o).Count);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void TryResolveAndRemoveThrowsArgumentNullException644()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(2);
    b = this.TryResolveAndRemove((AphidObject)o, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void TryResolveAndRemoveThrowsArgumentNullException78102()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(608);
    b = this.TryResolveAndRemove((AphidObject)o, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void TryResolveAndRemoveThrowsArgumentNullException78103()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(4);
    b = this.TryResolveAndRemove((AphidObject)o, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void TryResolveAndRemoveThrowsArgumentNullException64401()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create();
    b = this.TryResolveAndRemove((AphidObject)o, (string)null);
}
    }
}
