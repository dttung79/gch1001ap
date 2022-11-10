using System;

namespace TicketOOP
{
    public class Customer
    {
        public bool VIP { get; set; }
        public Ticket MyTicket { get; set; }

        public Customer()
        {
            MyTicket = new Ticket();
        }

        public int GetMovieChoice()
        {
            // ask user to enter a choice (1, 2, 3, ..)
            // then return choice
        }

        public int GetNumberOfTickets()
        {
            // ask user to enter number of tickets
            // return number
        }

        public string GetSeats(int nTickets)
        {
            // use for loop to ask user enter seats, concat seat to a string
            // return seats string
        }

        public void SetVIP()
        {
            // ask user if user wants to be VIP or not
            // set VIP property
        } 

    }
}