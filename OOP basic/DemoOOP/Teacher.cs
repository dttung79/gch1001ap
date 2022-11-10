using System;

namespace DemoOOP
{
    public class Teacher
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set 
            { 
                if (value == "") name = "John";
                else name = value; 
            }
        }
        // subject, age
        private string subject;
        public string Subject 
        {
            get { return subject; }
            set { subject = value; }
        }

        private int age;
        public int Age 
        {
            get { return age; }
            set 
            {
                if (value < 20) 
                {
                    System.Console.WriteLine("Invalid age. Default value will be used");
                    age = 20;
                }
                else age = value;
            }
        }
    
        public Teacher() // default constructor
        {
            Name = "";
            Age = 20;
            Subject = "Math";
        }
    
        public Teacher(string name, int age, string subject) // parameterized constructor
        {
            Name = name; // call set of property
            Age = age;
            Subject = subject;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine(name + ", " + age + ", " + subject);
        }
    }
}