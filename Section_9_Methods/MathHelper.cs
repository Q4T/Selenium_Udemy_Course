using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9_Methods
{
    /*
     * 
     *     Lesson 99 Static methods - methods you want to access without having to instantiate an object from the class
     * A static method belongs to a class, rather than an object of a class
     * Static methods can be used as helper methods where you don't need to instantiate an object
     * The Math class is a good example of this where you can call methods without instantiating a math object

     */

    class MathHelper
    {
        public static int Square(int val)
        {
            return val * val;
        }
    }
}
