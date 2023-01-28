using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.DL
{
    class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();

        public static void AddCustomerIntolist(Customer c)
        {
            customers.Add(c);
        }

        public static Customer IsCustomerAvailable(MUser cust)
        {
            foreach (Customer c in customers)
            {
                if (cust.GetUserName() == c.GetCustName() && cust.GetPassword() == c.GetPassword())
                {
                    return c;
                }

            }

            return null;
        }

        public static void StoreDataIntoFile()
        {
            string path = "Customers.txt";
            StreamWriter file = new StreamWriter(path, false);
            foreach (Customer cust in customers)
            {
                string item = "";
                if (cust.GetProductCount() > 0)
                {
                    List<Product> products = cust.GetListOfBuyProducts();
                    for (int x = 0; x < cust.GetProductCount() - 1; x++)
                    {
                        item = item + products[x].GetProductName() + ",";
                    }
                    item = item + products[cust.GetProductCount() - 1].GetProductName();
                    file.WriteLine(cust.GetCustName() + "," + cust.GetPassword() + ","+ item);
                }
            }
            file.Flush();
            file.Close();
        }


        public static bool ReadDataFromFile()
        {
            string path = "Customers.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string[] splitRecord = record.Split(',');
                    string CustName = splitRecord[0];
                    string password = splitRecord[1];
                    MUser user = new MUser(CustName, password);
                    Customer cust = IsCustomerAvailable(user);
                    if (cust != null)
                    {
                        for (int i = 2; i < splitRecord.Length; i++)
                        {
                            Product p = ProductDL.IsProductAvailable(splitRecord[i]);
                            if (p != null)
                            {
                                cust.AddProductsIntoList(p);
                            }
                        }
                    }
                }
                file.Close();
                return true;
            }
            return false;
        }


    }
}
    

