using System;
using System.Collections.Generic;
using MenuProgramBase;

namespace CustomerManagement
{
    public class CustomerProgram : MenuProgram
    {
        private List<Customer> customers;
        public CustomerProgram()
        {
            customers = new List<Customer>();
        }

        protected override void PrintMenu()
        {
            Console.WriteLine("1. Add PPV customer");
            Console.WriteLine("2. Add subcribe customer");
            Console.WriteLine("3. Print bills");
            Console.WriteLine("0. Exit");
        }
        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddPPVCustomer(); break;
                case 2: AddSubcribeCustomer(); break;
                case 3: PrintBills(); break;
                case 0: break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
        private void AddPPVCustomer()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter number of movies: ");
            int movies = int.Parse(Console.ReadLine());
            customers.Add(new PPVCustomer(name, email, movies));
        }
        private void AddSubcribeCustomer()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter subcription type (0: monthly, 1: yearly): ");
            int subType = int.Parse(Console.ReadLine());
            customers.Add(new SubcribeCustomer(name, email, subType));
        }
        private void PrintBills()
        {
            foreach (Customer c in customers)
            {
                c.ShowInfo();
                Console.WriteLine("Payment: " + c.GetPayment());
                Console.WriteLine("---------------------------");
            }
        }
    }
}