using System.Collections.Generic;

namespace ShapeTracker.Models 
{
public class Triangle 
{

    /* SETTING FIELDS TO PRIVATE IS BEST PRACTICE
       Encapsulation (For Secure Data Flow) */
    private int _side1;
    public int Side1
    {
        get { return _side1; }
        set { _side1 = value; }
    }
    public int Side2 { get; set; }
    private int _side3;
    private static List<Triangle> _instances = new List<Triangle> {};
    public Triangle(int length1, int length2, int length3) 
    {
    _side1 = length1; 
    Side2 = length2;  
    _side3 = length3;
    _instances.Add(this); 
    } 

    // GETTER METHODS
    /* Getter methods follow the naming 
       convention: Get + NameOfField in Pascal case. */

    public int GetSide3()
    {
        return _side3;
    }

    // SETTER METHODS

    /* only create a setter method if you need to set the 
    value of the private field outside of the class it 
    belongs to */

    /* Setter methods follow the naming 
       convention: Set + NameOfField in Pascal case. */

    public void SetSide3(int newSide)
    {
    _side3 = newSide;
    }

    // CHECKTYPE METHOD
    public string CheckType() 
    {
    if ((_side1 > (Side2 + _side3)) || (Side2 > (_side1 + _side3)) || (_side3 > (_side1 + Side2)))
    {
        return "not a triangle";
    } 
    else if ((_side1 != Side2) && ((_side1 != _side3)) && ((Side2 != _side3))) 
    {
        return "scalene triangle";
    }  
    else if ((_side1 == Side2) && (_side1 == _side3)) 
    {
        return "equilateral triangle";
    } 
    else 
    {
        return "isosceles triangle";
    }
    }

    public static List<Triangle> GetAll()
    {
    return _instances;
    }

    public static void ClearAll()
    {
    _instances.Clear();
    }

    

}
}

/* From this point forward, all class 
fields should be private and getter 
and setter methods should be defined as needed. */


/* Auto Implemented Properties Does Multiple Things

It creates a private field. (Yes, that's right!)
It creates a public property.
It creates get and set actions to access the private field.

  */