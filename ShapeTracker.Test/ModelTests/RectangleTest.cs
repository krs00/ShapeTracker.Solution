using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
[TestClass]
public class RectangleTests
{

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
    Rectangle newRectangle = new Rectangle();
    Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
        // Arrange
    int length1 = 3;
    Rectangle newRectangle = new Rectangle(length1, 3);
      // Act
    int result = newRectangle.Side1;
      // Assert
    Assert.AreEqual(length1, result);
    }

        [TestMethod]
    public void GetArea_CalculatesAreaOfRectangle_Int()
    {
        // Arrange
    Rectangle newRectangle = new Rectangle(5, 5);
      // Act
    int result = newRectangle.GetArea();
      // Assert
    Assert.AreEqual(result, 25); 
    }

}

}


// TEST METHOD NAMING CONVENTION
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()