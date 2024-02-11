using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenges___Switches
{
    public partial class Form1 : Form
    {
        // creates a variable for the seasons
        public int season = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creates a float for days
            float days;
            //takes the float from the text box
            days = float.Parse(txtEnterDays.Text);
            //creates an if statement to test if the amount of days 
            if (days <= 0)
            {
                txtOutput.Text = ("Please Enter An Amount Of Days");
            }
            //creates a if statement to test if the season has been inputted
            if (season == 0)
            {
                txtOutput.Text = ("Please Press A Button To Select The Season");
            }
            //creates an if statement to do the multiplication and output it to the text box
            if(season == 1)
            {
                days = days * 29;
                string daysString;
                daysString = days.ToString();
                txtOutput.Text = daysString;
            }
            //creates an if statement to do the multiplication and output it to the text box
            if (season == 2)
            {
                days = days * 22;
                string daysString;
                daysString = days.ToString();
                txtOutput.Text = daysString;
            }
            //creates an if statement to do the multiplication and output it to the text box
            if (season == 3)
            {
                days = days * 17;
                string daysString;
                daysString = days.ToString();
                txtOutput.Text = daysString;
            }
            //creates an if statement to do the multiplication and output it to the text box
            if (season == 4)
            {
                days = days * 14;
                string daysString;
                daysString = days.ToString();
                txtOutput.Text = daysString;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSummer_Click(object sender, EventArgs e)
        {
            //defines the season to be summer
            season = 1;
        }

        private void btnAutumn_Click(object sender, EventArgs e)
        {
            //defines the season to be autumn
            season = 2;
        }

        private void btnWinter_Click(object sender, EventArgs e)
        {
            //defines the season to be winter
            season = 3;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSpring_Click(object sender, EventArgs e)
        {
            //defines the season to be spring
            season = 4;
        }
    }
}
