using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.BL;
using System.IO;

namespace CoffeeShop.DL
{
    class MenuItemDL
    {

        public static List<MenuItem> Menu = new List<MenuItem>();
        



        public static void AddItemsIntoList(MenuItem item)
        {
            Menu.Add(item);
        }

        public static string cheapestItem()
        {
            List<MenuItem> SortedMenu = Menu.OrderBy(o => o.GetPrice()).ToList();
            return SortedMenu[0].GetProductName();
        }


        public static void StoreDataIntoFile(string path, MenuItem item)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(item.GetProductName() + "," + item.getType() + "," + item.GetPrice());
            file.Flush();
            file.Close();
        }

        public static bool LoadFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splitRecord = record.Split(',');
                    string ProductName = splitRecord[0];
                    string type = splitRecord[1];
                    float price  = float.Parse(splitRecord[2]);
                    MenuItem item = new MenuItem(ProductName, type, price);
                    AddItemsIntoList(item);
                }
                file.Close();
                return true;
            }
            return false;

        }

    }
}
