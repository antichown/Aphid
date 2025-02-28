using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.ConvertToArray.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
public void ConvertToArrayThrowsNullReferenceException23001()
{
    object o;
    int[] ints;
    o = AphidObjectFactory.Create(679);
    ints = this.ConvertToArray<int>((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void ConvertToArrayThrowsNullReferenceException230()
{
    object o;
    int[] ints;
    o = AphidObjectFactory.Create(0);
    ints = this.ConvertToArray<int>((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void ConvertToArrayThrowsNullReferenceException557()
{
    object o;
    int[] ints;
    o = AphidObjectFactory.Create(7);
    ints = this.ConvertToArray<int>((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void ConvertToArrayThrowsNullReferenceException55701()
{
    object o;
    int[] ints;
    o = AphidObjectFactory.Create();
    ints = this.ConvertToArray<int>((AphidObject)o);
}
    }
}
