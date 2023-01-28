using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.DL
{
    class ProductDL
    {
        public static List<Product> Products = new List<Product>();

        public static void AddProductsIntoList(Product p)
        {
            Products.Add(p);
        }

        public static Product IsProductAvailable(string name)
        {
            foreach(Product p in Products)
            {
                if(name== p.GetProductName())
                {
                    return p;
                }
            }
            return null;
        }

        public static Product HighestUnitPrice()
        {
            List<Product> SortedList = Products.OrderByDescending(o => o.GetPrice()).ToList();
            return SortedList[0]; 
        }

        public static void StoreIntoFile()
        {
            string path = "Products.txt";
            StreamWriter file = new StreamWriter(path, false);
            foreach (Product p in Products)
            {
                file.WriteLine(p.GetProductName() + "," + p.GetCategory() + "," + p.GetPrice() + "," + p.GetStock() + "," + p.GetMiniStock());
            }
            file.Flush();
            file.Close();
        }


        public static bool ReadDataFromFile()
        {
            string path = "Products.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string[] splitRecord = record.Split(',');
                    string ProductName = splitRecord[0];
                    string Category = splitRecord[1];
                    float price = float.Parse(splitRecord[2]);
                    int stock = int.Parse(splitRecord[3]);
                    int MiniStock = int.Parse(splitRecord[4]);
                    Product p = new Product(ProductName, Category, price, stock, MiniStock);
                    AddProductsIntoList(p);
                }
                file.Close();
                return true;
            }
            return false;
        }

      






    }
}
