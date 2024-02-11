using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float AmountOfSales;
            float ticketPrice = 10.99f;
            float goal = 40000f;

            try
            {
                AmountOfSales = int.Parse(textBox1.Text);
                if (AmountOfSales * ticketPrice > goal)
                {
                    MessageBox.Show((AmountOfSales * ticketPrice).ToString());
                    textBox2.Text = "Sales Are High";
                }
                else
                {
                    MessageBox.Show((AmountOfSales * ticketPrice).ToString());
                    textBox2.Text = "Sales Are Low";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
