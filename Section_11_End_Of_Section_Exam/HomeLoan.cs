using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_End_Of_Section_Exam
{
    class HomeLoan : Loan
    {
       /* private string propertyAddress;
        private string propertyYearBuilt;
        private decimal squareFootage;      These are not required as we are using auto accessors  */
        private decimal adminFee = 5000;

        public HomeLoan(string loanNum, string firstName, string lastName, decimal intRate, decimal lAmount, int loanTerm, string address, string yearBuilt, double sqrFoot)
           : base(loanNum, firstName, lastName, intRate, lAmount, loanTerm)
        {
            PropertyAddress = address;
            PropertyYearBuilt = yearBuilt;
            SqaureFootage = sqrFoot;
        }

        public string PropertyAddress
        {
            get; set;
        }
        public string PropertyYearBuilt
        {
            get;set;
        }
        public double SqaureFootage
        {
            get;set;
        }

        public override string ToString()
        {
            return base.ToString() +
            "\npropertyAddress: " + PropertyAddress +
            "\nPropertyYearBuilt: " + PropertyYearBuilt +
            "\nSqaureFootage: " + SqaureFootage +
            "\nInterest Payment: " + CalculateInterest().ToString("c");
        }

        public override decimal CalculateInterest()
        {
            // int months = base.numOfPaymentsInMonths();

            return (base.InterestRate / base.numOfPaymentsInMonths()) * (base.LoanAmount + adminFee);
        }
    }
}

