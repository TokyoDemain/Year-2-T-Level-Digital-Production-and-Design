namespace Challenges___For_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool btnRunCode_Click(object sender, EventArgs e)
        {
            string name;
            int i;
            name = txtEnterName.Text;
            i = 0;
            for (i = 0; i < 10;)
            {
                txtEnterName.Text = name;
                i++;
            }
        }
    }
}