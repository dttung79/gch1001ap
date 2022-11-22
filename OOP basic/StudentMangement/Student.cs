using System;

namespace StudentMangement
{
    public class Student
    {
        // attributes: name, age, grade
        private string name;
        private int age;
        private int grade;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age 
        {
            get { return age; }
            set
            {
                if (value < 18) age = 18;
                else age = value;
            }
        }
        public int Grade 
        {
            get { return grade; }
            set { grade = value; }
        }
        private static int count = 0;

        // ID base count
        private int id;
        public int ID 
        {
            get { return id; }
        }

        // default constructor
        public Student () 
        {
            Name = " Quan";
            Age = 19;
            Grade = 1;
            id = ++count;
        }

        // parameter constructor
        public Student (string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
            id = ++count;
        }

        // show info
        public void ShowInfo()
        {
            System.Console.WriteLine("ID: " + id);
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Age: " + age);
            System.Console.WriteLine("Grade: " + grade);
        }

    }
}