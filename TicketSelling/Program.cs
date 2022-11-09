using System;

namespace TicketSelling
{
    class Program
    {
        static string[] movies = {"Black Adam", "Black Pather 2", "Detective Conan"};
        const int PRICE = 5;
        const double VIP_REDUCE = 0.1;
        static void Main(string[] args)
        {
            // Hiển thị 1 menu cho người dùng chọn 3 bộ phim
            PrintMovies(movies);
            // Người dùng chọn phim
            string movie = movies[GetMovie()];
            // Người dùng chọn số lượng vé
            int nTickets = GetNumOfTickets();
            // Người dùng chọn ghế
            string seats = GetSeats(nTickets);
            // Hỏi có phải VIP member không?
            bool VIP = IsVIPMember();
            // In ra vé và hoá đơn
            PrintTickets(movie, nTickets, seats);
            PrintInvoice(nTickets, VIP);
        }
        static void PrintMovies(string[] movies)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + movies[i]);
            }
        }
        static int GetMovie()
        {
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice - 1;
        }

        static int GetNumOfTickets()
        {
            Console.Write("How many tickets? ");
            int nTickets = int.Parse(Console.ReadLine());
            return nTickets;
        }

        static string GetSeats(int nTickets)
        {
            string seats = "";
            // use for loop to repeat nTickets time, asking a seat then add to a string
            for (int i = 0; i < nTickets; i++)
            {
                Console.Write("Choose your seat: ");
                string seat = Console.ReadLine();
                seats += seat + " ";           
            }
            return seats;
        }

        static bool IsVIPMember()
        {
            Console.Write("Are you a VIP member? (y/n): ");
            string answer = Console.ReadLine();
            return answer == "y";
        }

        static void PrintTickets(string movie, int nTickets, string seats)
        {
            Console.WriteLine("Movie: " + movie);
            Console.WriteLine("Number of tickets: " + nTickets);
            Console.WriteLine("Seats: " + seats);
        }

        static void PrintInvoice(int nTickets, bool VIP)
        {
            double payment = nTickets * PRICE;
            if (VIP) payment -= payment * VIP_REDUCE;

            Console.WriteLine("Payment: " + payment);
        }
    }
}
