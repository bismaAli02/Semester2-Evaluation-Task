using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.DL;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.UI
{
    class MUserUI
    {

        public static MUser SignUp()
        {
            Console.WriteLine("Enter Your name: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role: ");
            string role = Console.ReadLine();
            MUser user = new MUser(UserName, password, role);
            if (MUserDL.ValidationOnUser(user))
            {
                return user;
            }
            return null;

        }


        public static void MsgDisplay()
        {
         Console.WriteLine("This username and Password are already in used");
        }
     
        public static MUser SignIn()
        {
            Console.WriteLine("Enter Your name: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            MUser user = new MUser(UserName, password);
            return MUserDL.IsUserAvailable(user);
        }

        



    }
}
