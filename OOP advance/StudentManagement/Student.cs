using System;

namespace StudentManagement
{
    public class Student
    {
        // attributes:
        // # name : string
        // # age : int
        // # count : int (for auto-increment)
        // # id : int
        protected string name;
        protected int age;
        protected static int count = 0;
        protected int id;

        // properties:
        // + Name : get / set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // + Age : get / set
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        // + ID : get (return "GCH" + id)
        public string ID
        { 
            get { return "GCH" + id; }
        }

        // default constructor
        public Student()
        {
            Name = "No name";
            Age = 18;
            id = ++count;
        }

        // parameter constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            id = ++count;
        }

        // ShowInfo
        public void ShowInfo()
        {
            System.Console.WriteLine(ID + ", " + Name + ", " + Age);
        }
    }
}