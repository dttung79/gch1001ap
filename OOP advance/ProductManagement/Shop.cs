using System;
using System.Collections.Generic;

namespace ProductManagement
{
    public class Shop
    {
        private List<Product> products;
        private List<SaleProduct> saleProducts;

        public Shop()
        {
            products = new List<Product>();
            saleProducts = new List<SaleProduct>();
        }

        public void PrintMenu()
        {
            System.Console.WriteLine("1. Add new product");
            System.Console.WriteLine("2. Sell product");
            System.Console.WriteLine("3. Quit");
        }

        public int GetChoice()
        {
            System.Console.WriteLine("Choose option: ");
            return int.Parse(Console.ReadLine());
        }

        public void AddNewProduct()
        {
            System.Console.Write("Normal product or sale product? (n/s): ");
            string answer = Console.ReadLine();
            Product p = EnterProduct();

            if (answer == "n")
            {                
                products.Add(p);
            }
            else // sale
            {
                System.Console.Write("Enter % sale: ");
                int sale = int.Parse(Console.ReadLine());

                SaleProduct sp = new SaleProduct(p.Name, p.Price, sale/100.0);
                saleProducts.Add(sp);
            }
        }
        private Product EnterProduct()
        {
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            return p;
        }
        public void SellProduct()
        {
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            foreach(SaleProduct sp in saleProducts)
            {
                if (sp.Name == name)
                {
                    sp.ShowInfo();
                    System.Console.WriteLine("Product " + sp.Name + " sold!");
                    return;
                }
            }

            foreach(Product p in products)
            {
                if (p.Name == name)
                {
                    p.ShowInfo();
                    System.Console.WriteLine("Product " + p.Name + " sold!");
                    return;
                }
            }
            System.Console.WriteLine("Product not found!");
        }
    }
}