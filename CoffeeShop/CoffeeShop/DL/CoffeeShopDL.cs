using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.BL;
using System.IO;

namespace CoffeeShop.DL
{
    class CoffeeShopDL
    {
         public static void StoreDataIntoFile(string path, coffeeShop shop)
         {
            StreamWriter file = new StreamWriter(path);
            foreach (string orders in shop.GetListOfOrders()) 
            {
                file.WriteLine(orders);
            }
            file.Flush();
            file.Close();
         }

        public static bool LoadDataFromFile(string path, coffeeShop shop)
        {

            StreamReader file = new StreamReader(path, false);
            if (File.Exists(path))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    shop.AddOrder(record);
                    shop.AddorderIntoList(record);
                }
                file.Close();
                return true;
            }
            return false;
        }
    
    }
}
