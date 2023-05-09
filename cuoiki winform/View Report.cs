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
    public partial class View_Report : Form
    {
        public View_Report()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bIncome_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT IDProducts ,SUM(quantity) as Quantity FROM DetailsWarehouseReceipt,WarehouseReceipt where MONTH(dayreceive) = @month and DetailsWarehouseReceipt.IDReceipt=WarehouseReceipt.id  group by IDProducts order by CAST(IDProducts as int)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@month", month);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }

        private void View_Report_Load(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            txtMonth.Select();
        }

        private void bEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bOut_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT idProducts,nameProducts,SUM(quantity) as Quantity FROM DetailsDeliveryNote,DeliveryNote where MONTH(dayDelivery) = @month and DetailsDeliveryNote.idNote=DeliveryNote.idNote  group by idProducts,nameProducts order by CAST(idProducts as int)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@month", month);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT top 5 idProducts,nameProducts,SUM(quantity) as Total_Sold FROM DetailsDeliveryNote,DeliveryNote where MONTH(dayDelivery) = @month and DetailsDeliveryNote.idNote=DeliveryNote.idNote  group by idProducts,nameProducts order by Total_Sold desc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@month", month);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }

        private void bRe_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "select month,salesmoney,importmoney, salesmoney - importmoney as Revenue from Revenue where month = @month";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@month", month);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
         }
    }
}