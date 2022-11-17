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

        private int id;
        public int ID    // read-only property
        {
            get { return id; }
        }

        // defautl constructor
        public Product()
        {
            Name = "No name";
            Price = 0;
            id = ++count;
        }
        // parameter constructor
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            id = ++count;
        }

        public void ShowInfo()
        {
            Console.WriteLine("ID: " + ID + ", name: " + Name + ", price: " + Price);
        }
    }
}