using System;

namespace ProductManagement
{
    public class SaleProduct : Product
    {
        private double sale;
        public double Sale 
        {
            get { return sale; }
            set 
            { 
                if (value < 0 || value > 1) sale = 0.5;
                else sale = value; 
            }
        }

        public SaleProduct()
        {
            sale = 0.5;
        }
        public SaleProduct(string name, double price, double sale) : base(name, price)
        {
            Sale = sale;
        }

        public void ShowInfo()
        {
            double new_price = sale * price;
            System.Console.WriteLine(name + ": $" + new_price);
        }

    }
}