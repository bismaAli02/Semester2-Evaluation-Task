using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameObject.BL;

namespace GameObject
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundry b = new Boundry(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObj g1 = new GameObj(triangle, new Point(5, 5), b, "LeftToRight");
            GameObj g2 = new GameObj(optriangle, new Point(30, 60), b, "RightToLeft");
            List<GameObj> list = new List<GameObj>();
            list.Add(g1);
            list.Add(g2);
            while(true)
            {
                Thread.Sleep(100);
                
                foreach(GameObj g in list)
                {
                    g.Erase();
                    g.Move();
                    g.Draw();
                }
            }
        
        
        }
    }
}
