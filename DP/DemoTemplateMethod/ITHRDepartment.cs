using System;
using System.Collections.Generic;

namespace DemoTemplateMethod
{
    public class ITHRDepartment : HRDepartment
    {
        protected override List<Candidate> CVRound(List<Candidate> candidates)
        {
            List<Candidate> passCV = new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                if (c.Age >= 18 && c.Age <= 30 && c.GPA >= 6.0)
                {
                    passCV.Add(c);
                    System.Console.WriteLine("Candidate " + c.Name + " passed CV round");
                }
            }
            return passCV;
        }
        protected override List<Candidate> TestRound(List<Candidate> candidates)
        {
            List<Candidate> passTest = new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                Console.WriteLine("Candidate " + c.Name + " was asked to do a coding challenge");
                Console.Write("Did candidate " + c.Name + " pass the test? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    passTest.Add(c);
                    Console.WriteLine("Candidate " + c.Name + " passed test round");
                }
            }
            return passTest;
        }
        protected override List<Candidate> InterviewRound(List<Candidate> candidates)
        {
            // auto-pass interview round
            return candidates;
        }

        protected override Employee Offer(Candidate candidate)
        {
            Console.Write("What is the salary for " + candidate.Name + "? ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("What is the language " + candidate.Name + " can do? ");
            string language = Console.ReadLine();

            DevEmployee employee = new DevEmployee(candidate.Name, candidate.Age, 
                                                salary, language);
            return employee;
        }
    }
}