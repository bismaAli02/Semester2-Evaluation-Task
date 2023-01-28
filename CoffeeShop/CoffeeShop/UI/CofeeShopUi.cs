using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.BL;
using CoffeeShop.DL;

namespace CoffeeShop.UI

{
    class CofeeShopUi
    {
       
       public static void DisplayPrice(double price)
        {
            Console.WriteLine("your total amount is: " + price);
        }


        public static void DisplayOrders(coffeeShop shop)
        {
            List<string> orders = shop.listOrder();
            if (orders != null)
            {

                foreach (string order in orders)
                {
                    Console.WriteLine(order);
                }
            }
        }

        public static void DisplayFulfillOrders(coffeeShop shop)
        {
            Console.WriteLine(shop.fulfillOrder());
        }


       
       




    }
}
