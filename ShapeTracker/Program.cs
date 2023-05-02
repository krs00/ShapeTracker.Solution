using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    { 
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();  
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();  
      Console.WriteLine("Enter a third number:");
      string stringNumber3 = Console.ReadLine(); 
      //ADD TRY CATCH
            try
      {
        int length1 = int.Parse(stringNumber1);  
        int length2 = int.Parse(stringNumber2);  
        int length3 = int.Parse(stringNumber3);
        Triangle tri = new Triangle(length1, length2, length3);
        ConfirmOrEditTriangle(tri);  
      }
      catch (Exception ex)
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("ERROR: {0}", ex.Message);
        Console.WriteLine("ERROR: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.WriteLine("Please try again...");
        Main();
      // TRY CATCH END 
      // int length1 = int.Parse(stringNumber1);  
      // int length2 = int.Parse(stringNumber2);  
      // int length3 = int.Parse(stringNumber3);  
      // Triangle tri = new Triangle(length1, length2, length3);
      // ConfirmOrEditTriangle(tri);
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();  
      if (userInput == "yes")
      {
        CheckTriangleType(tri); 
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        tri.Side1 = int.Parse(stringNumber1);  
        tri.Side2 = int.Parse(stringNumber2);  
        tri.SetSide3(int.Parse(stringNumber3)); 
        ConfirmOrEditTriangle(tri);
      }
    }

    static void ViewOrDeleteTriangle(Triangle tri)
    {
          Console.WriteLine("       ");
          Console.WriteLine("Here are all of your triangles so far...");
        List<Triangle> allTriangles = Triangle.GetAll();
        int triNum = 1;
        
        for (int i = 0; i < allTriangles.Count; i++) 
        { 
          Console.WriteLine($"Triangle {triNum}: {allTriangles[i].CheckType()} | side 1 == {allTriangles[i].Side1} | side 2 == {allTriangles[i].Side2} | side 3 == {allTriangles[i].GetSide3()} |"); 
          triNum++;
        }
        Console.WriteLine("       ");
        Console.WriteLine("What's next?");
        Console.WriteLine("To add more triangles enter 'add'.");
        Console.WriteLine("To delete this collection of triangles enter 'delete'.");
        string userResponse = Console.ReadLine();
        userResponse.ToLower();
        if (userResponse == "add")
        {
        Main();
        }
        else if (userResponse == "delete")
        {
        Triangle.ClearAll();
        Console.WriteLine("What have you done .....?.");
        Main();
        }
        else
        { 
        Console.WriteLine("Goodbye!");
        }


    }

    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("             ");
      Console.WriteLine("Would you like to add a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to add a new triangle.");
      Console.WriteLine("             ");
      Console.WriteLine("Do you want to (view) and possibly (delete) all of your current triangles?");
      Console.WriteLine("Please enter 'view' to view your current triangles.");
      Console.WriteLine("             ");
      Console.WriteLine("Else, enter any key to exit.");
      string userResponse = Console.ReadLine();
      userResponse.ToLower();
      if (userResponse == "new")
      {
        Main();
      }
      else if (userResponse == "view")
      {
        ViewOrDeleteTriangle(tri);
      }
      else
      { 
        Console.WriteLine("Goodbye!");
      }
    }
  }
}
}


/* In this course section, you should make a point to practice with all of the tools we learned thus far: 

Creating private fields with getter and setter methods.
Creating private fields with public properties.
Creating public auto-implemented properties.
   */