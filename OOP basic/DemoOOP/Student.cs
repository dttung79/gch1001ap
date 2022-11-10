using System;

namespace DemoOOP
{
    public class Student // Name: start by capital
    {
        // attributes
        private string name;
        public int age;

        private float grade;  // attribute
        // property
        public float Grade 
        {
            get { return grade; }
            set 
            {
                if (value < 0) grade = 0;
                else if (value > 10) grade = 10;
                else grade = value;
            }
        }

        public string Mobile
        {
            get; set;
        }

        // constructors
        public Student()
        {
            System.Console.WriteLine("Call to default constructor");
            name = "Nguyen Van A";
            age = 18;
        }

        // methods
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            if (name == "") name = "Nguyen Van A";
            this.name = name;
        }


    }
}