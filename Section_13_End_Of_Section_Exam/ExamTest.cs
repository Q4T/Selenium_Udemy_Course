using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_13_End_Of_Section_Exam
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void Test_Weekly_Wages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch (IndexOutOfRangeException eOutOfRange)
            {
                Console.WriteLine("Error in loop termination");
                Console.WriteLine("Exception caught: " + eOutOfRange.Message);
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException eFormat)
            {
                Console.WriteLine("Error in Format");
                Console.WriteLine("Exception caught: " + eFormat.Message);
            }
            
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch (DivideByZeroException eDivByZero)
            {
                Console.WriteLine("Arithmetic exception");
                Console.WriteLine("Exception caught: " + eDivByZero.Message);
            }
        }
    }
}
