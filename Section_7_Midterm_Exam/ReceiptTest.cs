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
            Receipt Rec = new Receipt(100, "01/01/2010",1,"Wilf","Winkerly","4 google st","07937 5567 8656",777,"Waffle Iron", 45.78M,1);
            Assert.AreEqual(Rec.ReceiptNumber, 100);
        }
       
        [TestMethod]
        public void ReceiptNumberLessThanZero()
        {
            Receipt Rec = new Receipt(-1, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(Rec.ReceiptNumber, -1);
        }
        
        [TestMethod]
        public void CustomerNumberGreaterThanZero()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreEqual(Rec.CustomerNumber, 1);
        }

        [TestMethod]
        public void CustomerNumberLessThanZero()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", -1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(Rec.CustomerNumber, -1);
        }
        
        [TestMethod]
        public void ItemNumberValid()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 777, "Waffle Iron", 45.78M, 1);
            Assert.AreEqual(Rec.ItemNumber, 777);
        }
        
        [TestMethod]
        public void ItemNumberInvalidLessThanZero()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", -1, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(Rec.ItemNumber, -1);
        }
       
        [TestMethod]
        public void ItemNumberInvalidgreaterThanNines()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 10000, "Waffle Iron", 45.78M, 1);
            Assert.AreNotEqual(Rec.ItemNumber, 10000);
        }
       
        [TestMethod]
        public void UnitPriceValid()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 45.34M, 1);
            Assert.AreEqual(Rec.UnitPrice, 45.34);
        }
        
        [TestMethod]
        public void UnitPriceInvalidValid()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", -0.01M, 1);
            Assert.AreNotEqual(Rec.UnitPrice, -0.01);
            Receipt Rec1 = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 10000M, 1);
            Assert.AreNotEqual(Rec1.UnitPrice, 10000);
        }
       
        [TestMethod]
        public void QuantityPurchasedValid()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 6.78M, 4);
            Assert.AreEqual(Rec.QuantityPurchased,4);
        }

        [TestMethod]
        public void QuantityPurchasedInValid()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 6.78M, 0);
            Assert.AreNotEqual(Rec.QuantityPurchased,0);
        }

        [TestMethod]
        public void TotalCostTest()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 10M, 2);
            decimal cost = Rec.TotalCost();
            Assert.AreEqual(cost, 20);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Receipt Rec = new Receipt(100, "01/01/2010", 1, "Wilf", "Winkerly", "4 google st", "07937 5567 8656", 666, "Waffle Iron", 10M, 2);
            Assert.AreEqual(Rec.TotalCost(), 20);
        }
    }
}
