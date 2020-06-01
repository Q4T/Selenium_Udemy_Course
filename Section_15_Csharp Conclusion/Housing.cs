using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_15_Csharp_Conclusion
{
    class Housing
    {
        private string address;
        private string typeOfConstruction;
        private string yearBuilt;
    
    public virtual decimal ProjectedRentalAmt()
        {
            return 0;
        }
        public override string ToString()
        {
            // return base.ToString();
            return "Address: " + address +
            "\nType of Construction: " + typeOfConstruction +
            "\nYear Built: " + yearBuilt + 
            "\nProjected Rental Amount: " + ProjectedRentalAmt().ToString("c"); 
        }

    }
}
