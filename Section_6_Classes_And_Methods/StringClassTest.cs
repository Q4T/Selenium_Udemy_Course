using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6_Classes_And_Methods
{
    [TestClass]
    public class StringClassTest
    {
        /*
         * Lesson 73 the String class
         https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
         https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8

         Advanced concatenation by creating a string from an array of chars.
        */


        [TestMethod]
        public void UsingStringClass ()
        {
            string str = "Last Night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);

            int sub1 = str.Length;
            Console.WriteLine("The string str is of length " + sub1);
        }

        [TestMethod]
        public void Joining_Strings_Together()
        {
            //Advanced concatenation by creating a string from an array of chars.
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            string word = new string(chars);
            Console.WriteLine(word);

        }
    }
}
