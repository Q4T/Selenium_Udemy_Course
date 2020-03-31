using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_Advanced_OO_Topics
{
    class Play : Ticket
    {
        private string playAuthor;
        private string theatreCompany;

        // constructor - we pass in all the required members for the base class and this dervied class
        public Play(string seatNum, string row, DateTime date, string time, string venue, string title, decimal cost, string author,string company)
            : base(seatNum, row, date, time, venue, title, cost)
        {
            playAuthor = author;
            theatreCompany = company;
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
        public string GetPlayAuthor()
        {
            return playAuthor;
        }
        public string GetTheatreCompany()
        {
            return theatreCompany;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nAuthor: " + GetPlayAuthor()+
                "\nTheatre Company: " + GetTheatreCompany();
        }
    }
}
