using System;

namespace DemoComposite
{
    public class NewMember : Member
    {
        public NewMember(string name, int products) : base(name, products)
        {
        }

        public override double GetSalary()
        {
            return PRICE * Products * (1 - COMMISION);
        }
    }
}