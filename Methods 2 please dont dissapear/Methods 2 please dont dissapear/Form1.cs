using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_2_please_dont_dissapear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHypotCalc_Click(object sender, EventArgs e)
        {
            double hypot, a, b;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            hypot = Math.Sqrt(a*a + b*b);
            txtHypotOut.Text = hypot.ToString();
        }

        private void btnTaxiCalc_Click(object sender, EventArgs e)
        {
            double basefare, reccuringCost, distanceTraveled, output;
            basefare = 4.00;
            reccuringCost = 0.25;
            distanceTraveled = double.Parse(txtTaxiCalcIn.Text);
            output = basefare + (reccuringCost * ((distanceTraveled * 100) / 140));
            txtTaxiCalcOut.Text = output.ToString();
        }

        private void btnWeightCalculate_Click(object sender, EventArgs e)
        {
            double ounces, pounds, grams, kilos;
            ounces = double.Parse(txtOunces.Text);
            pounds = ounces / 16;
            grams = ounces * 28.35;
            kilos = grams / 1000;
            txtPounds.Text = pounds.ToString();
            txtKilos.Text = kilos.ToString();
            txtGrams.Text = grams.ToString();
        }

        private void btnCircleCalc_Click(object sender, EventArgs e)
        {
            double pi = 3.14159265358979323846;
            double radius = double.Parse(txtRadiusIn.Text);
            double circumferance, diameter, area;
            diameter = radius * 2;
            circumferance = 2 * radius * pi;
            area = pi * (radius * radius);
            txtDiameterOut.Text = diameter.ToString();
            txtCircumferanceOut.Text = circumferance.ToString();
            txtAreaOutput.Text = area.ToString();
        }

        private void btnDeptCalc_Click(object sender, EventArgs e)
        {
            double annualIncome, totalDepts;
            int FamilyIDNumber, NumberOfPeopleInFamily;
            annualIncome = double.Parse(txtAnnualIncome.Text);
            FamilyIDNumber = int.Parse(txtFamilyIDNum.Text);
            NumberOfPeopleInFamily = int.Parse(txtFamilyPopNum.Text);
            totalDepts = double.Parse(txtTotalDepts.Text);
            lstDeptOut.Items.Add("Family ID Functions: " + FamilyIDNumber.ToString());
            lstDeptOut.Items.Add("Living Expenses: " + NumberOfPeopleInFamily * 3000);
            lstDeptOut.Items.Add("Monthly Payment for no dept 1 year: " + totalDepts / 12);
            lstDeptOut.Items.Add("Save Amount: " + NumberOfPeopleInFamily * (0.02 * (annualIncome - totalDepts)));
            lstDeptOut.Items.Add("Service Fee: " +  annualIncome * 0.005);
        }

        private void lblAnnualIncome_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoiceCalc_Click(object sender, EventArgs e)
        {
            lstInvoiceOut.Items.Clear();
            int volumeOfProductsSold = int.Parse(txtSaleVolume.Text);
            float unitCostPerProduct = float.Parse(txtUnitCostProduct.Text);
            string productName = txtProductName.Text;
            bool onTime = cbWasPaidOnTime.Checked;
            bool VATRated = cbVATRated.Checked;

            double basicCost;
            basicCost = volumeOfProductsSold * unitCostPerProduct;
            lstInvoiceOut.Items.Add(productName);
            lstInvoiceOut.Items.Add("Basic Cost: " + (int)basicCost);
            if (VATRated == true)
            {
                basicCost = basicCost * 1.2;
                lstInvoiceOut.Items.Add("Cost With VAT: " + basicCost);
            }
            else
            {
                return;
            }
            if (onTime == true)
            {
                basicCost = basicCost * 0.9;
            }
            lstInvoiceOut.Items.Add("Final Cost: " + basicCost);
            lblThankYouMessage.Text = "THANK YOU";
        }

        private void lblWeightCalc_Click(object sender, EventArgs e)
        {

        }

        private void txtCircumferanceOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
