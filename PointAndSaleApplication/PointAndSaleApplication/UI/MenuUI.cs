using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.DL;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("--              POINT AND SALE APPLICATION                --");
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine(" ");
        }
        // end of 2nd header function

        public static void SystemCls()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
        public static int CustMenu()
        {
            header();
            Console.WriteLine("////////    Main Menu   ////////////   ");
            Console.WriteLine("Select one of the following options number . . .");
            Console.WriteLine("1.  View All Products ");
            Console.WriteLine("2.  Buy new Products");
            Console.WriteLine("3.  Generate Invoice");
            Console.WriteLine("4.  Exit");
            Console.Write("Choose your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }




        public static char Menu()
        {
            header();
            Console.WriteLine("Press 1 to Sign-In");
            Console.WriteLine("Press 2 to Sign-Up");
            Console.WriteLine("Press 3 to Exit");
            char op;
            op = char.Parse(Console.ReadLine());
            SystemCls();
            return op;
        }

        public static void WrongPassword()
        {
          Console.WriteLine("You Entered Wrong Password");
        }

       


        static public int AdminMenu()
        {
            header();
            Console.WriteLine("////////    Main Menu   ////////////   ");
            Console.WriteLine("Select one of the following options number . . .");
            Console.WriteLine("1.  Add products  ");
            Console.WriteLine("2.  View All Products");
            Console.WriteLine("3.  Find Product with Highest unit price");
            Console.WriteLine("4.  View sales tax of All Products");
            Console.WriteLine("5.  View Products to be orderd");
            Console.WriteLine("6.  Exit");
            Console.Write("Choose your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

       

        public static void DisplayWrongOption()
        {
            Console.WriteLine("You choose wrong option");
        }

        public static void Thanks()
        {
            Console.WriteLine("Thank you for using our application");
        }

        public static void Load()
        {
            Console.WriteLine("File loaded Successfully");
            Console.ReadKey();

        }

        public static void UnLoad()
        {
            Console.WriteLine("File does not loaded Successfully");
            Console.ReadKey();
        }






    }
}

