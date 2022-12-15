using System;
using System.Collections.Generic;

namespace DemoComposite
{
    public class Company
    {
        private List<Member> members;

        public Company()
        {
            members = new List<Member>();
        }

        public void AddTopMember(ReferenceMember member)
        {
            members.Add(member);
        }

        public double CalculateIncome()
        {
            double income = 0;
            foreach (Member member in members)
            {
                income += (member.GetSalary() / (1 - Member.COMMISION)) * Member.COMMISION;
            }
            return income;
        }

        public void Show()
        {
            Console.WriteLine("All members of the company:");
            foreach (Member member in members)
            {
                member.Show();
            }
        }      
    }
}