using System;

namespace ProductManagement
{
    public class InventoryProgram
    {
        private Inventory myInventory;

        public InventoryProgram()
        {
            myInventory = new Inventory();
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                running = Process(choice);
            }
        }
        private bool Process(int choice)
        {
            // based on choice, call corresponding method of Inventory
            bool running = true;
            switch (choice)
            {
                case 1: myInventory.Import();       break;
                case 2: myInventory.Export();       break;
                case 3: myInventory.ShowProducts(); break;
                case 0: running = false;            break;
                default: System.Console.WriteLine("Invalid choice!"); break;
            }
            return running;
        }
        private int GetChoice()
        {
            // ask user to enter a choice
            System.Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        private void PrintMenu()
        {
            System.Console.WriteLine("1. Import product");
            System.Console.WriteLine("2. Exprot product");
            System.Console.WriteLine("3. Show all product");
            System.Console.WriteLine("0. Exit");
        }
    }
}