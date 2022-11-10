using System;


namespace DemoOOP
{
    public class Program
    {
        public static void Main()
        {
            // Student s1 = new Student();

            // Console.Write("Enter age: ");
            // s1.age = int.Parse(Console.ReadLine());
            // if (s1.age < 18) s1.age = 18;

            // System.Console.Write("Enter name: ");
            // s1.SetName(Console.ReadLine());

            // System.Console.Write("Enter grade: ");
            // s1.Grade = float.Parse(Console.ReadLine());

            // System.Console.Write("Enter mobile: ");
            // s1.Mobile = Console.ReadLine();

            // System.Console.WriteLine(s1.age + s1.GetName() + s1.Grade + s1.Mobile);

            Teacher t1 = new Teacher();
            Teacher t2 = new Teacher();
            t2.Name = "Paul";
            
            t1.ShowInfo();
            t2.ShowInfo();
        }
    }
}