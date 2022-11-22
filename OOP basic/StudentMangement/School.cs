using System;
using System.Collections.Generic;
namespace StudentMangement
{
    public class School
    {
        public string Name { get; set; }
        // attribute: List<Student> students
        private List<Student> students;
        // default constructor
        public School(string name)
        {
            Name = name;
            students = new List<Student>();
        }
        // Enroll(): enroll student
        public void Enroll()
        {
            System.Console.Write("Your name: ");
            string name = System.Console.ReadLine();

            System.Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Grade: ");
            int grade = int.Parse(Console.ReadLine());

            Student s = new Student(name, age, grade);
            students.Add(s);
        }

        // DropOupt(): drop out student
        public void DropOut()
        {
            System.Console.WriteLine("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            
            foreach (Student s in students)
            {
                if (s.ID == ID)
                {
                    students.Remove(s);
                    return;
                }
            }
            System.Console.WriteLine("ID not found!");
        }

        // ShowStudents(): show all students   
        public void ShowStudents()
        {
            System.Console.WriteLine("Information of Student: ");
            foreach (Student s in students)
            {
                s.ShowInfo();
            }
        }    
    }
}