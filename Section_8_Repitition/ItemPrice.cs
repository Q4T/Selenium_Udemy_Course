using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_8_Repitition
{
    class ItemPrice
    {
        decimal wholeSaleItemPrice;

        public ItemPrice(decimal wholeSalePrice)
        {
            WholeSaleItemPrice = wholeSalePrice;
        }

        //setters and getters
        public decimal WholeSaleItemPrice
        {
            get
            {
                return wholeSaleItemPrice;
            }
           
            set
            {
                if (value > 0)
                {
                    wholeSaleItemPrice = value;
                }
            }
        }

        public decimal CalcWholeSaleprice(decimal percentage)
        {
            decimal perc;
            decimal markUp;
            decimal totalRetailPrice;

            perc = percentage / 100M;
            markUp = perc * wholeSaleItemPrice;
            totalRetailPrice = wholeSaleItemPrice + markUp;

            return totalRetailPrice;
        }


    }
}
