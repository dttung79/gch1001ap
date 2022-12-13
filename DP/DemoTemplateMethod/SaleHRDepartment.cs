using System;
using System.Collections.Generic;

namespace DemoTemplateMethod
{
    public class SaleHRDepartment : HRDepartment
    {
        protected override List<Candidate> CVRound(List<Candidate> candidates)
        {
            List<Candidate> passCV = new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                if (c.Age >= 18 && c.Age <= 50 && c.GPA >= 4.0)
                {
                    passCV.Add(c);
                    System.Console.WriteLine("Candidate " + c.Name + " passed CV round");
                }
            }
            return passCV;
        }

        protected override List<Candidate> TestRound(List<Candidate> candidates)
        {
            // no need to do test round
            return candidates;
        }

        protected override List<Candidate> InterviewRound(List<Candidate> candidates)
        {

            List<Candidate> passInterview = new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                System.Console.WriteLine("Sell me this pen!");
                System.Console.Write("Candidate answer: ");
                Console.ReadLine();
                System.Console.Write("Did he/she sell it successfully? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    System.Console.WriteLine("Candidate passed interview round");
                    passInterview.Add(c);
                }
            }
            return passInterview;
        }
        protected override Employee Offer(Candidate candidate)
        {
            System.Console.Write("What is the salary for " + candidate.Name + "? ");
            double salary = double.Parse(Console.ReadLine());
            System.Console.Write("How many products " + candidate.Name + " can sell? ");
            int products = int.Parse(Console.ReadLine());

            SaleEmployee employee = new SaleEmployee(candidate.Name, candidate.Age, 
                                                salary, products);
            return employee;
        }
    }
}