using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_15_Csharp_Conclusion
{
    class SingleFamily : Housing
    {
        decimal rentAmount;
        int sizeInSqrFt;
        string numOfBedrooms;
        string numOfBathrooms;
        bool hasPorch;
        bool hasAccessToGarage;

        public SingleFamily(string theAddress, string typeOfConstr, string yrBuilt, decimal rentAmnt, int sqrtFt, string bedNum, string bathNum, bool porch, bool garage)
            : base(theAddress, typeOfConstr, yrBuilt)
        {
            RentAmount = rentAmnt;
            SizeInSqrFt = sqrtFt;
            NumOfBedrooms = bedNum;
            NumOfBathrooms = bathNum;
            HasPorch = porch;
            HasAccessToGarage = garage;
        }

         public decimal RentAmount
        {
            get
            {
                return rentAmount;
            }
            set
            {
                rentAmount = value;
            }
        }

        public int SizeInSqrFt 
        {
            get
            {
                return sizeInSqrFt;
            }
            set
            {
                sizeInSqrFt = value;
            }
        }

        public string NumOfBedrooms
        {
            get
            {
                return numOfBedrooms;
            }
            set
            {
                numOfBedrooms = value;
            }
        }

        public string NumOfBathrooms
        {
            get 
            { 
                return numOfBathrooms;
            }
            set
            {
                numOfBathrooms = value;
            }
        }

        public bool HasPorch
        {
            get
            {
                return hasPorch;
            }
            set
            {
                hasPorch = value;
            }
        }

        public bool HasAccessToGarage
        {
            get 
            {
                return hasAccessToGarage;
            }
            set
            {
                hasAccessToGarage = value;
            }
        }

        public override decimal ProjectedRentalAmt()
        {
            return RentAmount * 12;
           
        }

        public override string ToString()
        {
            return "rentAmount: " + rentAmount.ToString("c") +
            "\nSizeInSqrFt: " + SizeInSqrFt +
            "\nnumOfBedrooms: " + numOfBedrooms +
            "\nnumOfBathrooms: " + numOfBathrooms +
            "\nhasPorch: " + hasPorch +
            "\nhasAccesstoGarage: " + hasAccessToGarage +
            "\n " + base.ToString();
           
        }
    }
}
