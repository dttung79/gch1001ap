using System;

namespace TicketOOP
{
    public class Customer
    {
        private int MIN_NTICKET = 1;
        private int MAX_NTICKET = 5;
        public bool VIP { get; set; }
        public Ticket MyTicket { get; set; }

        public Customer()
        {
            MyTicket = new Ticket();
        }

        public int GetMovieChoice(int maxChoice)
        {
            // ask user to enter a choice (1, 2, 3, ..)
            // then return choice
            bool invalidChoice = true;
            int choice = 0;
            while (invalidChoice)
            {
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                invalidChoice = (choice < 1) || (choice > maxChoice);
                if (invalidChoice) System.Console.WriteLine("Invalid choice. Try again!");
            }
            
            return choice;
        }

        public int GetNumberOfTickets() // 1 - 5 tickets
        {
            // ask user to enter number of tickets
            // return number
            bool invalidNTickets = true;
            int nTickets = 0;
            while (invalidNTickets)
            {
                Console.Write("Enter number of tickets: ");
                nTickets = int.Parse(Console.ReadLine());
                invalidNTickets = (nTickets < MIN_NTICKET) || (nTickets) > MAX_NTICKET;
                if (invalidNTickets) 
                    System.Console.WriteLine("Number must be in [1, 5]. Try again.");
            }
            
            return nTickets;
        }

        public string GetSeats(int nTickets)
        {
            // use for loop to ask user enter seats, concat seat to a string
            // return seats string
            string seats = "";
            for (int i = 0; i < nTickets; i++)
            {
                Console.Write("Enter seat: ");
                string seat = Console.ReadLine();
                seats += seat;
            }
            return seats;
        }

        public void SetVIP()
        {
            // ask user if user wants to be VIP or not
            // set VIP property
            System.Console.Write("Are you a VIP member? y/n: ");
            string answer = System.Console.ReadLine();
            if (answer == "y") VIP = true;
            else               VIP = false;

        } 

    }
}