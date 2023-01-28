using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;

namespace PointAndLine.UI
{
    class MyPointUI
    {
        
        
        
        public static MyPoint takeInput()
        {
            Console.Write("Enter x coordinate : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate : ");
            int y = int.Parse(Console.ReadLine());
            MyPoint point = new MyPoint(x, y);
            return point;
        }
        
        
        
        
        
        
        public static void UpdatePoint(MyPoint UpdatePoint)
        {
            Console.Write("Enter x coordinate : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate : ");
            int y = int.Parse(Console.ReadLine());
            UpdatePoint.setXY(x, y);

        }

        public static void DisplayUpdatePoint(MyPoint UpdatePoint)
        {
            Console.WriteLine("x coordinate of line " + UpdatePoint.getX());
            Console.WriteLine("y coordinate of line " + UpdatePoint.getY());
        }

        public static void DisplayDistanceOfBeginPoint(double Distance)
        {
            Console.WriteLine("distance of begin point from zero coordinate: " + Distance);
        }

        public static void DisplayDistanceOfEndPoint(double Distance)
        {
            Console.WriteLine("distance of end point from zero coordinate: " + Distance);
        }



    }
}
