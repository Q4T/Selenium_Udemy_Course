using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Section_14_Advanced_CSharp_Topics
{

    /*  Lesson 159 RegularExpressionsTest
     *  Need to add using System.Text.RegularExpressions; to use reg exes
     *  https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
     */
    [TestClass]
    public class RegularExpressionsTest
    {
        [TestMethod]
        public void MatchEmail()
        {
            string[] addresses = { "AAAAAAA@gmail.com", "AAAAAaaaaa@gmail.com" };
            string pattern = @"^[0-9A-Z]([-.\w]*[0-9A-Z])*$";
            // @ signifies a character literal which means we don't have to escape any chars

            bool response = false;
            foreach(var address in addresses)
            {
                response = IsEmail(address, pattern);
            }
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void MatchPhone()
        {
            string number = "555-555-555-5555";
            string patter = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            bool response = Regex.IsMatch(number, patter);
            Assert.IsTrue(response);

        }

        public static bool IsEmail(string email,string pattern)
        {
            if(email != null)
            {
                return Regex.IsMatch(email, pattern);
            }
            else return false;
        }

        




    }
}
