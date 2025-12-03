using HMS_Solution.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HMS_Solution.BLL
{
    internal class UserService
    {
        public static int ValidateLogin(string username, string password)
        {
            if(!username.All(char.IsLetterOrDigit))
            {
                throw new Exception("Username cannot contain symbols or special characters");
            }
            if(password.Length < 8)
            {
                throw new Exception("Password cannot be less then 8 characters");
            }

            return UserRepository.Login(username, password); // create this function to call to DB from DAL folder

        }
        
        private static bool isValidPassword(string password)
        {
            if (password.Length < 8)
            {
                throw new Exception("Passwords cannot be less than 8 characters");
            }

            bool hasSymbol = password.Any(ch => !char.IsLetterOrDigit(ch));

            if ( ! hasSymbol)
            {
                throw new Exception("Password must contain symbol(s).");
            }
            return true;
        }

        private static bool validateUserDetails(string name, string username, string password, string confirmPass, string role)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPass) || (role != "admin" && role != "doctor" && role != "receptionist" && role != "accountant"))
            {
                throw new Exception("Below fields are required to add a user.\n1. Name\n2. Username\n3. Password\n4. Confirm password\n5. Role");
            }
            if (name.Length < 3)
            {
                throw new Exception("Names cannot be less than 3 characters");
            }

            isValidPassword(password);

            if (!string.Equals(password, confirmPass))
            {
                throw new Exception("Passwords donot match. Please confirm password");
            }

            return true;
        }
        
        public static int validateAddUser(string name, string username, string password, string confirmPass, string role, string email = null, string phone = null, bool status = false)
        {
            validateUserDetails(name, username, password, confirmPass, role);
            string _status = "active";
           
            if (status == true)
            {
                _status = "non active";
            }

            return UserRepository.addUser(name, username, password, role, email, phone, _status);
        }

        public static int validateUpdateUser(string ID, string name, string username, string password, string confirmPass, string role, string email = null, string phone = null, bool status = false)
        {
            validateUserDetails(name, username, password, confirmPass, role);
            string _status = "active";

            if (status == true)
            {
                _status = "non active";
            }
            return UserRepository.updateUser(int.Parse(ID), name, username, password, role, email, phone, _status);
        }

        public static int validateDeleteUser(string id)
        {
            if(string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException("Please enter ID");
            }
            if( ! int.TryParse(id, out int ID))
            {
                throw new ArgumentException("Please enter valid integer ID");
            }
            if( ! UserRepository.userExists(ID))
            {
                throw new ArgumentException("User doest not exists. Enter correct ID");
            }

            return UserRepository.deleteUser(ID);
        }
    
    
    
    }
}
