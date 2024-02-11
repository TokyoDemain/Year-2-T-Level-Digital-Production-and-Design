using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenges___Calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            //defines vaiables
            float originalPrice;
            float discountPercentage;
            double finalPrice;
            double totalDiscount;


            //pulls data from the text boxes
            originalPrice = float.Parse(txtOriginalPrice.Text);
            discountPercentage = float.Parse(txtDiscountPercent.Text);


            //calculates final price and discount amount
            finalPrice = originalPrice - (originalPrice * (discountPercentage * 0.01));
            totalDiscount = originalPrice - finalPrice;
            txtFinalPrice.Text = finalPrice.ToString();
            txtTotalDiscount.Text = totalDiscount.ToString();


        }
    }
}
