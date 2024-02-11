using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            float result = calculator.addition(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));
            txtOut.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            float result = calculator.subtract(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));
            txtOut.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            float result = calculator.multiply(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));
            txtOut.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            float result = calculator.divide(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));
            txtOut.Text = result.ToString();
        }
    }
}
