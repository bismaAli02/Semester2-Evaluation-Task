using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using UMAS.DL;
namespace UMAS.UI
{
    class MenuUI
    {
       
        
        public static void header()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("*      UNIVERSITY ADMISSION MANAGEMENT SYSTEM     *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("          ");
        }
        
        
        public static char menu()
        {
            char option;
            header();
            Console.WriteLine("//////////   MAIN MENU  ///////////////          ");
            Console.WriteLine("          ");
            Console.WriteLine("Press 1 to Add student          ");
            Console.WriteLine("Press 2 to Add Degree Program          ");
            Console.WriteLine("Press 3 to generate Merit          ");
            Console.WriteLine("Press 4 to View Registered Student          ");
            Console.WriteLine("Press 5 to View Student of specific Program         ");
            Console.WriteLine("Press 6 to Register subject for specific Student         ");
            Console.WriteLine("Press 7 to Calculate fee for all registered student         ");
            Console.WriteLine("Press 8 to EXIT         ");
            Console.WriteLine("Enter your option        ");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        public static void systemCls()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
        // end of system_cls function
        public static void DisplayWrongOption()
        {
            Console.WriteLine("You choose wrong option");
        }

        public static void Load()
        {

            Console.WriteLine("File Loaded Successfully");
        }

        public static void UnLoad()
        {

            Console.WriteLine("File does not Loaded Successfully");
        }

        public static void DisplayDegreeExist()
        {
            Console.WriteLine("Degree Already Exists");
        }
    }
}







































      




       
