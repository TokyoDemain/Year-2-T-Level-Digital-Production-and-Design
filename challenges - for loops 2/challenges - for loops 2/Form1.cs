namespace challenges___for_loops_2
{
    public partial class Form1 : Form
    {

        public string newText;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun_Click(sender, e, txtOut);
        }

        private void btnRun_Click(object sender, EventArgs e, TextBox txtOut)
        {
            string name;
            int i;
            name = txtEnter.Text;
            i = 0;
            newText = name;
            for (i = 0; i < 9;)
            {
                newText = newText + "  " + name;
                i++;
            }

            txtOut.Text = newText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}