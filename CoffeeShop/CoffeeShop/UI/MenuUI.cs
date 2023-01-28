using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.BL;
using CoffeeShop.DL;


namespace CoffeeShop.UI
{
    class MenuUI
    {
        public static void header1()
        {
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("--       COFFEE SHOP      --");
            Console.WriteLine("////////////////////////////");
            Console.WriteLine(" ");
        }
        // end of 2nd header function

        public static void SystemCls()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }

        public static int DisplayMenu()
        {
            header1();
            Console.WriteLine("////////    Main Menu   ////////////   ");
            Console.WriteLine("Select one of the following options number . . .");
            Console.WriteLine("1.  Add a menu Item  ");
            Console.WriteLine("2.  View the cheapest item in menu");
            Console.WriteLine("3.  View the Drink's menu");
            Console.WriteLine("4.  View the Food's menu");
            Console.WriteLine("5.  Place Order ");
            Console.WriteLine("6.  Fulfill the order ");
            Console.WriteLine("7.  View the Order's List ");
            Console.WriteLine("8.  Total payable amount ");
            Console.WriteLine("9. Exit");
            Console.Write("Choose your option: ");
            int option = int.Parse(Console.ReadLine());

            return option;
        }

        public static void DisplayWrongOption()
        {
            Console.WriteLine("You choose wrong option");
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
            Console.Clear();
        }



    }
}
