using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndSaleApplication.BL
{
    class Product
    {
        public Product(string ProductName, string Category, float price, int stock, int MiniStock)
        {
            this.ProductName = ProductName;
            this.Category = Category;
            this.price = price;
            this.stock = stock;
            this.MiniStock = MiniStock;
        }
       
        private string ProductName;
        private string Category;
        private float price;
        private int stock;
        private int MiniStock;

        public double CalculateTax()
        {
            double tax;
            if(Category == "FRUIT" || Category == "fruite" || Category == "Fruit")
            {
                tax = 10F;
            }
            else if(Category == "Grocery" || Category == "grocery" || Category == "Grocery")
            {
                tax = 5F;
            }
            else
            {
                tax = 15F;
            }
            tax = price * tax / 100;
            return tax;
                    
        }

        public string GetProductName()
        {
            return ProductName;
        }

        public string GetCategory()
        {
            return Category;
        }
    
        public float GetPrice()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }

        public int GetMiniStock()
        {
            return MiniStock;
        }

        public void setProductName(string ProductName)
        {
            this.ProductName = ProductName;
        }

        public void setCategory(string Category)
        {
            this.Category = Category;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public void setStock(int stock)
        {
            this.stock = stock; 
        }

        public void setMiniStock(int MiniStock)
        {
            this.MiniStock = MiniStock;
        }


    }
}
