using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    class Customer
    {
        private string userName;
        private string passWord;
        private Account account;
        private bool isLoggedIn;

        public Customer(string userName, string passWord, Account account)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.account = account; // account is created by Bank and passed to Customer

        }

        

        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }


        public void Login()
        {
            isLoggedIn = true;
        }

        public void Logout()
        {
            isLoggedIn = false;
        }

        public Account GetAccount()
        {
            return account;
        }


    }
}
