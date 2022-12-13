using System;

namespace DemoTemplateMethod
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Salary: {2}", Name, Age, Salary);
        }        
    }
}