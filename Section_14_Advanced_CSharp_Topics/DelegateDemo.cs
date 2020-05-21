using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void Procedure();
public delegate int PerformCalc(int x, int y);   // can pass in vars aswell.

// Lesson 157 Delegates

namespace Section_14_Advanced_CSharp_Topics
{
    class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1"); 
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public  void Method3()
        {
            Console.WriteLine("Method 3");
        }

         public static void Main()
        {
            Procedure someProc = null;  // this instantiates the delegate by creating a variable of type Procedure  

            someProc += new Procedure(DelegateDemo.Method1);
            someProc += new Procedure(Method2);  // example without class name as not required cos we are in this class
            
            DelegateDemo demo = new DelegateDemo();
            someProc += new Procedure(demo.Method3);
            someProc();  // this calls the delgate instance 
        }

    }
}
