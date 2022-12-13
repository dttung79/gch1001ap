using System;

namespace DemoTemplateMethod
{
    public class DevEmployee : Employee
    {
        public string Language { get; set; }
        public DevEmployee(string name, int age, 
                    double salary, string language) : base(name, age, salary)
        {
            Language = language;
        }
        public override string ToString()
        {
            return string.Format("Developer Name: {0}, Age: {1}, Salary: {2}, Language: {3}", 
                Name, Age, Salary, Language);
        }
    }
}