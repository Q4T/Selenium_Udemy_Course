using System;

namespace Section_10_Quiz
{
    class ValidateAndDisplayInput
    {

        static void Main(string[] args)
        {
            int[] entries = new int[11];
            int cntInvalidEntries = 0;
            int cntNumberOutsideRange = 0;

            PrimeArray (entries);
            cntInvalidEntries = GetValues(entries, ref cntNumberOutsideRange);
            DisplayResults(entries, cntInvalidEntries, cntNumberOutsideRange);
            Console.ReadKey();
        }

        public static void DisplayResults( int[] entries, int cntInvalidEntries, int cntNumberOutsideRange)
        {
         
            int cntOfValidalidEntries = 0;
            Console.Clear();
            Console.WriteLine("\tInput Data App\n");
            Console.WriteLine("{0,-12}{1,-6}", "Input Value", "Count");

            for (int x = 0; x < 11; x++)
            {
                if (entries[x] != 0)
                {
                    cntOfValidalidEntries += entries[x];
                    Console.WriteLine("{0,5}{1,10}", x, entries[x]);
                }
            }
            Console.WriteLine("\nNumber of valid entries: {0}", cntOfValidalidEntries );
            Console.WriteLine("\nNumber of entries outside range: {0}", cntNumberOutsideRange);
            Console.WriteLine("\nNumber of Non-Numeric entries: {0}", cntInvalidEntries);
            Console.WriteLine("\nTotal Number of inputs: {0}", cntOfValidalidEntries + cntNumberOutsideRange + cntInvalidEntries);
        }

        public static void PrimeArray (int[] entries)
        {
            // initialise array with 0. The elements of an int array will equal zeros already, so this is just done as it's good practice.
            for (int i = 0; i < 11; i++)
            {
                entries[i] = 0;
            }
        }

        public static int GetValues(int[] entries, ref int cntNumberOutsideRange)
        {
            int inValue;
            string stringInput;
            bool moreInput = true;
            int cntInvalidEntries = 0;

            Console.Clear();
            while (moreInput)
            {
                Console.Write("\nInput a number between 0 - 10: Enter -1 to stop: ");
                stringInput = Console.ReadLine();

                // test to see if integer entered
                while (int.TryParse(stringInput, out inValue)==false)   // this checks to see if the input can be turned into an int
                {
                    Console.Write("\nInvalid data type - " +
                        " Input a number between 0 - 10: Enter -1 to stop ");
                    stringInput = Console.ReadLine();
                    cntInvalidEntries++;
                }

                if(inValue == -1)
                    moreInput = false;
                else if (inValue < -1 || inValue > 10)
                {
                    Console.Write("\nInvalid Number - Input a number between 0 - 10: Enter -1 to stop ");
                    cntNumberOutsideRange++;
                }
                else
                {   // this adds the value 1 (++ does this) and this is the count of how many times the number 7 was entered
                    // so entries[7] = 1;  so the array is capturing how many times a number was entered bu using the numbered enetered as the array index.
                    entries[inValue]++; // use array as an accumulator - adds one to the input value location
                }
            }
            return cntInvalidEntries;
        }















            // when acceptable values are entered capture ther value and keep a count of each acceptable entry into an array (count how many times a value is in the array and add1 to it if its >0)

        // when invalid integers values are entered add the sum of invalid integers into an array

        // when non-numeric values are entered add the sum of non-numeric into an array

        // output a list of distinct valid entries and a count of how many times they occured   in a tabular format with values number alligned

        // use data: 7 2 4 2 q  87 4 6  4 4 7
    


    }
}
