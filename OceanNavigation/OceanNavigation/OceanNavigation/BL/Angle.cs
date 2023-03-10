using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OceanNavigation.BL
{
    class Angle
    {
        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }
        
        
        
        private int degrees;
        private float minutes;
        private char direction;
    

       public  int getDegrees()
        {
            return degrees;
        }

        public float getMinutes()
        {
            return minutes;
        }

        public char getDirection()
        {
            return direction;
        }

        public void setDegrees(int degrees)
        {
            this.degrees = degrees;
        }

        public void setMinutes(float minutes)
        {
            this.minutes = minutes;
        }

        public void setDirection(char direction)
        {
            this.direction = direction;
        }
        public void ChangeAngle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public string DisplayPosition()
        {
            return ( degrees + "\u00b0" + minutes + "\'" + direction);
        }
    }
}
