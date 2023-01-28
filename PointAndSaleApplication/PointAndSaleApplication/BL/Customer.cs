using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndSaleApplication.BL
{
    class Customer
    {
        public Customer(string CustName, string password)
        {
            this.CustName = CustName;
            this.password = password;
            BuyProducts = new List<Product>();
        }
       
        private string CustName;
        private string password;
        private List<Product> BuyProducts;
    
        public void AddProductsIntoList(Product p)
        {
            BuyProducts.Add(p);
        }

        public double TotalTax()
        {
            double TotTax=0;
            foreach(Product p in BuyProducts)
            {
                TotTax = TotTax + p.CalculateTax();
            }
            return TotTax;
        }

        public double TotalPrice()
        {
            double TotPrice = 0;
            foreach (Product p in BuyProducts)
            {
                TotPrice = TotPrice + p.GetPrice();
            }
            return TotPrice;
        }

        public string GetCustName()
        {
            return CustName;
        }

        public string GetPassword()
        {
            return password;
        }

        public List<Product> GetListOfBuyProducts()
        {
            return BuyProducts;
        }

        public void SetListOfBuyProduct(List<Product>BuyProducts)
        {
            this.BuyProducts = BuyProducts;
        }

        public  int GetProductCount()
        {
            return BuyProducts.Count;
        }
    }
}
