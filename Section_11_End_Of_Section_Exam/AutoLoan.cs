using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_End_Of_Section_Exam
{
    class AutoLoan : Loan
    {
        /*private string carYearBuilt;
        private string carMake;
        private string carModel;
        private string carColour;*/
        private decimal adminFee = 1000;

        public AutoLoan(string loanNum, string firstName, string lastName, decimal intRate, decimal lAmount, int loanTerm,string yearBuilt,string make, string model, string colour)
            : base(loanNum, firstName, lastName, intRate, lAmount, loanTerm)
        {
            CarYearBuilt = yearBuilt;
            CarMake = make;
            CarModel = model;
            CarColour = colour;
        }

        public string CarYearBuilt
        {
            get; 
            set;
        }
        public string CarMake
        {
            get;set;
        }
        public string CarModel
        {
            get;set;
        }
        public string CarColour
        {
            get;set;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\ncarYearBuilt: " + CarYearBuilt +
                "\ncarMake: " + CarMake +
                "\ncarModel: " + CarModel +
                "\ncarColour: " + CarColour +
                "\nInterest Payment: " + CalculateInterest().ToString("c");
        }

        public override decimal CalculateInterest()
        {
           // decimal interestRatePermonth = (base.InterestRate / base.numOfPaymentsInMonths());
            decimal LoanAmountPlusFees = (base.LoanAmount + adminFee);
            decimal InterestPayments = InterestRate / (48 * LoanAmountPlusFees);     // we can reference InterestRate accessor from the base class as this is a derived class !!

            return InterestPayments;
            // int months = base.numOfPaymentsInMonths();
            // return (base.InterestRate / base.numOfPaymentsInMonths()) * (base.LoanAmount + adminFee);
        }

    }

}
