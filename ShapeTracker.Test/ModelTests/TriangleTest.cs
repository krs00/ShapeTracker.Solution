using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle();
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

  }
}


/* The naming convention used for test methods is the following: 
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue() */