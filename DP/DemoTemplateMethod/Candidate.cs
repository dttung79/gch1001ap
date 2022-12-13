using System;

namespace DemoTemplateMethod
{
    public class Candidate
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public Candidate(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, GPA: {2}", Name, Age, GPA);
        }
    }
}