using System;

namespace TicketOOP
{
    public class Staff
    {
        private string[] movies = {"Black Adam", "Black Pather 2", "Detective Conan"};
        public void PrintMovies()
        {
            // print a menu of 3 movies
        }

        public void PrintTicket(Ticket t)
        {
            // print ticket attributes (movie, seats, number)
        }
        public void PrintInvoice(Customer c)
        {
            // calculate payment based customer's ticket & vip
        }

        public void SellTickets()
        {
            bool selling = true;
            while (selling)
            {
                PrintMovies();

                Customer c = new Customer();
                int choice = c.GetMovieChoice();
                int nTickets = c.GetNumberOfTickets();
                string seats = c.GetSeats();
                string movie = movies[choice];

                Ticket t = new Ticket(movie, seats, number);
                
                PrintTicket(t);
                
                c.MyTicket = t;
                c.SetVIP();

                PrintInvoice(c);

            }
        }
        
    }
}