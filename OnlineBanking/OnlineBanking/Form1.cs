using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bank natEast = new Bank();
        private string userName;
        private string passWord;
        private decimal initialBalance;
        private Customer customer;

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            //Input new customer info
            userName = txtUserName.Text;
            passWord = txtPassword.Text;
            initialBalance = decimal.Parse(txtInitialBalance.Text);

            natEast.RegisterCustomer(userName, passWord, initialBalance);



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtLoginUsername.Text;
            passWord = txtLoginPassword.Text;

            customer = natEast.GetCustomer(userName);

            if (passWord == customer.Password)
            {
                customer.Login();
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }

        private void btnGetCustomerBalance_Click(object sender, EventArgs e)
        {
            //Display customer account balance
            Account account = customer.GetAccount();
            MessageBox.Show(account.Balance.ToString());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Make a deposit to customer account
            Account account = customer.GetAccount();
            account.Deposit(decimal.Parse(txtDeposit.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Account account = customer.GetAccount();
            account.Withdraw(decimal.Parse(txtDeposit.Text));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            customer.Logout();
            groupBox1.Visible = false;
        }
    }
}
