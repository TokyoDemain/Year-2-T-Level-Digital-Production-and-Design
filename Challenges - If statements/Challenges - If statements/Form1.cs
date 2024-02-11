using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenges___If_statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float numberOfItems;
            string customerName;
            string vanType;

            numberOfItems = float.Parse(txtItemInput.Text);
            customerName = txtCustomerName.Text;
            if (numberOfItems > 30)
            {
                vanType = "Large Van is Required for " + customerName + "'s delivery";
            }
            else
            {
                vanType = "Small Van is Required for " + customerName + "'s delivery";
            }

            txtVanSize.Text = vanType;

        }
    }
}
