using System;

namespace Section_10_Quiz
{
    class ValidateAndDisplayInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            string input = Console.ReadLine();
            int iInput = Convert.ToInt32(input);
           // Console.WriteLine("Value input is " + input);

            // test the input to see if they fall in a valid range (0 - 10 inclusive)
            if(iInput >= 0 || iInput <= 10)
            {
                // add it to an array
              
            }

            // when acceptable values are entered capture ther value and keep a count of each acceptable entry into an array (count how many times a value is in the array and add1 to it if its >0)

            // when invalid integers values are entered add the sum of invalid integers into an array

            // when non-numeric values are entered add the sum of non-numeric into an array

            // output a list of distinct valid entries and a count of how many times they occured   in a tabular format with values number alligned
            
            // use data: 7 2 4 2 q  87 4 6  4 4 7
        }
    }
}
