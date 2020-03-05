using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_7_Midterm_Exam
{
    [TestClass]
    public class ReceiptTest
    {
        /*
         * test for 
         * ReceiptNumber >0 - done
         * CustomerNumber > 0
         * ItemNumber >0 < 9999
         * UnitPrice >0 < 9999
         * QuantityPurchased >0
         * 
         */
        [TestMethod]
        public void ReceiptNumberGreaterThanZero()
        {   // Receipt(int receiptNum, string dateOfPurch, int customerNum, string custFirstName, string custLastName, string custAddress, string custPhone, int itemNum, string desc, decimal price, int quantity)
            Receipt rec = new Receipt(100, "01/01/2010",1,"Wilf","Winkerly","4 google st","07937 5567 8656",777,"Waffle Iron", 45.78M,1);
            Assert.AreEqual(rec.ReceiptNumber, 100);
        }
       
        [TestMethod]
        public void ReceiptNumberLessThanZero()
        {
            Receipt rec = new Receipt(-1, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(rec.ReceiptNumber, -1);
        }
        
        [TestMethod]
        public void CustomerNumberGreaterThanZero()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreEqual(rec.CustomerNumber, 1);
        }

        [TestMethod]
        public void CustomerNumberLessThanZero()
        {
            Receipt rec = new Receipt(100, "01/01/2010", -1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(rec.CustomerNumber, -1);
        }
        
        [TestMethod]
        public void ItemNumberValid()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreEqual(rec.ItemNumber, 777);
        }
        
        [TestMethod]
        public void ItemNumberInvalidLessThanZero()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", -1, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(rec.ItemNumber, -1);
        }
       
        [TestMethod]
        public void ItemNumberInvalidgreaterThanNines()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 10000, "Waffle Iron", 45.78M, 1);
            Assert.AreEqual(rec.ItemNumber, 0);
        }
       
        [TestMethod]
        public void UnitPriceValid()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 45.34M, 1);
            Assert.AreEqual(rec.UnitPrice, 45.34M);
        }
        
        [TestMethod]
        public void UnitPriceInvalidValid()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", -0.01M, 1);
            Assert.AreEqual(rec.UnitPrice,0);
            Receipt rec1 = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 10000M, 1);
            Assert.AreEqual(rec1.UnitPrice, 0);
        }
       
        [TestMethod]
        public void QuantityPurchasedValid()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 6.78M, 4);
            Assert.AreEqual(rec.QuantityPurchased,4);
        }

        [TestMethod]
        public void QuantityPurchasedInValid()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 6.78M, 0);
            Assert.AreEqual(rec.QuantityPurchased,0);
        }

        [TestMethod]
        public void TotalCostTest()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 10M, 2);
            Assert.AreEqual(rec.TotalCost(), 20M);
        }

        [TestMethod]
        public void DisplayTest()
        {
            Receipt rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 10M, 2);
            Console.WriteLine(rec);
            Console.WriteLine(rec.TotalCost());
        }
    }
}
