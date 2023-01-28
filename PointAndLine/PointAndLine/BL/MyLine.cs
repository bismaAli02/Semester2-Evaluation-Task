using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLine.BL
{
    class MyLine
    {
        public MyLine()
        {

        }
        
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        private MyPoint begin;
        private MyPoint end;
    
        public MyPoint getBegin()
        {
            return begin;
        }

        public MyPoint getEnd()
        {
            return end;
        }

        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }

        public void setEnd(MyPoint end)
        {
            this.end = end;
        }

        public double getLenght()
        {
            return Math.Sqrt(Math.Pow((begin.getX() - end.getX()), 2) + Math.Pow((begin.getY() - end.getY()), 2));
        }

        public double getGradient()
        {
            return (end.getY() - begin.getY()) / (end.getX() - begin.getX());
        }
    }
}
