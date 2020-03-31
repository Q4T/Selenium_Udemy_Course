using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_Advanced_OO_Topics
{
    class Lecture : Ticket
    {
        private string proffessorLecturer;

        // constructor - we pass in all the required members for the base class and this dervied class
        public Lecture(string seatNum, string row, DateTime date, string time, string venue, string title, decimal cost, string lecturer)
            :base(seatNum, row, date, time, venue, title, cost)
        {
            proffessorLecturer = lecturer;
        }

        
        public string GetLecturer()
        {
            return proffessorLecturer;
        }

        public override string ToString()
        {
            return base.ToString() +
              "\nLecturer: " + GetLecturer();

            /*                  return "Desitnation is: " + destination +
              "\nDistance Traveled is:  " + distanceTraveled + " miles" +
              "\nPetrol cost is: " + totalCostofPetrol.ToString("c") +
              "\nGallons used is: " + numOfGallonsConsumed.ToString("f1") + " gallons" +
              "\nMPG is: " + CalcMilesPerGallon().ToString("f2") +
              "\nCost Per Mile is: " + CostPerMile().ToString("c");*/

        }
    }
}
