using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;

namespace OceanNavigation.UI
{
    class MenuUI
    {


        public static void header()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*        OCEAN NAVIGATION MANAGEMENT SYSTEM       *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("          ");
        }

        public static char menu()
        {
            char option;
            header();
            Console.WriteLine("//////////   MAIN MENU  ///////////////          ");
            Console.WriteLine("          ");
            Console.WriteLine("Press 1 to Add Ship          ");
            Console.WriteLine("Press 2 to View Ship Position          ");
            Console.WriteLine("Press 3 to View Ship Serial Number          ");
            Console.WriteLine("Press 4 to Change Ship Position          ");
            Console.WriteLine("Press 5 to EXIT         ");
            Console.WriteLine("Enter your option        ");
            return option = char.Parse(Console.ReadLine());
        }

        public static void systemCls()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }


        public static void WrongOption()
        {
            Console.WriteLine("You choose wrong option");
        }

        public static void Load()
        {
            Console.WriteLine("File loaded Successfully");
            Console.ReadKey();
            Console.Clear();
        }

        public static void UnLoad()
        {
            Console.WriteLine("File does not loaded Successfully");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
