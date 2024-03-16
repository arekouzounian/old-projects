using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekLogin
{
    class Account
    {
        public Account(string username, string password, double moneyAmount)
        {
            Username = username;
            Password = password;
            Money = moneyAmount;
        }


        public string Username;
        public string Password;
        public double Money;
    }
}
