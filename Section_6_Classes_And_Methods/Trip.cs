using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Classes_And_Methods
{
    class Trip
    { 
        private string destination;
        private double distanceTraveled;
        private decimal totalCostofPetrol;
        private double numOfGallonsConsumed;

        public Trip(string dest, double distTraveled, decimal petrolCost, double gallonsUsed)
        {
            Destination = dest;
            DistanceTraveled = distTraveled;
            TotalCostofpetrol = petrolCost;
            GallonsUsed = gallonsUsed;
        }

        // setters & getters
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }


        }
        public double DistanceTraveled
        {
            get
            {
                return distanceTraveled;
            }
            set
            {
                distanceTraveled = value;
            }
        }
        public decimal TotalCostofpetrol
        {
            get
            {
                return totalCostofPetrol;
            }
            set
            {
                totalCostofPetrol = value;
            }
        }
        public double GallonsUsed
        {
            get
            {
                return numOfGallonsConsumed;

            }
            set
            {
                numOfGallonsConsumed = value;
            }
        }

        public double CalcMilesPerGallon()
        {
            // distance / gallons used
            //double calc = DistanceTraveled / GallonsUsed;
            return DistanceTraveled / GallonsUsed;

        }
        public decimal CostPerMile()
        {
            // fuel cost / miles
            return TotalCostofpetrol / Convert.ToDecimal(DistanceTraveled);
        }

        // override to-string
        public override string ToString()
        {
            // return base.ToString();
            return "Desitnation is: " + destination +
            "\nDistance Traveled is:  " + distanceTraveled + " miles" +
            "\nPetrol cost is: " + totalCostofPetrol.ToString("c") +
            "\nGallons used is: " + numOfGallonsConsumed.ToString("f1") + " gallons" +
            "\nMPG is: " + CalcMilesPerGallon().ToString("f2") +
            "\nCost Per Mile is: " + CostPerMile().ToString("c");

        }
    }
}
