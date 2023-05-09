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
    public partial class Staffuse : Form
    {
        public Staffuse()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Staffuse_Load(object sender, EventArgs e) {
            // Create a connection to the database
            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");

            // Create a command to retrieve the data
            SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // Open the connection and retrieve the data
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void goodReceived_Click(object sender, EventArgs e)
        {
            Create_Goods_Received create = new Create_Goods_Received();
            create.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goods_Delivery_Note create = new Goods_Delivery_Note();
            create.Show();
            this.Hide();
        }

        private void bView_Click(object sender, EventArgs e)
        {
            View_Report create = new View_Report();
            create.Show();
            this.Hide();
        }
    }
}
