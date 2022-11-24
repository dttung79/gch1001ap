using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class School
    {
        private List<BtecStudent> btecStudents;
        private List<TopupStudent> topupStudents;

        public School()
        {
            btecStudents = new List<BtecStudent>();
            topupStudents = new List<TopupStudent>();
        }

        public void PrintMenu()
        {
            System.Console.WriteLine("1. Enroll");    
            System.Console.WriteLine("2. Move to topup");
            System.Console.WriteLine("3. Show btec students");
            System.Console.WriteLine("4. Show topup students");
            System.Console.WriteLine("5. Grade BTEC");
            System.Console.WriteLine("6. Grade Topup");
        }
        public int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }  
        public void Process(int choice)
        {
            switch (choice)
            {
                case 1 : Enroll(); break;
                case 2 : MoveToTopup(); break;
                case 3 : ShowBtecStudents(); break;
                case 4 : ShowTopupStudents(); break;
                case 5 : GradeBtecStudents(); break;
                case 6 : GradeTopupStudents(); break;
                case 0 : break;
                default: System.Console.WriteLine("Invalid choice"); break;
            }
        }
        private void Enroll()
        {
            System.Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter student age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            BtecStudent bs = new BtecStudent(name, age);
            btecStudents.Add(bs);
        }
        private void MoveToTopup()
        {
            // enter btec student id
            System.Console.Write("Enter BTEC student id: ");
            string id = Console.ReadLine();
            // find the student by id in btecStudents list
            foreach (BtecStudent bs in btecStudents)
            {
                if (bs.ID == id)
                {
                    // create a new topup student
                    TopupStudent ts = new TopupStudent(bs.Name, bs.Age);
                    // add the new topup student to topupStudents list
                    topupStudents.Add(ts);
                    // remove the btec student from btecStudents list
                    btecStudents.Remove(bs);
                    return;
                }
            }
            System.Console.WriteLine("BTEC student ID " + id + " not found");
        }
        private void GradeBtecStudents()
        {
            foreach (BtecStudent bs in btecStudents)
            {
                System.Console.Write("Enter grade for student " + bs.Name + ": ");
                string grade = Console.ReadLine();
                bs.Grade = grade;
            }
        }
        private void GradeTopupStudents()
        {
            foreach (TopupStudent ts in topupStudents)
            {
                System.Console.Write("Enter grade for student " + ts.Name + ": ");
                int grade = int.Parse(Console.ReadLine());
                ts.Grade = grade;
                System.Console.Write("Enter OJT result: ");
                string ojt = Console.ReadLine();
                ts.OJT = ojt;
            }
        }
    }
}