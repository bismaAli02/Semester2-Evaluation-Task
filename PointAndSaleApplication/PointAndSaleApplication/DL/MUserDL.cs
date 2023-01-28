using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using PointAndSaleApplication.BL;

namespace PointAndSaleApplication.DL
{
    class MUserDL
    {
        public static List<MUser> Users = new List<MUser>();



        public static void AddUserIntoList(MUser user)
        {
            Users.Add(user);
        }

        public static MUser IsUserAvailable(MUser user)
        {
            foreach(MUser u in Users)
            {
                if(user.GetUserName()== u.GetUserName() && user.GetPassword() == u.GetPassword())
                {
                    return u;
                }
                
            }

            return null;
        }

        public static bool LoadDataFromFile()
        {
            string path = "Users.txt";
            if (File.Exists(path))
            {
                StreamReader user = new StreamReader(path);
                string record;

                while ((record = user.ReadLine()) != null)
                {
                    string[] splitRecord = record.Split(',');
                    string UserName = splitRecord[0];
                    string password = splitRecord[1];
                    string role =  splitRecord[2];
                    MUser u = new MUser(UserName, password, role);
                    AddUserIntoList(u);
                    if(role == "Customer" || role == "customer")
                    {
                        Customer cust = new Customer(UserName, password);
                        CustomerDL.AddCustomerIntolist(cust);
                    }
                }
                user.Close();
                return true;
            }
            return false;
        }

        public static void StoreDataIntoFile(MUser user)
        {
            string path = "Users.txt";
            StreamWriter u= new StreamWriter(path, true);
            u.Write(user.GetUserName() + "," + user.GetPassword() + "," + user.GetRole());
            u.Flush();
            u.Close();
        }

        public static bool ValidationOnUser(MUser user)
        {
            foreach (MUser u in Users)
            {
                if (user.GetUserName() == u.GetUserName() && user.GetPassword() == u.GetPassword())
                {
                    return false;
                }

            }

            return true;
        }

    }
}

        




