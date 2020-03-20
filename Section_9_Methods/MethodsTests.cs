using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_9_Methods
{
    /*
     * Lesson 98     method call stack
     * Creating an instance of a class from within the same class i.e MethodsCallStack
     * 
     * Lesson 99     Static methods - methods you want to access without having to instantiate an object from the class
     * A static method belongs to a class, rather than an object of a class
     * Static methods can be used as helper methods where you don't need to instantiate an object
     * The Math class is a good example of this where you can call methods without instantiating a math object
     * 
     * Lesson 100    Method overloading
     * https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/member-overloading
     * 
     * Lesson 103 Optional and named parameters
     * Lesson 105 Out and Ref keywords
     * Lesson 106 Tuples
     */

    [TestClass]
    public class MethodsTests
    {
        [TestMethod]
        public void TestSquare()
        {
            MethodsTests method = new MethodsTests();
           int val = method.Square(10);
            Assert.AreEqual(val, 100); 
        }


        public int Square(int val)
        {
            return val * val;
        }

        /*************************************** Calling static methods ************************************/

        [TestMethod]
        public void testStaticSquare()
        {
            int result = MathHelper.Square(6);
            Assert.AreEqual(result, 36);
        }

        /* 
         * Lesson 103 Optional and named parameters
         */

        [TestMethod]
        // Named parameter test
        public void TestSquare_NamedParameter()
        {
            Assert.AreEqual(36, MathHelper.Square(val: 6)); // call a named parameter by using dyntax  (argumentName: value)
        }

        [TestMethod]
        public void NameParametertest()
        {
            int sum_12 = MathHelper.AddNumber(2);
            int sum12 = MathHelper.AddNumber(1, 11);
            int sum15 = MathHelper.AddNumberBothOptional();
            // for the above where both arguments are optional if we want to pass in a value for the second param but leave the first as default
            // we have to use a named param to tell it which parameter we are assigning the value to
            int sum_10 = MathHelper.AddNumberBothOptional(num2: 5);
        }


        // ***************************   Calling an overloaded method *****************************

        [TestMethod]
        public void Test_Employee_Overload_String()
        {
            Section_6_Classes_And_Methods.Employee emp = new Section_6_Classes_And_Methods.Employee("Billy","Ballbuster");
            emp.JobDescription = "Manager";
            string woof = emp.PayType("emp.JobDescription");
            Console.WriteLine(woof);
        }
        [TestMethod]
        public void Test_Employee_Overload_Int()
        {
            Section_6_Classes_And_Methods.Employee emp = new Section_6_Classes_And_Methods.Employee("Billy", "Ballbuster");
            emp.EmployeeNum = 1234;
            string woof = emp.PayType(emp.EmployeeNum);
            Console.WriteLine(woof);
        }
        [TestMethod]
        public override bool Equals(object obj)
        {
            bool whatever  = true;
            return whatever;
        }

        /****************************************** Lesson 105 Out and Ref keywords **********************************************/
        [TestMethod]
        public void TestOutParameter()
        {
            int num;
            MathHelper.NumberOut(out num);
            Assert.AreEqual(9, num);
        }
        [TestMethod]
        public void Ref_Test()
        {
            int num = 0;
            MathHelper.RefParameter(ref num);
            Assert.AreEqual(100, num);
        }

        /**************************************** Lesson 106 Tuples ****************************************************************/
        [TestMethod]
        public void Test_Tuples()
        {
            //create the tuple
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "woof", true);

            //access the tuple
            if(myTuple.Item1 == 1)
            {
                Console.WriteLine(myTuple.Item1);
            }
            if (myTuple.Item2 == "Hello")
            {
                Console.WriteLine(myTuple.Item2);
            }
            if (myTuple.Item3 == true)
            {
                Console.WriteLine(myTuple.Item3);
            }
        }
    }
}
