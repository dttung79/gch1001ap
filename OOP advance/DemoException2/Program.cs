using System;

namespace DemoException2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = ReadInt("Enter a: ");
            int b = ReadInt("Enter b: ");
            int c = a / b;
            System.Console.WriteLine("Result: " + c);
        }

        public static int ReadInt(string prompt)
        {
            bool invalid = true;
            int n = 0;
            while (invalid)
            {
                try
                {
                    Console.Write(prompt);
                    n = int.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Invalid input. Try again.");
                }
            } 
            return n;    
        }
    }
}