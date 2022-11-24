using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class TopupStudent : Student
    {
        // attributes:
        // - grade: int (0-100)
        // - ojt : string (Pass/Fail)
        private int grade;
        private string ojt;

        // properties:
        // + Grade
        // + OJT
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 100) value = 0;
                grade = value;
            }
        }
        public string OJT
        {
            get { return ojt; }
            set 
            {
                if (value != "Pass" && value != "Fail") value = "Fail";
                ojt = value;
            }
        }

        // default constructor
        public TopupStudent()
        {
            grade = 0;
            ojt = "Fail";
        }
        // parameter constructor
        public TopupStudent(string name, int age) : base(name, age)
        {
            grade = 0;
            ojt = "Fail";
        }

        // ShowInfo
        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Grade: " + grade);
            System.Console.WriteLine("OJT: " + ojt);
        }
    }
}