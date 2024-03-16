using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekLoginWFA
{
    class Account
    {
        public string Username;
        public string Password;
        public double Money;

        public Account(string user, string pass, double startMoney)
        {
            Username = user;
            Password = pass;
            Money = startMoney;
        }

        public bool Login(string user, string pass)
        {
            if(Username == user && Password == pass)
            {
                return true;
            }
            return false;
        }

        //deposit function
        public void Deposit(double amount)
        {
            Money += amount;
        }

        //withdrawal function

        public void Withdraw(double amount)
        {
            Money -= amount; 
        }
    }
}
