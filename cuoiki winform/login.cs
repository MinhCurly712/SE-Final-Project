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

namespace cuoiki_winform
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


        // Connect to the database
            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;integrated security = true");
            connection.Open();

            // Create a SELECT query to retrieve the staff member's record
            SqlCommand command = new SqlCommand("SELECT * FROM Staff WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", username);

            // Execute the query and read the results
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string storedPassword = reader.GetString(reader.GetOrdinal("Password"));

                // Check if the entered password matches the stored password
                if (password == storedPassword)
                {
                    // Login successful
                    MessageBox.Show("Login successful!");
                    Staffuse staffDashboard = new Staffuse();
                    staffDashboard.Show();
                    this.Hide();
                }
                else
                {
                    // Incorrect password
                    MessageBox.Show("Incorrect password.");
                }
            }
            else
            {
                // Staff member not found
                MessageBox.Show("Staff member not found.");
            }




            // Close the database connection and dispose of the objects
            reader.Close();
            command.Dispose();
            connection.Close();
        }
 
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }
    }
}
