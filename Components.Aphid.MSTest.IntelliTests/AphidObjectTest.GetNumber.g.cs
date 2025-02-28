using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.GetNumber.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetNumberThrowsNullReferenceException213()
{
    object o;
    decimal d;
    o = AphidObjectFactory.Create(679);
    d = this.GetNumber((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(InvalidCastException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(InvalidCastException))]
public void GetNumberThrowsInvalidCastException546()
{
    object o;
    decimal d;
    o = AphidObjectFactory.Create(0);
    d = this.GetNumber((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetNumberThrowsNullReferenceException21301()
{
    object o;
    decimal d;
    o = AphidObjectFactory.Create(36);
    d = this.GetNumber((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetNumberThrowsNullReferenceException804()
{
    object o;
    decimal d;
    o = AphidObjectFactory.Create(7);
    d = this.GetNumber((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetNumberThrowsNullReferenceException80401()
{
    object o;
    decimal d;
    o = AphidObjectFactory.Create();
    d = this.GetNumber((AphidObject)o);
}
    }
}
