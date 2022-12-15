using System;

namespace DemoFactoryMethod
{
    public abstract class Breakfast
    {
        public abstract void Show();        
    }

    public class NormalBreakfast : Breakfast
    {
        public override void Show()
        {
            Console.WriteLine("Normal Daily Breakfast");
            Console.WriteLine("Today we have: ");
            Console.WriteLine("1. Bread");
            Console.WriteLine("2. Eggs");
            Console.WriteLine("3. Coffee");
            Console.Write("What do you choose?: ");
        }
    }
    public class WeekendBreakfast : Breakfast
    {
        public override void Show()
        {
            Console.WriteLine("Weekend Breakfast");
            Console.WriteLine("Today we have: ");            
            Console.WriteLine("1. Pancakes");
            Console.WriteLine("2. Sausages");
            Console.WriteLine("3. Cake");
            Console.WriteLine("4. Coffee");
            Console.Write("What do you choose?: ");
        }
    }
}