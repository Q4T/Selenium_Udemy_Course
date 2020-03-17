using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{
    [TestClass]
    public class ItemPrice_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            ItemPrice itemP = new ItemPrice(10M);

            Console.WriteLine($"Mark Up \tNew Item Price");
            for (decimal percent = 5; percent < 11; percent++)
            {
               // Console.WriteLine($"The new retail price is {itemP.CalcWholeSaleprice(percent).ToString("C2")}");
                // column 1 % markup    column 2 new price
                //Console.WriteLine($"Mark Up \tnew Item price");
                Console.WriteLine($"     {percent}%\t\t    {itemP.CalcWholeSaleprice(percent).ToString("C2")}");
            }
            


        }
    }
}
