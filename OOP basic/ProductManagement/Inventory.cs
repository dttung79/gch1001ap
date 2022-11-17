using System;
using System.Collections.Generic;


namespace ProductManagement
{
    public class Inventory
    {
        private List<Product> products;  // null

        public Inventory()
        {
            products = new List<Product>(); // empty
        }

        public void Import()
        {
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            products.Add(p);
        }
        public void Export()
        {
            System.Console.Write("Enter product ID: ");
            int ID = int.Parse(Console.ReadLine());

            Product p = FindByID(ID);
            
            if (p == null) System.Console.WriteLine("Product not found!");
            else
            {
                products.Remove(p);
                System.Console.WriteLine("Product removed!");
            }        
        }
        public Product FindByID(int ID)
        {
            foreach(Product p in products)
            {
                if (p.ID == ID) return p;
            }
            return null;
        }

        public void ShowProducts()
        {
            System.Console.WriteLine("All products in Inventory");
            foreach(Product p in products)
            {
                p.ShowInfo();
            }
        }
    }
}