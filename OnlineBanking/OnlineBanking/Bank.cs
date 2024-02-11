using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    class Bank
    {
        private Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
        private int nextAccountNumber = 0;

        public void RegisterCustomer(string userName, string passWord, decimal initialBalance)
        {
            //Create an account
            Account tempAccount = new Account(initialBalance, nextAccountNumber++);
            //Create the customer
            Customer tempCustomer = new Customer(userName, passWord, tempAccount);
            //Add the customer to the customers Dictionary
            //Use Add method of dictionary:
            //customers.Add(userName, tempCustomer);
            //Or use array-like syntax
            customers[userName] = tempCustomer;

        }

        public Customer GetCustomer(string userName)
        {
            //Get the customer from the dictionary
            return customers[userName];
        }


    }
}
