using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Section_14_Advanced_CSharp_Topics
{
    [TestClass]
    public class Regex_Coding_Quiz
    {
        [TestMethod]
        public void TestFirstName()
        {
            string firstName = "woof";
            string pattern = @"^[a-zA-Z]+$";
            bool response = Regex.IsMatch(firstName, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation failed for first name");
            }

        }

        [TestMethod]
        public void TestAge()
        {
            int age = 50;
            String sAge = Convert.ToString(age);
            string pattern = @"^/d+$";
            bool response = Regex.IsMatch(sAge, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Error with validation of age");
            }
        }


    }
}
