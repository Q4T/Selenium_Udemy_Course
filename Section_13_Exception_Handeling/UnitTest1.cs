using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_13_Exception_Handeling
{
    [TestClass]
    public class ExceptionHelper
    {
        // List of exceptions: https://docs.microsoft.com/en-us/dotnet/api/system.systemexception?redirectedfrom=MSDN&view=netframework-4.8

        public static void DivisionTest()
        {
            try
            {
                int total = 100;
                int countScores = 0;

                double ave = total / countScores;
            }
            catch (Exception ex) // can have multiple catch
            {

                Console.WriteLine(ex.Message);
            }
            finally // optional. Anything in here will always get executed
            {
                Console.WriteLine("Woof at the end even without an exception");
            }
        }
              
        [TestMethod]
        public void TestMethod1()
        {
            DivisionTest();
        }

        [TestMethod]
        public void CheckStateTest()
        {
            try
            {
                CheckStateOK("ma");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string state;

        public static void CheckStateOK(string st)
        {
            switch (st.ToUpper()) 
            {
                case "FL":
                case "CA":
                    state = st.ToUpper();
                    break;
                default:
                    Exception ex = new Exception("State not part" + (" of Alantic ICW"));  // we can create our own exceptions.
                    throw ex;
                    
            }

        }

        // find 3 exceptions 
        // Maths exception
        // Format exception
        // Exception (base exception)
        // use 1 try block only.


        [TestMethod]
        public void BodyMassCalcTest()
        {
            string weight = "150"; //150
            string heightInFeet = "6";  //6
            string heightInInches = "72";   //72
            BodyMassIndexCalculator bmi = null;
            
            try
            {
                // create instance of class
                bmi = new BodyMassIndexCalculator(int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches)); 

                // good practice to put try catch around only the bit that might fail
                // so I moved string result = bmi.ToString();
                // & Assert.AreEqual("BMI: 5.09", result); outside of it.
            }
            catch (ArithmeticException aex)
            {
                Console.WriteLine("Arithmetic Problem " + aex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Format exception " + fex.Message);
            }  
            catch (Exception ex)
            {
                Console.WriteLine("exception" + ex.Message);
            }


            try
            {
                string result = bmi.ToString();
                Assert.AreEqual("BMI: 5.09", result);
            }
            catch (NullReferenceException nRef)   // best practice is to NOT explicitely catch this but let the compiler (clr) do it. Same for StackOverflow. 
            {
                Console.WriteLine("Null ref exception: " + nRef.Message);
                
            }



        }
    }
}
