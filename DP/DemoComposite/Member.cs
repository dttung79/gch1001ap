using System;

namespace DemoComposite
{
    public abstract class Member
    {
        public string Name { get; set; }
        public int Products { get; set; }      

        protected const double PRICE = 100.0;
        public static double COMMISION = 0.3;

        public Member(string name, int products)
        {
            Name = name;
            Products = products;
        }

        public abstract double GetSalary();
        public virtual void Show()
        {
            Console.WriteLine("Member {0} sells {1} products, earns ${2}", 
                            Name, Products, GetSalary());
        }
    }
}