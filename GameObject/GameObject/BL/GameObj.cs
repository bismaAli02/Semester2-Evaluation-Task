using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class GameObj
    {
    
        public GameObj()
        {
            shape = new char[1, 3] { { '-', '-', '-' } };
            StartingPoint = new Point();
            permises = new Boundry();
            direction = "LeftToRight";
        }
        public GameObj(char[,]shape, Point StartingPoint)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            permises = new Boundry();
            direction = "LeftToRight";
        }

        public GameObj(char[,]shape, Point StartingPoint, Boundry permises, string direction)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            this.permises = permises;
            this.direction = direction;
        }
        private char[,] shape;
        private Point StartingPoint;
        private Boundry permises;
        private string direction;
        private int PatrolCount=1;
        private int projectileCount;

        
        public Point GetStartingPoint()
        {
            return StartingPoint;
        }

        public Boundry GetPermises()
        {
            return permises;
        }

        public string GetDirection()
        {
            return direction;
        }



        public void setStartingPoint(Point StartingPoint)
        {
            this.StartingPoint = StartingPoint ;
        }

        public void setPermises(Boundry permises)
        {
            this.permises= permises;
        }

        public void setDirection(string direction)
        {
            this.direction= direction;
        }











        public void Erase()
        {
            for (int i = StartingPoint.getX(); i < StartingPoint.getX() + 5; i++)
            {
                for (int j = StartingPoint.getY(); j < StartingPoint.getY() + 3; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
            }
        }

        public void Draw()
        {
            int x = 0, y = 0;
            for (int i = StartingPoint.getX(); i < StartingPoint.getX() + 5; i++ )
            {
                
                for(int j= StartingPoint.getY(); j < StartingPoint.getY()+3; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(shape[x, y]);
                    y++;
                }
                x++;
                y = 0;
            }
        }

        public void Move()
        {
            if(direction == "LeftToRight")
            {
                int startPoint;
                if(StartingPoint.getY() != 90)
                {
                   startPoint= StartingPoint.getY();
                    StartingPoint.setY(startPoint+1);
                }

            }
            else if(direction == "RightToLeft")
            {
                int startPoint;
                if (StartingPoint.getY() != 0)
                {
                    startPoint = StartingPoint.getY();
                    StartingPoint.setY(startPoint - 1);
                }
            
            }
            else if(direction == "Diagonal")
            {
                int xPoint;
                int yPoint;
                if(StartingPoint.getY() != 90 || StartingPoint.getY() != 90)
                {
                   yPoint= StartingPoint.getY();
                   xPoint= StartingPoint.getX();
                   StartingPoint.setY(yPoint + 1);
                   StartingPoint.setX(xPoint + 1);
                    
                }
            }
            else if (direction == "Patrol")
            {
                if (PatrolCount == 1)
                    StartingPoint.setY(StartingPoint.getY() - 1);
                if (PatrolCount == 2)
                    StartingPoint.setY(StartingPoint.getY() + 1);
                if (StartingPoint.getY() == permises.GetBottomLeft().getY())
                    PatrolCount = 2;
                if (StartingPoint.getY() == permises.GetBottomRight().getY())
                    PatrolCount = 1;
            }
            else if (direction == "Projectile")
            {
                if(projectileCount >=0 && projectileCount <=5)
                {
                    StartingPoint.setY(StartingPoint.getY() + 1);
                    StartingPoint.setX(StartingPoint.getX() - 1);
                }
                if (projectileCount == 6 || projectileCount == 7)
                {
                    StartingPoint.setY(StartingPoint.getY() + 1);
                }
                if (projectileCount >= 8 && projectileCount <= 11)
                {
                    StartingPoint.setX(StartingPoint.getX() + 1);
                    StartingPoint.setY(StartingPoint.getY() + 1);
                }
                projectileCount++;
                if(projectileCount == 11)
                {
                    projectileCount = 0;
                }
            }

        }
    
    }
}
