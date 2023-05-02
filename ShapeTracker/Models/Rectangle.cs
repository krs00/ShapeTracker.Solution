using System.Collections.Generic;
namespace ShapeTracker.Models
{
public class Rectangle
{
  public Rectangle()
  {

  }
  public int Side1 { get; set; }
  public int Side2 { get; set; }

  private static List<Rectangle> _instances = new List<Rectangle> {};
    public Rectangle(int length1, int length2)
    {
      Side1 = length1;
      Side2 = length2;
      _instances.Add(this);
    }

  public int GetSide1()
  {
    return Side1;
  }

  public int GetSide2()
  {
    return Side2;
  }

   public int GetArea()
  {
    return Side1 * Side2;
  }  


}



}
