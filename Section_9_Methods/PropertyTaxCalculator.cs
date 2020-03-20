using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9_Methods
{
    class PropertyTaxCalculator
    {
        private decimal millageRate = 10.03M;
        private decimal exemeption = 25000M;
        private decimal percentUplift = 0.027M;

        public PropertyTaxCalculator(string propertyAddress, decimal priorYearAssessedValue)
        {
            PropertyAddress = propertyAddress;
            PriorYearAssessedValue = priorYearAssessedValue;
        }

        public string PropertyAddress
        {
            get;
            set;
        }
        public decimal PriorYearAssessedValue
        {
            get; set;
        }

        public decimal PostPercentValue()   // step 1
        {  
            // calc 2.7% increase in value
            decimal postPercentValue = (PriorYearAssessedValue * percentUplift) + PriorYearAssessedValue;
            return postPercentValue;
        }

       public decimal PostExemptionValue() // step 2
        {
            decimal postPercentValue = PostPercentValue();
            // take off the exemption
            decimal postExemptionValue = postPercentValue - exemeption;
            return postExemptionValue;
        }

        public decimal CalcMillageRate() // 3
        {
            decimal postExemptionValue = PostExemptionValue();
            decimal perValue = 1000;
            return (millageRate / perValue) * postExemptionValue;
        }
 
        public decimal TaxableValue()
        {
            return CalcMillageRate() + PostExemptionValue();
        }

        public decimal CalcTax() // step 4
        {
            PostPercentValue();
            PostExemptionValue();
            decimal taxDue = CalcMillageRate();
            return taxDue;
        }

        public override string ToString()
        {
        /*   string priorYearAssessedValue = String.Format("{0:C}", PriorYearAssessedValue);
            string postPercentValue = String.Format("{0:C}", PostPercentValue());
            string postExemptionValue = String.Format("{0:C}", PostExemptionValue());
            string calcMillageRate = String.Format("{0:C}", CalcMillageRate());
            string calcTax = String.Format("{0:C}", CalcTax());
            */

            // String.Format("The current price is {0:C}", pricePerOunce);
            //            return "Property Address: " + PropertyAddress + "\nLast Year Assesed Value: " + priorYearAssessedValue + "\nCurrent Assessed Value: " + postPercentValue + "\nExemption: "
            //                + exemeption + "\nTaxable Value: " + postExemptionValue + "\nMillage rate: " + calcMillageRate + "\nTaxes Due: " + calcTax;

            return string.Format("Property Address:{0}\n" +
             "Last Year Assesed Value: {1:C}\n" +
             "Current Assessed Value: {2:C}\n" +
             "Exemption: {3:C}\n" +
             "Taxable Value: {4:C}\n" +
             "Millage Rate: {5:C}\n" +
             "Taxes Due: {6:C}", PropertyAddress, PriorYearAssessedValue, PostPercentValue(), exemeption, TaxableValue(), millageRate, CalcTax());
        }      
    }
}
