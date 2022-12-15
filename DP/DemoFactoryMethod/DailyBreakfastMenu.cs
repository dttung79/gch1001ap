using System;

namespace DemoFactoryMethod
{
    public abstract class DailyBreakfastMenu
    {
        public void ShowMenu()
        {
            Breakfast bf = CreateBreakfast();
            bf.Show();
            string answer = Console.ReadLine();
            Console.WriteLine("Great choice! Please wait a moment.");
        } 
        protected abstract Breakfast CreateBreakfast();
    }
    public class NormalMenu : DailyBreakfastMenu
    {
        protected override Breakfast CreateBreakfast()
        {
            return new NormalBreakfast();
        }
    }
    public class WeekendMenu : DailyBreakfastMenu
    {
        protected override Breakfast CreateBreakfast()
        {
            return new WeekendBreakfast();
        }
    }
}