using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.UI;

namespace PointAndLine
{
    class Program
    {


        static void Main(string[] args)
        {


            MyLine line=new MyLine();


            do
            {
                Console.Clear();
                int option = MenuUI.menu();
                if (option == 1)
                {
                     line = LineUI.takeInput();
                }
                else if (option == 2) 
                {
                    MyPointUI.UpdatePoint(line.getBegin());
                }
                else if (option == 3)
                {
                    MyPointUI.UpdatePoint(line.getEnd());
                }
                else if (option == 4)
                {
                    MyPointUI.DisplayUpdatePoint(line.getBegin());
                }
                else if (option == 5)
                {
                    MyPointUI.DisplayUpdatePoint(line.getEnd());
                }
                else if (option == 6)
                {
                    double Lenght = line.getLenght();
                    LineUI.DiplayLenght(Lenght);
                }
                else if (option == 7)
                {
                    double Gradient = line.getGradient();
                    LineUI.DisplayGradient(Gradient);
                }
                else if (option == 8)
                {
                    double Distance= line.getBegin().distanceFromZero();
                    MyPointUI.DisplayDistanceOfBeginPoint(Distance);
                }
                else if (option == 9)
                {
                    double Distance = line.getEnd().distanceFromZero();
                    MyPointUI.DisplayDistanceOfEndPoint(Distance);
                    
                }
                else if (option == 10)
                {
                    break;
                }
                else
                {
                    MenuUI.DiplayWrongOption();
                }
                MenuUI.SystemCls();

            } while (true);
        
        
        
        
        
        }
    }
}
