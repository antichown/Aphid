using Microsoft.Pex.Framework.Generated;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.ConvertFrom02.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Components.Aphid.TypeSystem.Tests
{
    public partial class AphidObjectTest
    {

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
public void ConvertFrom02518()
{
    AphidObject aphidObject;
    aphidObject = this.ConvertFrom02<int>(0);
    Assert.IsNotNull((object)aphidObject);
    Assert.AreEqual<bool>(true, aphidObject.IsScalar);
    Assert.AreEqual<bool>(false, aphidObject.IsComplex);
    Assert.AreEqual<bool>(true, aphidObject.IsComplexitySet);
    Assert.IsNotNull(aphidObject.Value);
    Assert.AreEqual<int>(0, (int)(aphidObject.Value));
    Assert.IsNull(aphidObject.Parent);
    Assert.IsNotNull(((Dictionary<string, AphidObject>)aphidObject).Comparer);
    Assert.AreEqual<int>(0, ((Dictionary<string, AphidObject>)aphidObject).Count);
}
    }
}
