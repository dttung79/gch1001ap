using System;

namespace CustomerManagement
{
    public class SubcribeCustomer : Customer
    {
        private int subType;
        public int SubType
        {
            get { return subType; }
            set { subType = value; }
        }
        private const int MONTHLY = 250000;
        private const double SALE = 0.1;

        public SubcribeCustomer()
        {
            subType = 0; // monthly subcription by default
        }
        public SubcribeCustomer(string name, string email, int subType) : base(name, email)
        {
            SubType = subType;
        }

        public override double GetPayment()
        {
            if (subType == 0)
                return MONTHLY;
            else
                return MONTHLY * (1 - SALE);
        }
    }
}