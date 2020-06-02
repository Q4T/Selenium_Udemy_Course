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

        public int GetNumUnits()
        {
            return 1;   // placeholder
        }

        public override decimal ProjectedRentalAmt()
        {
            return base.ProjectedRentalAmt();
        }

    }
}
