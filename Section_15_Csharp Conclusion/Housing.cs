﻿using System;
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

        //constructor
        public Housing(string theAddress, string typeOfConstr, string yrBuilt)
        {
            Address = theAddress;     // should I be assigning the accessors to the passed in variables or should I assign the vars to the local vars instead?
            TypeOfConstruction = typeOfConstr;
            YearBuilt = yrBuilt;
        }


        // setters and getters - accessors
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string TypeOfConstruction 
        { 
            get 
            {
                return typeOfConstruction; 
            }
            set
            {
                typeOfConstruction = value;
            }
        }
       
        public string YearBuilt
        {
            get
            {
                return yearBuilt;
            }
            set
            {
                yearBuilt = value;
            }
        }


    public virtual decimal ProjectedRentalAmt()
        {
            return 0;
        }
        public override string ToString()
        {           
            return"Address: " + address +
            "\nType of Construction: " + typeOfConstruction +
            "\nYear Built: " + yearBuilt + 
            "\nProjected Rental Amount: " + ProjectedRentalAmt().ToString("c"); 
        }

    }
}
