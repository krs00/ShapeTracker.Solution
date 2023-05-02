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
      Triangle newTriangle = new Triangle(2); 
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1);
      // Act
      int result = newTriangle.Side1;
      // Assert 
      Assert.AreEqual(length1, result);
    }

        [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3);
      int newLength1 = 44;
      // Act
      newTriangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

  }
}


/* The naming convention used for test methods is the following: 
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue() */



/* Arrange, Act, Assert
This test is more complex than our previous tests. Thankfully, there's an easy organizational 
trick that helps demystify this process and keep our tests clean. It's called "Arrange, Act, Assert". With this 
organizational method, we break our tests down into three stages:

Arrange: We gather, declare and create all necessary components for the test.
In the test above, we create length1 and newTriangle.

Act: We invoke the functionality we're testing, often by calling a 
method or retrieving a property. In the test above, we call newTriangle.Side1;.

Assert: We confirm the functionality works as anticipated by comparing its 
actual output with the anticipated output. This is when we call Assert.AreEqual().   */