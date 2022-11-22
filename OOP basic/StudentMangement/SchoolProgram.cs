using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMangement
{
    public class SchoolProgram
    {
        // attribute: school
        private School greenwich;

        // default constructor
        public SchoolProgram()
        {
            greenwich = new School("Greenwich");
        }
        // PrintMenu
        public void PrintMenu()
        {
            System.Console.WriteLine("1, Enroll student ");
            System.Console.WriteLine("2, DropOut student ");
            System.Console.WriteLine("3, Show all student ");
            System.Console.WriteLine("0, Exit ");
        }

        public int GetChoice()
        {
            System.Console.Write("Your choice: ");
            return int.Parse(Console.ReadLine());
        }

        // Process
        public void Process (int choice)
        {
            switch(choice)
            {
                case 1: greenwich.Enroll(); break;
                case 2: greenwich.DropOut(); break;
                case 3: greenwich.ShowStudents(); break;
                case 0: break;
                default:
                {
                    Console.WriteLine("Invalid Choice !");
                    break;
                }
            }
        }
    }
}