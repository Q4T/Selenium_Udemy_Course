using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9_Methods
{
    /*
     * Lesson 99 Static methods - 
     * methods you want to access without having to instantiate an object from the class
     * A static method belongs to a class, rather than an object of a class
     * Static methods can be used as helper methods where you don't need to instantiate an object
     * The Math class is a good example of this where you can call methods without instantiating a math object
     * 
     * Lesson 103   Optional and named parameters
     * Lesson 105 Out and ref keywords
     */

    class MathHelper
    {
        public static int Square(int val)
        {
            return val * val;
        }
        // by giving a value to a variable in the argument list you make it optional. If nothing is passed it uses the default of the value.
        public static int AddNumber(int num1, int num2 = 10)
        {
            return num1 + num2;
        }

        // we can also make both params optional if we want
        public static int AddNumberBothOptional(int num1 = 5, int num2 = 10)
        {
            return num1 + num2;
        }

        /****************************************** Lesson 105 Out and Ref keywords **********************************************/
        public static void NumberOut(out int value)
        {
            value = 9;
        }

        public static void RefParameter(ref int value)
        {
            value = 100;

        }
    }
}
