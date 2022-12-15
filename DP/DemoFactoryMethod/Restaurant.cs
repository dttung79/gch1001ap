using System;

namespace DemoFactoryMethod
{
    public class Restaurant
    {
        private DailyBreakfastMenu menu;
        public void Open()
        {
            // get current day of week
            DayOfWeek day = DateTime.Now.DayOfWeek;
            // check if it is weekend or not
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                menu = new WeekendMenu();
            }
            else
            {
                menu = new NormalMenu();
            }
            Console.WriteLine("Today is {0}", day);
            Console.WriteLine("Opening the restaurant...");
        }
        public void WelcomCustomers()
        {
            while (true) // while there is new customer
            {
                Console.WriteLine("Welcome to the restaurant!");
                menu.ShowMenu();
                Console.WriteLine("Waiting for new customer ...");
                string c = Console.ReadLine();
                if (c == "q") break;
            }
        }
    }
}