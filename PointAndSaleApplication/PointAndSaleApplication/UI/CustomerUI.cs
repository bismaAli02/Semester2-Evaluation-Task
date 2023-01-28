using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.DL;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.UI
{
    class CustomerUI
    {
        public static void Invoice(Customer cust)
        {
            Console.WriteLine("Customer name: " + cust.GetCustName());
            double price = cust.TotalPrice() + cust.TotalTax();
            Console.WriteLine("Total Price After applying tax: " + price);
        }




    }
}
