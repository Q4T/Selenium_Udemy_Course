using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Classes_And_Methods
{
    /**************************************************************
     * 
     * Lesson 66 Writing a class
     * Lesson 67 Getters and Setters
     * Lesson 68 Constructors
     * Lesson 69 methods in classes
     * lesson 70 Instatiate a class
     * 
     * if we don't set a constructor a default will be set
     * We can set multiple constructors to allow different numbers of variables
     * 
     * *************************************************************/
    class Car
    {
        // private variables
        string colour;    //this is a property
        int numOfDoors;
        bool isConvertable;

        // Constructor
        public Car (string carColour, int doors, bool convertable)   // no return type
        {   // specifying the paramaters means we cannot have a class without these being set.

            Colour = carColour; // set the passed in variable to the setter and getter
            NumOfDoors = doors;
            IsConvertable = convertable;
        }
 
        // Get and Set accessors - properties that define noun like atributes of the class
        public string Colour // this is a property (getter and setter) and so has NO Parenthases
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;  // value is a keyword
            }
        }

            // Auto-implemented property - can't do any sort of validation like this though
        public bool IsConvertable
        {
            get; set;
        }

        
        public int NumOfDoors
        {
            get { return numOfDoors;}
            set
            {
                if (value <= 4)
                {
                    numOfDoors = value;
                }
                else
                {
                    // whatever
                }

            }

          


        }



        // Methods - Verb attributes
        public void Accelerate()
        {
            Console.WriteLine("I am accelerating");
        }

        public bool FamilyCar()
        {
            if (NumOfDoors >= 4)  // always query the accessor never the class var directly
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
