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
        private string Description;
        private decimal unitPrice;
        private int quantityPurchased;

        // constructor
        public Receipt(int receiptNum, string dateOfPurch, int customerNum, string custFirstName, string custLastName, string custAddress, string custPhone, int itemNum, string Desc, decimal Price, int quantity)
        {
            receiptNum = ReceiptNumber;
        }

        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (receiptNumber > 0)
                {
                    receiptNumber = value;
                }
                else
                {
                    Console.WriteLine("incorrect value entered please enter > zero number");
                }
            }
        }
            




    }
    }
