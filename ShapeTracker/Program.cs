using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
class Program
{
  static void Main()
  {
    Triangle testTriangle = new Triangle(3,4,5);
    Console.WriteLine(testTriangle.GetType());

  Console.WriteLine($"Side one of the triangle: {testTriangle.GetSide1()}");
  Console.WriteLine($"Side two of the triangle: {testTriangle.GetSide2()}");
  Console.WriteLine($"Side three of the triangle: {testTriangle.GetSide3()}");
  Console.WriteLine("Want to know what type of triangle you have?");
  Console.WriteLine("Calculating...");
  Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}.");
  }

}
}