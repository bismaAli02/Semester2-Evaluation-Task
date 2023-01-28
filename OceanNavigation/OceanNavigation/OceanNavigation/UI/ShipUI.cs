using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;

namespace OceanNavigation.UI
{
    class ShipUI
    {
        public static Ship AddShip()
        {
            string serialNum;
            while (true)
            {
                serialNum = AngleUI.serialNum();
                if (ShipDL.FindShip(serialNum) == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You already assign this serial number to another ship");
                    MenuUI.systemCls();
                    
                }
            }
                Angle Longitude = AngleUI.takeInputforLongitude();
                Angle Latitude = AngleUI.takeInputforLatitude();
                Ship s = new Ship(serialNum, Longitude, Latitude);
                return s;
         }


        public static void GetSerialNum()
        {
            Angle Longitude = AngleUI.takeInputforLongitude();
            Angle Latitude = AngleUI.takeInputforLatitude();

            bool IsAvailable = false;
            foreach (Ship p in ShipDL.ship)
            {
                if (p.getLongitude().DisplayPosition() == Longitude.DisplayPosition() && p.getLatitude().DisplayPosition() == Latitude.DisplayPosition())
                {
                    diplaySerialNum(p);
                    IsAvailable = true;
                    break;
                }
            }
            if (IsAvailable != true)
            {
                Console.WriteLine("no ship Available at this position");
            }
        }

        public static void Position(Ship s)
        {
            Console.WriteLine("Longitud of a ship: " + s.getLongitude().DisplayPosition());
            Console.WriteLine("Latitude of a ship: " + s.getLatitude().DisplayPosition());
        }

        public static void diplaySerialNum(Ship s)
        {
            Console.WriteLine("serial number of ship: " + s.getSerialNum());
        }

        public static void ViewShipPosition()
        {
            string serialNum = AngleUI.serialNum();
            int idx = ShipDL.FindShip(serialNum);
            if (idx != -1)
                Position(ShipDL.ship[idx]);
            else
                Console.WriteLine("no ship Available of this serial number");
        }









    }
}
