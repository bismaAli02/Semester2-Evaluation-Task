using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.BL
{
    class MenuItem
    {
        public MenuItem(string ProductName, string type, float price)
        {
            this.ProductName = ProductName;
            this.type = type;
            this.price = price;
        }
        
        
        
        private string ProductName;
        private string type;
        private float price;

        public string GetProductName()
        {
            return ProductName;
        }
        public string getType()
        {
            return type;
        }

        public float GetPrice()
        {
            return price;
        }

        public void setProductName(string ProductName)
        {
            this.ProductName = ProductName;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setPrice(float price )
        {
            this.price = price;
        }

    }
}
