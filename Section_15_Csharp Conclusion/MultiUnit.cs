using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_15_Csharp_Conclusion
{
    class MultiUnit : Housing, IUnits
    {
        string complexName;
        int numberOfUnits;
        decimal rentAmountPerUnit;

        public MultiUnit(string theAddress, string typeOfConstr, string yrBuilt, string cmplxName, int numUnits, decimal rentPerUnit)
            :base(theAddress, typeOfConstr, yrBuilt)
        {
            ComplexName = cmplxName;
            RentAmountPerUnit = rentAmountPerUnit;
        }

        // accsessors
        public string ComplexName
        {
            get
            {
                return complexName;
            }
            set
            {
                complexName = value;
            }
        }

        public decimal RentAmountPerUnit 
        {
            get
            {
                return rentAmountPerUnit;
            }
            set
            {
                rentAmountPerUnit = value;
            }
        }

        public int GetNumUnits()
        {
            return 1;   // placeholder
        }

        public override decimal ProjectedRentalAmt()
        {
            // (rent amount per unit * num of units) * 12
            return base.ProjectedRentalAmt();
        }

        public override string ToString()
        {
            return "ComplexName: " + ComplexName +
            "\nNumber of units: " + GetNumUnits() +
            "\nrentAmountPerUnit: " + RentAmountPerUnit;

        }

    }
}
