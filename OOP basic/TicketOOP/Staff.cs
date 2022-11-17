using System;

namespace TicketOOP
{
    public class Staff
    {
        private string[] movies = {"Black Adam", "Black Pather 2", "Detective Conan"};
        private const int TICKET_PRICE = 5;
        public void PrintMovies()
        {
            // print a menu of 3 movies
            System.Console.WriteLine("Movies List");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + movies[i]);
            }
        }

        public void PrintTicket(Ticket t)
        {
            // print ticket attributes (movie, seats, number)
            System.Console.WriteLine("Ticket Information: ");
            System.Console.WriteLine("Movie: " + t.Movie);
            System.Console.WriteLine("Seats: " + t.Seats);
            System.Console.WriteLine("Number of ticets: " + t.Number);

        }
        public void PrintInvoice(Customer c)
        {
            // calculate payment based customer's ticket & vip
            int payment = TICKET_PRICE * c.MyTicket.Number;
            System.Console.WriteLine("Payment: " + payment);
        }

        public void SellTickets()
        {
            bool selling = true;
            while (selling)
            {
                PrintMovies();

                Customer c = new Customer();
                int choice = c.GetMovieChoice(movies.Length);
                int nTickets = c.GetNumberOfTickets();
                string seats = c.GetSeats(nTickets);
                string movie = movies[choice];

                Ticket t = new Ticket(movie, seats, nTickets);
                
                PrintTicket(t);
                
                c.MyTicket = t;
                c.SetVIP();

                PrintInvoice(c);
            }
        }
        
    }
}