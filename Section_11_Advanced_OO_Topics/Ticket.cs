using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_11_Advanced_OO_Topics
{
    abstract class Ticket
    {
        protected string seatNumber;
        protected string seatRow;
        protected DateTime dateOfEvent;
        protected string startTime;
        protected string venueLocation;
        protected string eventTitle;
        protected decimal ticketCost;

        // constructor
        public Ticket(string seatNum, string row, DateTime date, string time, string venue, string title, decimal cost)
        {
            SeatNumber = seatNum;
            SeatRow = row;
            DateOfEvent = date;
            StartTime = time;
            VenueLocation = venue;
            EventTitle = title;
            TicketCost = cost;
        }


        public string SeatNumber
        {
            get
            {
                return seatNumber;
            }
            set
            {
                seatNumber =  value;
            }
        }
        public string SeatRow
        {
            get
            {
                return seatRow;
            }
            set
            {
                seatRow = value;
            }
        }

        public DateTime DateOfEvent
        {
            get
            {
                return dateOfEvent;
            }
            set
            {
                dateOfEvent = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public string VenueLocation
        {
            get
            {
                return venueLocation;
            }
            set 
            {
                venueLocation = value;
            }
        }

        public string EventTitle
        {
            get
            {
                return eventTitle;
            }
            set
            {
                eventTitle = value;
            }
        }

        public decimal TicketCost
        {
            get
            {
                return ticketCost;
            }
            set
            {
                ticketCost = value;
            }
        }

        public override string ToString()
        {
            return "Seat Number: " + seatNumber +
            "\nRow: " + seatRow +
             "\nDate: " + dateOfEvent +
            "\nTime: " + startTime +
            "\nVenue: " + venueLocation +
            "\nTitle: " + eventTitle +
            "\nCost: " + ticketCost.ToString("c");  
        }
    }
}
