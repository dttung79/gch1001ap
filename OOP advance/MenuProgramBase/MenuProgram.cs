using System;

namespace MenuProgramBase
{
    public abstract class MenuProgram
    {
        protected const int EXIT = 0;
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                Process(choice);
                
                running = choice != EXIT;
            }
        }  
        protected abstract void PrintMenu();
        protected abstract void Process(int choice);
        protected int GetChoice()
        {
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }  
    }
}