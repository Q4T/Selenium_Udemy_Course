using System;

/* **********************************************************************************************************************
 * Location: C:\Users\EvansG\source\repos\Udemy_Course
 * 
 * Make sure that you set the Console App as a Startup Project.
 * Just right click on your project and select Set As Startup Project. 
 * Your project name will become bold
 * This is critical for a Console App project that runs with 
 * F5 keyboard shortcut so that the compiler knows where to enter the program. 
 *
*************************************************************************************************************************/

namespace ConsoleAppFormattingText
{
    class AppFormatting
    {
        static void Main(string[] args)
        {
            double pricePerOunce = 17.36;
            string outputString, headers, outputStringOne;
            string itemName = "Widget";

            //format output
            outputString = String.Format("The current price is {0:C}", pricePerOunce);

            headers = String.Format("{0,10} {1,10}", "Item name", "Item Cost");
            outputStringOne = String.Format("{0,10} {1,10}", itemName, pricePerOunce);

            //output
            Console.WriteLine(outputString);

            Console.WriteLine(headers);
            Console.WriteLine(outputStringOne);


            // escaping chars
            // the @ sign makes the string a literal
            string file = @"C:\Automation\Results";
            // if you want a carriage return though then us the following
            string file1 = "This is text on one line \nand this is on the next";
            string file2 = "C:\\Autom\nation\\Results";
            Console.WriteLine(file);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(file1);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(file2);
            Console.WriteLine("------------------------------------------------");

            /****************************************************************************************************** 
            Lesson 35. Declaring vars of simple types
            Lesson 36. Formatting and concatenation
            Lesson 37. String interpolation 
            *******************************************/

            // ask for a number
            int numberRead;
            string userFirstName;
            string age;
            string response;
            string response1;

            // ask for a number
            Console.WriteLine("Enter a number");
            numberRead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Number you selected is " + numberRead);

            //ask name and age
            Console.WriteLine("Enter first name");
            userFirstName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age = Console.ReadLine();

            response = "Your name is " + userFirstName + " and you are " + age + " years old";
            response1 = $"Your name is {userFirstName} and you are {age} years old";

            // write out a response
            Console.WriteLine(response);
            Console.WriteLine(response1);


        }
    }
}
