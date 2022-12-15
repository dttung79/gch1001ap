using System;
using System.Collections.Generic;
namespace DemoComposite
{
    public class ReferenceMember : Member
    {
        private List<Member> members;

        public ReferenceMember(string name, int products) : base(name, products)
        {
            members = new List<Member>();
        }

        public void Add(Member member)
        {
            members.Add(member);
        }

        public override double GetSalary()
        {
            double salary = Products * PRICE;
            foreach (Member member in members)
            {
                salary += (member.GetSalary() / (1 - COMMISION)) * COMMISION;
            }
            salary *= (1 - COMMISION);
            return salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("List of members of {0}:", Name);
            foreach (Member member in members)
            {
                member.Show();
            }
        }
    }
}