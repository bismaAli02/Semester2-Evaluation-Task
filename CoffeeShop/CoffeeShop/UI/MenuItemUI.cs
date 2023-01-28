using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.BL;
using CoffeeShop.DL;

namespace CoffeeShop.UI
{
    class MenuItemUI
    {
        public static void DisplayItem()
        {
            foreach (MenuItem item in MenuItemDL.Menu)
            {
                Console.WriteLine("Item name: " + item.GetProductName());
                Console.WriteLine("Item Type " + item.getType());
                Console.WriteLine("item Price " + item.GetPrice());
                Console.WriteLine("\n");
            }
        }

        public static void drinksOnly()
        {
            foreach (MenuItem item in MenuItemDL.Menu)
            {
                if (item.getType() == "Drink" || item.getType() == "drink")
                {
                    Console.WriteLine("Item name: " + item.GetProductName());
                    Console.WriteLine("Item Type " + item.getType());
                    Console.WriteLine("item Price " + item.GetPrice());
                    Console.WriteLine("\n");
                }
            }

        }

        public static void foodOnly()
        {
            foreach (MenuItem item in MenuItemDL.Menu)
            {
                if (item.getType() == "Food" || item.getType() == "food")
                {
                    Console.WriteLine("Item name: " + item.GetProductName());
                    Console.WriteLine("Item Type " + item.getType());
                    Console.WriteLine("item Price " + item.GetPrice());
                    Console.WriteLine("\n");
                }
            }

        }

        public static MenuItem AddMenuItem()
        {
            Console.WriteLine("Enter name of Item  ");
            string ProductName = Console.ReadLine();
            Console.WriteLine("Enter type of item ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter price of item ");
            float price = float.Parse(Console.ReadLine());
            MenuItem Item = new MenuItem(ProductName, type, price);
            return Item;
        }

        public static string Order()
        {
            Console.WriteLine("Enter your order please: ");
            string OrderName = Console.ReadLine();
            return OrderName;
        }
      




    }
}
