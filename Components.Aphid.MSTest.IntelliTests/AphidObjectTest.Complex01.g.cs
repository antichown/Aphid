using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.Complex01.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
public void Complex01ThrowsNullReferenceException225()
{
    AphidObject aphidObject;
    aphidObject =
      this.Complex01((IEnumerable<KeyValuePair<string, AphidObject>>)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
public void Complex01129()
{
    AphidObject aphidObject;
    KeyValuePair<string, AphidObject>[] keyValuePairs
       = new KeyValuePair<string, AphidObject>[0];
    aphidObject =
      this.Complex01((IEnumerable<KeyValuePair<string, AphidObject>>)keyValuePairs);
    Assert.IsNotNull((object)aphidObject);
    Assert.AreEqual<bool>(false, aphidObject.IsScalar);
    Assert.AreEqual<bool>(true, aphidObject.IsComplex);
    Assert.AreEqual<bool>(true, aphidObject.IsComplexitySet);
    Assert.IsNull(aphidObject.Value);
    Assert.IsNull(aphidObject.Parent);
    Assert.IsNotNull(((Dictionary<string, AphidObject>)aphidObject).Comparer);
    Assert.AreEqual<int>(0, ((Dictionary<string, AphidObject>)aphidObject).Count);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void Complex01ThrowsArgumentNullException281()
{
    AphidObject aphidObject;
    KeyValuePair<string, AphidObject>[] keyValuePairs
       = new KeyValuePair<string, AphidObject>[1];
    aphidObject =
      this.Complex01((IEnumerable<KeyValuePair<string, AphidObject>>)keyValuePairs);
}
    }
}