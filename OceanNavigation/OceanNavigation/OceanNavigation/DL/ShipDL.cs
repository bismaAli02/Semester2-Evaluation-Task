using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using OceanNavigation.BL;
namespace OceanNavigation.DL
{
    class ShipDL
    {
        public static List<Ship> ship = new List<Ship>();
        public static void AddShipInList(Ship s)
        {
            ship.Add(s);
        }
        public static int FindShip(string serialNum)
        {
            for (int i = 0; i < ship.Count; i++)
            {
                if (serialNum == ship[i].getSerialNum())
                {
                    return i;
                }
            }
            return -1;
        }

        public static void StoreIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Ship s in ship)
            {
                string Longitude, Latitude;
                Latitude = s.getLatitude().getDegrees() + "," + s.getLatitude().getMinutes() + "," + s.getLatitude().getDirection();
                Longitude = s.getLongitude().getDegrees() + "," + s.getLongitude().getMinutes() + "," + s.getLongitude().getDirection();
                file.WriteLine(s.getSerialNum() + "," + Latitude + "," + Longitude);
            }
            file.Flush();
            file.Close();
        }


        public static bool ReadDataFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string serialNumber = splittedRecord[0];
                    int LatDegree = int.Parse(splittedRecord[1]);
                    float LatMinutes = float.Parse(splittedRecord[2]);
                    char LatDirection = char.Parse(splittedRecord[3]);

                    int LonDegree = int.Parse(splittedRecord[4]);
                    float LonMinutes = float.Parse(splittedRecord[5]);
                    char LonDirection = char.Parse(splittedRecord[6]);

                    Angle Longitude = new Angle(LonDegree, LonMinutes, LonDirection);
                    Angle Latitude = new Angle(LatDegree, LatMinutes, LatDirection);

                    Ship s = new Ship(serialNumber, Longitude, Latitude);
                    AddShipInList(s);
                }
                file.Close();
                return true;
            }
            return false;
        }

    }
}

