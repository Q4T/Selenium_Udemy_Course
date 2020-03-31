using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_Advanced_OO_Topics
{
    class Musical : Ticket
    {
        private string musicCompany;

        // constructor - we pass in all the required members for the base class and this dervied class
        public Musical(string seatNum, string row, DateTime date, string time, string venue, string title, decimal cost, string company)
            : base(seatNum, row, date, time, venue, title, cost)
        {
            musicCompany = company;
        }

        public string GetSeatNum()
        {
            return base.seatNumber;
        }
        public string GetRow()
        {
            return base.seatRow;
        }
        public DateTime GetDate()
        {
            return base.dateOfEvent;
        }
        public string GetTime()
        {
            return base.startTime;
        }
        public string GetVenue()
        {
            return base.VenueLocation;
        }
        public string GetTitle()
        {
            return base.eventTitle;
        }
        public decimal GetTicketCost()
        {
            return base.ticketCost;
        }
        public string GetMusicCompany()
        {
            return musicCompany;
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nMusic Company: " + GetMusicCompany();

          /*                  return "Desitnation is: " + destination +
            "\nDistance Traveled is:  " + distanceTraveled + " miles" +
            "\nPetrol cost is: " + totalCostofPetrol.ToString("c") +
            "\nGallons used is: " + numOfGallonsConsumed.ToString("f1") + " gallons" +
            "\nMPG is: " + CalcMilesPerGallon().ToString("f2") +
            "\nCost Per Mile is: " + CostPerMile().ToString("c");*/

        }


    }
}
