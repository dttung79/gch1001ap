using System;

namespace CustomerManagement
{
    public class PPVCustomer : Customer
    {
        private int movies;
        private const int PRICE = 1000;

        public int Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        public PPVCustomer()
        {
            movies = 0;
        }
        public PPVCustomer(string name, string email, int movies) : base(name, email)
        {
            Movies = movies;
        }

        public override double GetPayment()
        {
            return movies * PRICE;
        }
    }
}