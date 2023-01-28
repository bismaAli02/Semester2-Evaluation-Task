using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.DL;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.UI
{
    class ProductUI
    {
        public static Product AddProduct()
        {
            Console.WriteLine("Enter the name of product: ");
            string ProductName = Console.ReadLine();
            Console.WriteLine("Enter the category of product: ");
            string Category = Console.ReadLine();
            Console.WriteLine("Enter the price of product: ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Available stock of product: ");
            int stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Threshold stock of product: ");
            int MiniStock = int.Parse(Console.ReadLine());
            Product p = new Product(ProductName, Category, price, stock, MiniStock);
            return p;
        }

        public static void DisplayProducts()
        {
            foreach (Product p in ProductDL.Products)
            {
                Console.WriteLine(" Item name: " + p.GetProductName());
                Console.WriteLine(" Item Type: " + p.GetCategory());
                Console.WriteLine(" item Price: " + p.GetPrice());
                Console.WriteLine(" item stock: " + p.GetStock());
                Console.WriteLine("\n");
            }
        }

        public static void DisplayProductsWithTax()
        {
            foreach (Product p in ProductDL.Products)
            {
                Console.WriteLine(" Item name: " + p.GetProductName());
                Console.WriteLine(" Item Type: " + p.GetCategory());
                Console.WriteLine(" item Price: " + p.GetPrice());
                Console.WriteLine(" item stock: " + p.GetStock());
                Console.WriteLine(" item tax " + p.CalculateTax());
                Console.WriteLine("\n");
            }
        }

        public static void DisplayHighestPricePtoduct()
        {
            Product p = ProductDL.HighestUnitPrice();
            Console.WriteLine(" Item name: " + p.GetProductName());
            Console.WriteLine(" Item Type: " + p.GetCategory());
            Console.WriteLine(" item Price: " + p.GetPrice());
            Console.WriteLine(" item stock: " + p.GetStock());
            Console.WriteLine("\n");
        }

        public static void DisplayProductsLessthanMiniStock()
        {
            foreach (Product p in ProductDL.Products)
            {
                if (p.GetStock() < p.GetMiniStock())
                {
                    Console.WriteLine(" Item name: " + p.GetProductName());
                    Console.WriteLine(" Item Type: " + p.GetCategory());
                    Console.WriteLine(" item Price: " + p.GetPrice());
                    Console.WriteLine(" item stock: " + p.GetStock());
                    Console.WriteLine("\n");
                }
            }
        }

        public static void BuyProducts(Customer cust)
        {
            int stock;
            Console.WriteLine("Enter the name of product you want to buy: ");
            string ProductName = Console.ReadLine();
            Product product = ProductDL.IsProductAvailable(ProductName);
            if (product != null)
            {
                cust.AddProductsIntoList(product);
                stock=product.GetStock();
                product.setStock(stock-1);
            }
        }








    }
}
