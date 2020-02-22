using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{
    [TestClass]
    public class SectionExamAsUnitTest
    {
        [TestMethod]
        public void LeapYearTest_2018()
        {
            string result = isLeapYear(2018);
            StringAssert.Equals(result, "No");
        }

        [TestMethod]
        public void LeapYearTest_2020()
        {
            string result = isLeapYear(4);
            StringAssert.Equals(result, "Yes");
        }

        // method that tests the year
        public string isLeapYear(int givenYear)
        {
            int nYear;
            int nFour;
            int nOneH;
            int nFourH;
            int nEven;
            string sFour;
            string sFourH;
            string sOneH;

            // what is the year?
            nYear = givenYear;

            // check year to see if divisible by 4, 100 & 400 and return yes or no 
            // and assign a string variable with a message to write to console.
            // 
            // so this should be multiple methods really
            //  WriteToConsoleDivisibleBy   to check divisability and assign a string to output like Divisible by 400: Yes
            //  
            

            nFourH = nYear % 400;
            if (nFourH == 0)
            {
                sFourH = "Divisible by 400: Yes";
            }
            else
            {
                sFourH = "Divisible by 400: No";
            }

            nFour = nYear % 4;
            if (nFour == 0)
            {
                sFour = "Divisible by 4: Yes";
            }
            else
            {
                sFour = "Divisible by 4: No";
            }

            nOneH = nYear % 100;
            if (nOneH == 0)
            {
                sOneH = "Divisible by 100: Yes";
            }
            else
            {
                sOneH = "Divisible by 100: No";
            }

            nEven = nYear % 2;

            // write out lines to console
            Console.WriteLine("Year is: " + nYear);
            Console.WriteLine(sFourH);
            Console.WriteLine(sOneH);
            Console.WriteLine(sFour);

            // determine if leap year
            if ((nEven == 0) && (nFour == 0) && (nOneH == 0) && (nFourH == 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nOneH != 0) && (nFourH != 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((nEven == 0) && (nFour == 0) && (nOneH == 0) && (nFourH != 0))
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else if ((nEven == 0) && (nFour != 0) && (nOneH != 0) && (nFourH != 0))
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else if (nEven != 0)
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }
             return "No";
        }
    }
}
            
            
            



