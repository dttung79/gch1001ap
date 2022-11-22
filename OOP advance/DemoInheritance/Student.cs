using System;

namespace DemoInheritance
{
    public class Student : Person
    {
        public Student()
        {
            System.Console.WriteLine("Default constructor of Student");
        }
        public Student(string name, int age) : base(name, age)
        {
            System.Console.WriteLine("Parameter constructor of Student");
        }
    }
}