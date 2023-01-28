using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.BL;
using PointAndSaleApplication.DL;
using PointAndSaleApplication.UI;

namespace PointAndSaleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
           if( MUserDL.LoadDataFromFile())
            {
                MenuUI.Load();
            }
           else
            {
                MenuUI.UnLoad();
            }

            if (ProductDL.ReadDataFromFile())
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }

            if (CustomerDL.ReadDataFromFile())
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }
            char option;
            while (true)
            {
                option = MenuUI.Menu();
                if (option == '1')
                {
                    MUser user = MUserUI.SignIn();
                    MenuUI.SystemCls();
                    if (user != null)
                    {
                        if (user.GetRole() == "Admin" || user.GetRole() == "admin")
                        {
                            while (true)
                            {

                                int opt = MenuUI.AdminMenu();
                                MenuUI.SystemCls();
                                MenuUI.header();
                                if (opt == 1)
                                {
                                    Product p = ProductUI.AddProduct();
                                    ProductDL.AddProductsIntoList(p);
                                    ProductDL.StoreIntoFile();
                                }
                                else if (opt == 2)
                                {
                                    ProductUI.DisplayProducts();
                                }
                                else if (opt == 3)
                                {
                                    ProductUI.DisplayHighestPricePtoduct();
                                }
                                else if (opt == 4)
                                {
                                    ProductUI.DisplayProductsWithTax();
                                }
                                else if (opt == 5)
                                {
                                    ProductUI.DisplayProductsLessthanMiniStock();
                                }
                                else if (opt == 6)
                                {
                                    break;
                                }
                                else
                                {
                                    MenuUI.DisplayWrongOption();
                                }
                                MenuUI.SystemCls();
                            }
                        }
                        else if (user.GetRole() == "Customer" || user.GetRole() == "customer")
                        {
                            Customer cust = CustomerDL.IsCustomerAvailable(user);
                            while (true)
                            {
                                int opt = MenuUI.CustMenu();
                                MenuUI.SystemCls();
                                MenuUI.header();
                                if (opt == 1)
                                {
                                    ProductUI.DisplayProducts();
                                }
                                else if (opt == 2)
                                {
                                    ProductUI.BuyProducts(cust);
                                    ProductDL.StoreIntoFile();
                                    CustomerDL.StoreDataIntoFile();
                                }
                                else if (opt == 3)
                                {
                                    CustomerUI.Invoice(cust);
                                }
                                else if (opt == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    MenuUI.DisplayWrongOption();
                                }
                                MenuUI.SystemCls();
                            }
                        }
                    }
                    else
                        MenuUI.WrongPassword();
                }
                else if(option == '2')
                {
                    MenuUI.header();
                    MUser user = MUserUI.SignUp();
                    if (user != null)
                    {
                        MUserDL.AddUserIntoList(user);
                        MUserDL.StoreDataIntoFile(user);
                        if (user.GetRole() == "Customer" || user.GetRole() == "customer")
                        {
                            Customer cust = new Customer(user.GetUserName(), user.GetPassword());
                            CustomerDL.AddCustomerIntolist(cust);
                        }
                    }
                    else
                        MUserUI.MsgDisplay();
                }
                else if(option == '3')
                {
                    MenuUI.Thanks();
                    MenuUI.SystemCls();
                    break;
                }
                else
                {
                    MenuUI.DisplayWrongOption();
                }
               MenuUI.SystemCls();
            }
        }
    }
}






