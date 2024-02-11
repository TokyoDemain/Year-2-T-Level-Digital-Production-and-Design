using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    class Account
    {

        //attributes
        private int accountNumber;
        private decimal balance;

        //Balance as a property
        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public Account() //Constructor
        {
            accountNumber = 0;
            balance = 0;

        }
        public Account(decimal initialBalance, int number)
        {
            balance = initialBalance;
            accountNumber = number;

        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetBalance(decimal amount)
        {
            balance = amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

    }
}
