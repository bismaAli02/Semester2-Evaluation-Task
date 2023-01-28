using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;

namespace PointAndLine.UI
{
    class LineUI
    {

        public static MyLine takeInput()
        {
            Console.WriteLine("Enter  coordinates for begining: \n");
            MyPoint begin = MyPointUI.takeInput();
            Console.WriteLine("\n");
            Console.WriteLine("Enter coordinates for ending: \n");
            MyPoint end = MyPointUI.takeInput();
            MyLine line = new MyLine(begin, end);
            return line;
        }


        public static void DiplayLenght(double Lenght)
        {
            Console.WriteLine("Lenght of line is: " + Lenght);
        }

        public static void DisplayGradient(double Gradient)
        {
            Console.WriteLine("Gradient of line is: " + Gradient);
        }



    }
}
