using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelApp
{
    
    public partial class Form1 : Form
    {
        Checks checks = new Checks();
        Hotel hotel = new Hotel();
        

        public void refresh()
        {
            listBox1.Items.Clear();
            Dictionary<int, bool> availablilityCheck = new Dictionary<int, bool>();
            List<string> messages = new List<string>();
            List<float> Breakfast = new List<float>();
            availablilityCheck = hotel.ReportOnAllRooms();
            int i = 1;
            while (i <= 40)
            {
                if (availablilityCheck[i] == false)
                {
                    messages.Add("Room" + i + " is available");
                    string temp = messages[i - 1];
                    listBox1.Items.Add(temp);
                    i = i + 1;
                }
                else
                {
                    messages.Add("Room" + i + " is not available");
                    string temp = messages[i - 1];
                    listBox1.Items.Add(temp);
                    i = i + 1;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            gbVacateRoom.Visible = false;
            GbBookRoom.Visible = false;
            GbCountCustomers.Visible = false;
            gbShowIncome.Visible = false;
            GbReportOnCustomer.Visible = false;
            refresh();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void gbVacateRoom_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnReportOnRoom_Click(object sender, EventArgs e)
        {
            GbReportOnCustomer.Visible=true;
            gbVacateRoom.Visible = false;
            GbBookRoom.Visible = false;
            GbCountCustomers.Visible = false;
            gbShowIncome.Visible = false;
            refresh();
        }

        private void GbBookRoom_Enter(object sender, EventArgs e)
        {

        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            GbBookRoom.Visible=true;
            gbVacateRoom.Visible = false;
            GbCountCustomers.Visible = false;
            gbShowIncome.Visible = false;
            GbReportOnCustomer.Visible = false;
            refresh();
        }

        private void btnVacateRoom_Click(object sender, EventArgs e)
        {
            gbVacateRoom.Visible=true;
            GbBookRoom.Visible = false;
            GbCountCustomers.Visible = false;
            gbShowIncome.Visible = false;
            GbReportOnCustomer.Visible = false;
            refresh();
        }

        private void btnCountCustomers_Click(object sender, EventArgs e)
        {
            GbCountCustomers.Visible=true;
            gbVacateRoom.Visible = false;
            GbBookRoom.Visible = false;
            gbShowIncome.Visible = false;
            GbReportOnCustomer.Visible = false;
            txtCountCustomers.Text =  (hotel.count).ToString();
            refresh();
        }

        private void btnShowIncome_Click(object sender, EventArgs e)
        {
            gbShowIncome.Visible=true;
            gbVacateRoom.Visible = false;
            GbBookRoom.Visible = false;
            GbCountCustomers.Visible = false;
            GbReportOnCustomer.Visible = false;
            txtShowIncome.Text = hotel.ShowIncome().ToString();
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerNameReport.Text;
            if (checks.StringPresense(customerName) == true)
            {
                int roomNumber = hotel.ReportOnName(customerName);
                if (roomNumber != 0)
                {
                    txtReportOnName.Text = roomNumber.ToString();
                }
                else
                {
                    txtReportOnName.Text = ("This customer does not exist");
                }
            }
            else 
            {
                MessageBox.Show("An Error Occured");
            }
            refresh();
        }

        private void btnVacate_Click(object sender, EventArgs e)
        {
            bool check = hotel.VacateRoom(txtCustomerNameVacate.Text);
            if (check == false)
            {
                MessageBox.Show("An Error Occurred");
            }
            refresh();
        }

        private void btnBookRoomBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (checks.StringPresense(txtCustomerNameBook.Text) == true & checks.StringPresense(txtRoomNumberBook.Text) == true)
                {
                    bool check = hotel.BookRoom(int.Parse(txtRoomNumberBook.Text), txtCustomerNameBook.Text);
                    if (check == false)
                    {
                        MessageBox.Show("An Error Occurred");
                    }
                }
                else
                {
                    MessageBox.Show("ERR: MISSING DATA");
                }
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: '{ex.Message}'");
            }
           
        }

        private void btnRoomAvailablility_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Dictionary<int, bool> availablilityCheck = new Dictionary<int, bool>();
            List <string> messages = new List<string>();
            availablilityCheck = hotel.ReportOnAllRooms();
            int i = 1;
            while (i <= 40)
            {
                if (availablilityCheck[i] == false)
                {
                    messages.Add("Room" + i + " is available");
                }
                else
                {
                    messages.Add("Room" + i + " is not available");
                }
                string temp = messages[i-1];
                listBox1.Items.Add(temp);
                i = i + 1;
            }

            
        }

        private void txtCustomerNameVacate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerNameVacate_Enter(object sender, EventArgs e){}

    }
}
