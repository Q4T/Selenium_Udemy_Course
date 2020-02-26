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
     * Lesson 68 COnstructors
     * 
     * *************************************************************/
    class Car
    {

        // private variables
        string colour;    //this is a property
        int numOfDoors;
        bool isConvertable;

        // Constructor
        public Car ()   // no return type
        {

        }
 
        // Get and Sett accessors - properties that define noun like atributes of the class
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
    }
}
