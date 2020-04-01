using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_End_Of_Section_Exam
{
    abstract class Loan
    {
        private string loanNumber;
        private string customerFirstName;
        private string customerLastName;
        private decimal interestRate;    // teacher set to double
        private decimal loanAmount;
        private int numberOfYearsInLoanTerm;  // teacher set to double   and they are set to private!!! They can be private as long as you call the accessors 
                                             // (getters and setters and NOT the properties themselves

        public Loan(string loanNum, string firstName, string lastName, decimal intRate, decimal lAmount, int loanTerm)
        {
            LoanNumber = loanNum;
            CustomerFirstName = firstName;
            CustomerLastName = lastName;
            InterestRate = intRate;
            LoanAmount = lAmount;
            NumberOfYearsInLoanTerm = loanTerm;
        }

        public string LoanNumber
        {
            get
            {
                return loanNumber;
            }
            set
            {
                loanNumber = value;
            }
        }

        public string CustomerFirstName
        {
            get
            {
                return customerFirstName;
            }
            set
            {
                customerFirstName = value;
            }
        }
        public string CustomerLastName
        {
            get
            {
                return customerLastName;
            }
            set
            {
                customerLastName = value;
            }
        }
       
        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
        public decimal LoanAmount 
        {
            get
            {
                return loanAmount;
            }
            set
            {
                loanAmount = value;
            }
        }
       public int NumberOfYearsInLoanTerm
        {
            get
            {
                return numberOfYearsInLoanTerm;
            }
            set
            {
                numberOfYearsInLoanTerm = value;
            }
        }

        public decimal numOfPaymentsInMonths()
        {
            // get the modulous
            //  int monthsMod = NumberOfYearsInLoanTerm % 12;
            //  int integer = NumberOfYearsInLoanTerm / 12;
            decimal months = NumberOfYearsInLoanTerm * 12;
            return months;
        }

        public override string ToString()
        {
            // return base.ToString();
            return "loanNumber: " + LoanNumber +
                "\nCustomer First Name: " + CustomerFirstName +
                "\nCustomer Last Name: " + CustomerLastName +
                "\nInterest Rate: " + InterestRate.ToString("p2") +
                "\nLoan Amount: " + LoanAmount.ToString("c") +
                "\nLoan Term: " + NumberOfYearsInLoanTerm;
        }

        public abstract decimal CalculateInterest();





    }
}
