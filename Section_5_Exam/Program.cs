using System;

namespace Section_5_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            //Passes
            string DivBy4Fail = "Divisible by 4: No";
            string DivBy100Fail = "Divisible by 100: No";
            string DivBy400Fail = "Divisible by 400: No";
            string LeapyearNo = "Leap year: No";
            // Fails
            string DivBy4Pass = "Divisible by 4: Yes";
            string DivBy100Pass = "Divisible by 100: Yes";
            string DivBy400Pass = "Divisible by 400: Yes";
            string Leapyearyes = "Leap year: Yes";

            // ask for a year and capture
            Console.WriteLine("Enter a year");
            year = Convert.ToInt32(Console.ReadLine());
                
            // If the year divisible by 4   
            if (year % 4 == 0 && year % 100 ==0 && year % 400 == 0) // **** PASS
            {
                Console.WriteLine("Year Entered: " + year);
                Console.WriteLine(DivBy4Pass);
                Console.WriteLine(DivBy100Pass);
                Console.WriteLine(DivBy400Pass);
                Console.WriteLine(Leapyearyes);
            }
            //Else if it divisible by 4 and 100 but not 400 then its not a leap year 
            else if (year % 4 == 0 && year % 100 == 0 && year % 400 != 0) //  **** PASS
            {
                // write to console divisble by 4 AND 100 TRUE BUT NOT 400
                Console.WriteLine("Year Entered: " + year);
                Console.WriteLine(DivBy4Pass);
                Console.WriteLine(DivBy100Pass);
                Console.WriteLine(DivBy400Fail);
                Console.WriteLine(LeapyearNo);
            }
            // else if divisible by 4 but not 100 and not 400 then
            // PASS
            else if (year % 4 == 0 && year % 100 != 0 && year % 400 != 0) //  **** PASS
            {
                Console.WriteLine("Year Entered: " + year);
                Console.WriteLine(DivBy4Pass);
                Console.WriteLine(DivBy100Fail);
                Console.WriteLine(DivBy400Fail);
                Console.WriteLine(Leapyearyes);
            }
            else   //  **** PASS
            {
                Console.WriteLine("Year Entered: " + year);
                Console.WriteLine(DivBy4Fail);
                Console.WriteLine(DivBy100Fail);
                Console.WriteLine(DivBy400Fail);
                Console.WriteLine(LeapyearNo);
            }

        }
           
    }
}
