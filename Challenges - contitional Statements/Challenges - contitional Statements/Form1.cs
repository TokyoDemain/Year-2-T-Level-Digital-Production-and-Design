namespace Challenges___contitional_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creates a number
            int number;
            //reads the number from the textbox
            number = int.Parse(txtEnter.Text);
            //Creates a new float variable
            float numberFloat;
            //populates that float with the number taken from the text
            numberFloat = (float)number;
            //divides the float by 2
            float newnumberFloat = numberFloat / 2;
            //divides the int by 2
            int newnumber = number / 2;
            //creates an if statement to check if they are the same
            if (newnumber == newnumberFloat)
            {
                //outputs to the textbox that the number is even
                txtOutput.Text = ("the number is even");
            }
            else
            {
                //outputs to the textbox that the number is odd
                txtOutput.Text = ("The number is odd");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}