using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = "James Carrascal";
            this.user_name = "cashier1234";
            this.user_password = "qwerty123";
        }

        public abstract bool validateLogin(string uName, string password);
        public string getFullName()
        {
            return this.full_name;
        }
    }
}