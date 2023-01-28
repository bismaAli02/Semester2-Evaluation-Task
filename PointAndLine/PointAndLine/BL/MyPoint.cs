using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLine.BL
{
    class MyPoint
    {
        public MyPoint(int x, int y)
        {
            this.x=x;
            this.y=y;
        }

        public MyPoint()
        {
            x = 0;
            y = 0;
        }


        private int x;
        private int y;
        
        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y =y;
        }

        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public double distanceWithCord(int x, int y)
        {
            return Math.Sqrt(Math.Pow((this.x-x),2)+ Math.Pow((this.y - y), 2)) ;
        }

        public double distanceWithObject(MyPoint anotherPoint)
        {

            return Math.Sqrt(Math.Pow((this.x - anotherPoint.x), 2) + Math.Pow((this.y - anotherPoint.y), 2));

        }

        public double distanceFromZero()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));

        }
    }

}