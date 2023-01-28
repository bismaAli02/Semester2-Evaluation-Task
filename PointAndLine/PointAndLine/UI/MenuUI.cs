using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
namespace PointAndLine.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("--              POINT AND LINE APPLICATION                --");
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine(" ");
        }
        // end of header function

        public static void SystemCls()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
        public static int menu()
        {
            header();
            Console.WriteLine("////////    Main Menu   ////////////   ");
            Console.WriteLine("Select one of the following options number . . .");
            Console.WriteLine("1.  Make a line  ");
            Console.WriteLine("2.  Update the begin point");
            Console.WriteLine("3.  Update the end point");
            Console.WriteLine("4.  Show the begin point");
            Console.WriteLine("5.  show the end point");
            Console.WriteLine("6.  Get the lenght of the line");
            Console.WriteLine("7.  Get the gradient of the line ");
            Console.WriteLine("8.  Find the distance of begin point from zero coordinates ");
            Console.WriteLine("9.  Find the distance of end point from zero coordinates ");
            Console.WriteLine("10. Exit");
            Console.Write("Choose your option: ");
            int option = int.Parse(Console.ReadLine());
            SystemCls();
            return option;
        }

      public static void DiplayWrongOption()
        {

            Console.WriteLine("you choose wrong option");
        }

      

    }
}
