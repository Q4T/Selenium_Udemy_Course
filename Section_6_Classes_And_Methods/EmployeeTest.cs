using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6_Classes_And_Methods
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void LongConstructor_FirstThenLast()
        {
            //arrange
            Employee clsEmployee = new Employee(777,"Harry", "Hill","17th Feb 1968","Super smart guy","Testing",10000);
            //act
            string firstThenlast = clsEmployee.FirstName_LastName();
            Console.WriteLine(firstThenlast);
            //assert
            StringAssert.Equals(firstThenlast, "Harry Hill");
        }

        [TestMethod]
        public void LongConstructor_NamesForSorting()
        {
            Employee clsEmployee = new Employee(777, "Harry", "Hill", "17th Feb 1968", "Super smart guy", "Testing", 10000);
            string sortingName = clsEmployee.SortingName();
            Console.WriteLine(sortingName);
            StringAssert.Equals(sortingName, "Hill, Harry");
        }


        [TestMethod]
        public void ShorterConstructor()
        {
            Employee Emp = new Employee("Billy", "Bragg");
            string firstThenlast = Emp.FirstName_LastName();
            Console.WriteLine(firstThenlast);
            StringAssert.Equals(firstThenlast, "Billy Bragg");
        }

        [TestMethod]
        public void ShorterConstructor_NamesForSorting()
        {
            Employee Emp = new Employee("Billy", "Bragg");
            string sortingName = Emp.SortingName();
            StringAssert.Equals(sortingName, "Bragg, Billy");
        }





    }
}
