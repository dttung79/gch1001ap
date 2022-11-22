using System;

namespace DemoInheritance
{
    public class Student : Person
    {
        public double Grade { get; set; }
        public Student()
        {
            Grade = 0;
            System.Console.WriteLine("Default constructor of Student");
        }
        public Student(string name, int age, double grade) : base(name, age)
        {
            Grade = grade;
            System.Console.WriteLine("Parameter constructor of Student");
        }

        public void Show(double grade)  // override method Show
        {
            base.Show();
            System.Console.WriteLine("Grade: " + grade);
        }
    }
}