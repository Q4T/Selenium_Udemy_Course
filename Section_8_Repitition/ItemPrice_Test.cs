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

            //Console.WriteLine($"Mark Up \tNew Item Price");
            Console.WriteLine(string.Format("{0,10} {1,10}","Mark Up", "Item Cost"));
            for (decimal percent = 5; percent < 11; percent++)
            {
               // Console.WriteLine($"The new retail price is {itemP.CalcWholeSaleprice(percent).ToString("C2")}");
                // column 1 % markup    column 2 new price
                //Console.WriteLine($"Mark Up \tnew Item price");
                
                //Console.WriteLine($"     {percent}%\t\t    {itemP.CalcWholeSaleprice(percent).ToString("C2")}");
                Console.WriteLine("{0,12} {1,12}", percent, itemP.CalcWholeSaleprice(percent).ToString("C2"));



            }
            


        }


        [TestMethod]
        public void FormattingTest()
        {
            string itemName = "woof";
            int pricePerOunce = 4;

            //string headers = String.Format("{0,10} {1,10}", "Item name", "Item Cost");  // Original
            string headers = String.Format("{0,10} {1,10}", "Item name", "Item Cost");  // {string to display (0 = Item name),   how far along the row to display)

            string outputStringOne = String.Format("{0,10} {1,10}", itemName, pricePerOunce);
            Console.WriteLine(headers);
            Console.WriteLine(outputStringOne);

        }
    }
}
