using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_9_Methods
{
    /*
     * Lesson 98 method call stack
     * Creating an instance of a class from within the same class i.e MethodsCallStack
     * 
     * Lesson 99 Static methods - methods you want to access without having to instantiate an object from the class
     * A static method belongs to a class, rather than an object of a class
     * Static methods can be used as helper methods where you don't need to instantiate an object
     * The Math class is a good example of this where you can call methods without instantiating a math object
     * 
     * Lesson 100 Method overloading
     * https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/member-overloading
     * 
     */
    [TestClass]
    public class MethodsCallStack
    {
        [TestMethod]
        public void TestSquare()
        {
            MethodsCallStack method = new MethodsCallStack();
           int val = method.Square(10);
            Assert.AreEqual(val, 100); 
        }

        public int Square(int val)
        {
            return val * val;
        }

        [TestMethod]
        public void testStaticSquare()
        {
            int result = MathHelper.Square(6);
            Assert.AreEqual(result, 36);
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

        public override bool Equals(object obj)
        {
            bool whatever  = true;
            return whatever;
        }
    }
}
