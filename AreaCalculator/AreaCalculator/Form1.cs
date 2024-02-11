using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float roomLength;
            float roomWidth;
            float roomArea;

            roomLength = float.Parse(txtRoomLengthInput.Text);
            roomWidth = float.Parse(txtRoomWidthInput.Text);
            roomArea = roomLength * roomWidth;
            string roomAreaTemp = roomArea.ToString();
            txtRoomAreaOutput.Text = roomAreaTemp;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float roomLength;
            float roomWidth;
            float roomHeight;
            float roomVolume;

            roomLength = float.Parse(txtRoomLengthInput.Text);
            roomWidth = float.Parse(txtRoomWidthInput.Text);
            roomHeight = float.Parse(txtRoomHeightInput.Text);
            roomVolume = roomLength * roomWidth * roomHeight;
            string roomVolumeTemp = roomVolume.ToString();
            txtRoomVolumeOutput.Text = roomVolumeTemp;
        }
    }
}
