using HMS_Solution.Forms.LoginForm;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Solution.DAL
{
    internal class UserRepository
    {
        public static int Login(string username, string password)
        {
            HMSDataContext db = new HMSDataContext();
            return (int)db.userLogin(username, password).ReturnValue;
        }
        public static int addUser(string name, string username, string password, string role, string email = null, string phone = null, string status = null)
        {
            HMSDataContext db = new HMSDataContext();

            return db.insertIntoUser(name, username, password, role, email, phone, status);
        }

        public static int updateUser(int ID, string name, string username, string password, string role, string email = null, string phone = null, string status = null)
        {
            HMSDataContext db = new HMSDataContext();

            return db.updateUser(ID, name, username, password, role, email, phone, status);
        }

        public static bool userExists(int ID)
        {
            HMSDataContext db = new HMSDataContext();
            return db.users.Any(x => x.userID == ID);
        }

        public static int deleteUser(int ID)
        {
            HMSDataContext db = new HMSDataContext();
            return db.deleteUser(ID);
        }




    }
}
