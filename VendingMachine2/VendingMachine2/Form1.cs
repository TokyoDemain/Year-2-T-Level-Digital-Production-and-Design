using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VendingMachingClass vendingMachingClassAccount = new VendingMachingClass();
        private void btnChocolate_Click(object sender, EventArgs e)
        {
            if (vendingMachingClassAccount.CheckChocolate() != 0)
            {
                vendingMachingClassAccount.BuyChocolate();
            }
            else
            {
                MessageBox.Show("no more stock");
            }
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            if (vendingMachingClassAccount.CheckWater()  != 0)
            {
                vendingMachingClassAccount.BuyWater();
            }
            else{
                MessageBox.Show("no more stock");
            }
        }

        private void btnCrisps_Click(object sender, EventArgs e)
        {
            if (vendingMachingClassAccount.CheckCrisps() != 0)
            {
                vendingMachingClassAccount.buyCrisps();
            }
            else
            {
                MessageBox.Show("no more stock");
            }
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            int a = vendingMachingClassAccount.CheckChocolate();
            int b = vendingMachingClassAccount.CheckWater();
            int c = vendingMachingClassAccount.CheckCrisps();
            string a2 = a.ToString();
            string b2 = b.ToString();
            string c2 = c.ToString();
            txt.Text = "Chocolate: " + a2+ " Water: " + b2+ "   Crisps: " + c2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
