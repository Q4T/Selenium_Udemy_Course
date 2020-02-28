using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6_Classes_And_Methods
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void LongConstructor()
        {
            //arrange
            Employee clsEmployee = new Employee(777,"Harry", "Hill","17th Feb 1968","Super smart guy","Testing",10000);

            //act
            string firstThenlast = clsEmployee.FirstName_LastName();
            string sortingName = clsEmployee.SortingName();
            Console.WriteLine(firstThenlast);
            Console.WriteLine(sortingName);

            //assert
            StringAssert.Equals(firstThenlast, "Harry Hill");
            StringAssert.Equals(sortingName, "Hill, Harry");
        }

        [TestMethod]
        public void ShorterConstructor()
        {
            Employee Emp = new Employee("Billy", "Bragg");

            string firstThenlast = Emp.FirstName_LastName();
            string sortingName = Emp.SortingName();
           
            Console.WriteLine(firstThenlast);
            Console.WriteLine(sortingName);

            //assert
            StringAssert.Equals(firstThenlast, "Billy Bragg");
            StringAssert.Equals(sortingName, "Bragg, Billy");
        }

    }
}
