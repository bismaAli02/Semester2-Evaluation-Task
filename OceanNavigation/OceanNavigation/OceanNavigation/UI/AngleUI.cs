using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;

namespace OceanNavigation.UI
{
    class AngleUI
    {

        public static Angle takeInputforLongitude()
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enter Positions for Longitude: \n");
                Console.Write("Enter Position in degrees: ");
                int degrees = int.Parse(Console.ReadLine());
                Console.Write("Enter Position in minutes: ");
                float minutes = float.Parse(Console.ReadLine());
                Console.Write("Enter Direction of ship: ");
                char direction = char.Parse(Console.ReadLine());
                if (ValidationforLongitude(degrees, minutes, direction))
                {
                    Angle Longitude = new Angle(degrees, minutes, direction);
                    return Longitude;
                }
                else
                {
                    Console.WriteLine("please enter valid position");
                    MenuUI.systemCls();
                }
            }
        }

        public static Angle takeInputforLatitude()
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enter Positions for Latitude: \n");
                Console.Write("Enter Position in degrees: ");
                int degrees = int.Parse(Console.ReadLine());
                Console.Write("Enter Position in minutes: ");
                float minutes = float.Parse(Console.ReadLine());
                Console.Write("Enter Direction of ship: ");
                char direction = char.Parse(Console.ReadLine());
                if (ValidationforLatitude(degrees, minutes, direction))
                {
                    Angle Latitude = new Angle(degrees, minutes, direction);
                    return Latitude;
                }
                else
                {
                    Console.WriteLine("please enter valid position");
                   
                }
            }
        }

           
        
        public static string serialNum()
        {
            Console.Write("Enter ship's serial number: ");
            string serialNum = Console.ReadLine();
            return serialNum;
        }


        public static bool ValidationforLongitude(int degrees, float minutes, char direction)
        {
            if (degrees >= 0 && degrees <= 180 && minutes >= 0 && minutes <= 59 && (direction == 'W' || direction == 'E'))
            {
                return true;
            }
            return false;
        }

        public static bool ValidationforLatitude(int degrees, float minutes, char direction)
        {
            if (degrees >= 0 && degrees <= 90 && minutes >= 0 && minutes <= 59 && (direction == 'S' || direction == 'N'))
            {

                return true;
            }
            return false;
        }





        public static void ChangePosition()
        {
            int count = 0;

            string serNo = serialNum();
            foreach (Ship s in ShipDL.ship)
            {
                if (s.getSerialNum() == serNo)
                {
                    count++;
                    s.setLatitude(takeInputforLatitude());
                    s.setLongitude(takeInputforLongitude());
                    Console.WriteLine("Position is changed");
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no ship available of this serial number");

            }
        }
    }
}
