using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation
{
    class Program
    {


        static void Main(string[] args)
        {
            string path = "ship.txt";
            if (ShipDL.ReadDataFromFile(path))
            {
                MenuUI.Load();
            }
            else
            {
                MenuUI.UnLoad();
            }

            while (true)
            { 
                char option = MenuUI.menu();
                MenuUI.systemCls();
                MenuUI.header();
                if (option == '1')
                {
                    Ship s = ShipUI.AddShip();
                    ShipDL.AddShipInList(s);
                    ShipDL.StoreIntoFile(path);
                }
                else if (option == '2')
                {
                    ShipUI.ViewShipPosition();
                }
                else if (option == '3')
                {
                    ShipUI.GetSerialNum();
                }
                else if (option == '4')
                {
                    AngleUI.ChangePosition();
                    ShipDL.StoreIntoFile(path);
                }
                else if (option == '5')
                {
                    break;
                }
                else
                {
                    MenuUI.WrongOption();
                }
                MenuUI.systemCls();
            }

        }
    }
}
