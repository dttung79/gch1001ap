using System;

namespace ProductManagement
{
    public class Product
    {
        private string name;  // attribute

        public string Name   // property
        {
            get { return name; }
            set 
            {
                if (value == "") name = "No name";
                else name = value;
            }
        }

        public int Price { get; set; } // short-cut, no attribute

        private static int count = 0;  // count number of created Product object

        public int Count    // read-only property
        {
            get { return count; }
        }

        // defautl constructor
        public Product()
        {
            Name = "No name";
            Price = 0;
            count += 1;
        }
        // parameter constructor
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            count += 1;
        }
    }
}