using System;

namespace StudentManagement
{
    public class BtecStudent : Student
    {
        // atributes: 
        // - grade : string ("Fail", "Pass", "Merit", "Distinction")
        private string grade;

        // properties:
        // + Grade : string (validate value is one of 4 grades above)
        public string Grade
        {
            get { return grade; }
            set
            {
                if (value != "Fail" && value != "Pass" && 
                    value != "Merit" && value != "Distinction")
                {
                    value = "Fail";
                }
                grade = value;
            }
        }
        
        // default constructor
        public BtecStudent()
        {
            grade = "Fail";
        }

        // parameter constructor
        public BtecStudent(string name, int age) : base(name, age)
        {
            grade = "Fail";
        }

        // ShowInfo: show basic info (from base class) and grade
        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Grade: " + grade);
        }
    }
}