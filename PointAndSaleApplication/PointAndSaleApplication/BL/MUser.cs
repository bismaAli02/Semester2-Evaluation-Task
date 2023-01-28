using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndSaleApplication.DL;

namespace PointAndSaleApplication.BL
{
    class MUser
    {
      public MUser(string UserName, string password, string role)
        {
            this.UserName = UserName;
            this.password = password;
            this.role = role;
        }

        public MUser(string UserName, string password)
        {
            this.UserName = UserName;
            this.password = password;
            this.role = null;
        }



      private string UserName;
      private string password;
      private string role;
        
    
        public string GetUserName()
        {
            return UserName;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetRole()
        {
            return role;
        }



    }
}
