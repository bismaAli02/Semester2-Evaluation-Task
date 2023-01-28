using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class Boundry
    {
        public Boundry()
        {
            TopLeft = new Point();
            TopRight = new Point(0, 90);
            BottomLeft = new Point(90, 0);
            BottomRight = new Point(90, 90);
        }


        public Boundry(Point TopLeft, Point TopRight, Point BottomLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }


        private Point TopLeft;
        private Point TopRight;
        private Point BottomLeft;
        private Point BottomRight;
    
    
        public Point GetTopLeft()
        {
            return TopLeft;
        }

        public Point GetTopRight()
        {
            return TopRight;
        }

        public Point GetBottomLeft()
        {
            return BottomLeft;
        }

        public Point GetBottomRight()
        {
            return BottomRight ;
        }

        public void setTopLeft(Point TopLeft)
        {
            this.TopLeft = TopLeft; ;
        }

        public void setTopRight(Point TopRight)
        {
            this.TopRight = TopRight; ;
        }

        public void setBottomLeft(Point BottomLeft)
        {
            this.BottomLeft = BottomLeft;
        }

        public void setBottomRight(Point BottomRight)
        {
            this.BottomRight = BottomRight;
        }
    }
}
