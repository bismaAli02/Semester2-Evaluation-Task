using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DL;
using CoffeeShop.UI;
using CoffeeShop.BL;
namespace CoffeeShop
{
    class Program
    {
        //option 2
        static void Main(string[] args)
        {
            string path1 = "Items.txt";
            string path2 = "Orders.txt";
            coffeeShop shop = new coffeeShop("Tesha's Coffee Shop: ");

            if (MenuItemDL.LoadFromFile(path1))
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }

            if (CoffeeShopDL.LoadDataFromFile(path2, shop))
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }
            do
            {
                MenuUI.header1();
                int option = MenuUI.DisplayMenu();
                MenuUI.SystemCls();
                MenuUI.header1();
                if (option == 1)
                {
                    MenuItem item = MenuItemUI.AddMenuItem();
                    MenuItemDL.AddItemsIntoList(item);
                    MenuItemDL.StoreDataIntoFile(path1, item);
                }
                else if (option == 2)
                {

                    Console.WriteLine(MenuItemDL.cheapestItem());
                }
                else if (option == 3)
                {
                    MenuItemUI.drinksOnly();
                }
                else if (option == 4)
                {
                    MenuItemUI.foodOnly();
                }
                else if (option == 5)
                {
                    string OrderName = MenuItemUI.Order();
                    string order = shop.AddOrder(OrderName);
                    if (order != "This Item is Currently Unavailable")
                    {
                        shop.AddorderIntoList(order);
                        CoffeeShopDL.StoreDataIntoFile(path2, shop);
                    }
                    else
                    {
                        Console.WriteLine(order);
                    }
                }

                else if (option == 6)
                {

                    CofeeShopUi.DisplayFulfillOrders(shop);
                    CoffeeShopDL.StoreDataIntoFile(path2, shop);
                }
                else if (option == 7)
                {
                    CofeeShopUi.DisplayOrders(shop);
                }
                else if (option == 8)
                {
                    double price = shop.dueAmount();
                    CofeeShopUi.DisplayPrice(price);
                }
                else if (option == 9)
                {
                    break;
                }
                else
                {
                    MenuUI.DisplayWrongOption();
                }
                MenuUI.SystemCls();
            }
            while (true);

        }
    }
}
