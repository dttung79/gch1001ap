using System;

namespace CustomerManagement
{
    public abstract class Customer
    {
        protected static int count = 0;
        protected int id;
        protected string name;
        protected string email;

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Customer()
        {
            id = ++count;
        }
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            id = ++count;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
        }

        public abstract double GetPayment();
        
    }
}