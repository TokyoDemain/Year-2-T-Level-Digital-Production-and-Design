using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDb2024
{
    public partial class DatabaseAccess : Form
    {
        public DatabaseAccess()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try { 
                string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2202787\\OneDrive - Middlesbrough College\\Documents\\2023 - 2024 C# Programming\\PeopleDb2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Use stored procedure

                SqlCommand command = new SqlCommand("CreateNewPersonRecord", sqlConnection);

                command.CommandType = CommandType.StoredProcedure;

                //Input name and age from form

                string name = txtName.Text;

                int age = int.Parse(txtAge.Text);

                string Address = txtAddress.Text;

                string TelephoneNumber = txtTelephoneNumber.Text;

                //Call stored procedure passing name and age as parameters

                command.Parameters.AddWithValue("@Name", name);

                command.Parameters.AddWithValue("@Age", age);

                command.Parameters.AddWithValue("@Address", Address);

                command.Parameters.AddWithValue("@TelephoneNumber", TelephoneNumber);

                //Open connection to database, execute stored procedure and close the connection

                sqlConnection.Open();

                command.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Saved");

                txtName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtTelephoneNumber.Text = "";

            }
            catch { MessageBox.Show("Error"); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtPeople.Text = "";
            List<Person> peopleList = new List<Person>();
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = C:\\Users\\M2202787\\OneDrive - Middlesbrough College\\Documents\\2023 - 2024 C# Programming\\PeopleDb2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetPersonDetails", sqlConnection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlConnection.Open();
            sd.Fill(dt);
            sqlConnection.Close();
            foreach(DataRow dr in dt.Rows)
            {
                peopleList.Add(
                    new Person()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Age = Convert.ToInt32(dr["Age"]),
                        Address = Convert.ToString(dr["Address"]),
                        TelephoneNumber = Convert.ToString(dr["TelephoneNumber"])
                    }
                );
            }
            foreach (Person person in peopleList)
            {
                txtPeople.AppendText(person.Id + "\t" + person.Name + "\t" + person.Age.ToString() + "\t" + person.Address + "\t" + person.TelephoneNumber + Environment.NewLine);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = C:\\Users\\M2202787\\OneDrive - Middlesbrough College\\Documents\\2023 - 2024 C# Programming\\PeopleDb2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sqlConnection = new SqlConnection( connectionString );
            SqlCommand cmd = new SqlCommand("DeletePerson", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            string Id = txtDeleteRecordId.Text;
            cmd.Parameters.AddWithValue("@ID", Id);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creates the connection string
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = C:\\Users\\M2202787\\OneDrive - Middlesbrough College\\Documents\\2023 - 2024 C# Programming\\PeopleDb2024\\PeopleDB2024.mdf; Integrated Security = True; Connect Timeout = 30";
            //initiates the connection to the database
            SqlConnection sqlConnection= sqlConnection = new SqlConnection( connectionString );
            //sets the command to be used
            SqlCommand command = new SqlCommand("UpdatePerson", sqlConnection);
            //shows that the command type is stored procedure
            command.CommandType = CommandType.StoredProcedure;
            //sets the variables from the form
            int Id = int.Parse(txtEnterIdUpdate.Text);
            string Name = txtEnterName.Text;
            int Age = int.Parse(txtEnterAge.Text);
            string Address = txtEnterAddress.Text;
            string TelephoneNumber = txtEnterTelephone.Text;
            //passes the perameters to the process
            command.Parameters.AddWithValue("@stdID", Id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@TelephoneNumber", TelephoneNumber);
            //starts the function
            sqlConnection.Open();
            //executes the command
            command.ExecuteNonQuery();
            //closes the function
            sqlConnection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
