using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    class Ship
    {
        public Ship(string serialNum, Angle Longitude, Angle Latitude)
        {
            this.serialNum = serialNum;
            this.Longitude = Longitude;
            this.Latitude = Latitude;

        }


        private string serialNum;
        private Angle Longitude;
        private Angle Latitude;

        public string getSerialNum()
        {
            return serialNum;
        }

        public Angle getLongitude()
        {
            return Longitude;
        }

        public Angle getLatitude()
        {
            return Latitude;
        }

        public void setSerialNum(string serialNum)
        {
            this.serialNum = serialNum;
        }

        public void setLongitude(Angle Longitude)
        {
            this.Longitude = Longitude;
        }

        public void setLatitude(Angle Latitude)
        {
            this.Latitude = Latitude;
        }
    }
}
