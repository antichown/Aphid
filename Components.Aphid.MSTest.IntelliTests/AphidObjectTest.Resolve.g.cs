using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.Resolve.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
public void ResolveThrowsArgumentNullException126()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(957);
    aphidObject = this.Resolve
                      ((AphidObject)o, (AphidInterpreter)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void ResolveThrowsArgumentNullException283()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(0);
    aphidObject = this.Resolve
                      ((AphidObject)o, (AphidInterpreter)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void ResolveThrowsNullReferenceException36()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(10);
    aphidObject =
      this.Resolve((AphidObject)o, (AphidInterpreter)null, "", (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void ResolveThrowsNullReferenceException998()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(645);
    aphidObject = this.Resolve((AphidObject)o, (AphidInterpreter)null, "", "");
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void ResolveThrowsArgumentNullException28301()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(298);
    aphidObject = this.Resolve
                      ((AphidObject)o, (AphidInterpreter)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void ResolveThrowsArgumentNullException28302()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create(19);
    aphidObject = this.Resolve
                      ((AphidObject)o, (AphidInterpreter)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(ArgumentNullException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(ArgumentNullException))]
public void ResolveThrowsArgumentNullException12601()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create();
    aphidObject = this.Resolve
                      ((AphidObject)o, (AphidInterpreter)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void ResolveThrowsNullReferenceException159()
{
    object o;
    AphidObject aphidObject;
    o = AphidObjectFactory.Create();
    aphidObject =
      this.Resolve((AphidObject)o, (AphidInterpreter)null, "", (string)null);
}
    }
}
