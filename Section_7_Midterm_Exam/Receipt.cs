using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7_Midterm_Exam
{
    class Receipt
    {
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerAddress;
        private string customerPhoneNUmber;
        private int itemNumber;
        private string description;
        private decimal unitPrice;
        private int quantityPurchased;
        private string errorMsg = "Incorrect Value, please enter > 0 < 9999";

        // constructor
        public Receipt(int receiptNum, string dateOfPurch, int customerNum, string custFirstName, string custLastName, string custAddress, string custPhone, int itemNum, string desc, decimal price, int quantity)
        {
            ReceiptNumber = receiptNum;
            DateOfPurchase = dateOfPurch;
            CustomerNumber = customerNum;
            CustomerFirstName = custFirstName;
            CustomerLastName = custLastName;
            CustomerAddress = custAddress;
            CustomerPhoneNumber = custPhone;
            ItemNumber = itemNum;
            Description = desc;
            UnitPrice = price;
            QuantityPurchased = quantity;
        }

        // getters & setters
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (value > 0)
                {
                    receiptNumber = value;
                }
                else
                {
                    Console.WriteLine("Incorrect value entered for receiptNumber, please enter > zero number");
                }
            }
        }
        public string DateOfPurchase
        {
            get;
            set;
        }

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
                else
                {
                    Console.WriteLine("Incorrect value entered for customerNumber, please enter > zero number");
                }
            }
        }
        public string CustomerFirstName
        {
            get;
            set;
        }
        public string CustomerLastName
        {
            get;
            set;
        }
        public string CustomerAddress
        {
            get;
            set;
        }
        public string CustomerPhoneNumber
        {
            get;
            set;
        }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
                else
                {
                    Console.WriteLine(errorMsg);
                }
            }
        }
        public string Description
        {
            get;set;
        }
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }
                else
                {
                    Console.WriteLine(errorMsg);
                }

            }
        }
        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                if (value > 0)
                {
                    quantityPurchased = value;
                }
                else
                {
                    Console.WriteLine("Error: Purchase value must be > 0");
                }
            }
        }

        // methods
        public decimal TotalCost()
        {
            return QuantityPurchased * UnitPrice;
        }

        public override string ToString()
        {
            return "Customer: " + CustomerFirstName + " " + CustomerLastName +
            "\nPhone: " + CustomerPhoneNumber +
            "\nTotal Purchases: " + TotalCost().ToString("c");
        }


    }
}
