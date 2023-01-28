using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.DL;


namespace CoffeeShop.BL
{

    class coffeeShop
    {
        public coffeeShop(string ShopName)
        {
            this.ShopName = ShopName;
        }


        private string ShopName;
        private List<string> Orders = new List<string>();

        public string AddOrder(string OrderName)
        {
            foreach (MenuItem item in MenuItemDL.Menu)
            {
                if (OrderName == item.GetProductName())
                {
                    return OrderName;
                }
            }
            return "This Item is Currently Unavailable";
        }

        public void AddorderIntoList(string name)
        {
            Orders.Add(name);
        }

        public string GetShopName()
        {
            return ShopName;
        }
        public void setShopName(string ShopName)
        {
            this.ShopName = ShopName;
        }

        public List<string> GetListOfOrders()
        {
            return Orders;
        }

        public void SetListOfOrders(List<string>Orders)
        {
            this.Orders = Orders;
        }

        public string fulfillOrder()
        {
            if (Orders.Count != 0)
            {
                string name = Orders[0];
                Orders.RemoveAt(0);
                return "The " + name + " is ready!!!!";
            }
            return "All orders have been fulfilled ";
        }

        public List<string> listOrder()
        {
            if (Orders.Count != 0)
            {
                return Orders;
            }
            return null;
        }

        public double dueAmount()
        {
            double price = 0;
            foreach (string name in Orders)
            {
                foreach (MenuItem item in MenuItemDL.Menu)
                {
                    if (name == item.GetProductName())
                    {
                        price += item.GetPrice();
                    }
                }
            }
            return price;

        }
    }
}
