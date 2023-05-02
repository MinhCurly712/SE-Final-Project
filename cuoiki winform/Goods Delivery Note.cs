using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuoiki_winform
{
    public partial class Goods_Delivery_Note : Form
    {
        public Goods_Delivery_Note()
        {
            InitializeComponent();
        }

        private void Goods_Delivery_Note_Load(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            DateTime Day = dtDay.Value;
            int totalcost;
            if (!int.TryParse(txtTotalcost.Text, out totalcost))
            {
                MessageBox.Show("Please enter a details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int totalquantity = int.Parse(txtTotalquantity.Text);
            string agent = txtAgent.Text;
            string idnote = txtIDnote.Text;
            string idproduct = txtIDPro.Text;
            string productname = txtName.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int unitcost = int.Parse(txtUnit.Text);


            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please enter a ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(idproduct))
            {
                MessageBox.Show("Please enter a ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(productname))
            {
                MessageBox.Show("Please enter a product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(agent))
            {
                MessageBox.Show("Please enter a agent name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(idnote))
            {
                MessageBox.Show("Please enter a id note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (totalcost <= 0)
            {
                MessageBox.Show("Please enter a valid cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (unitcost <= 0)
            {
                MessageBox.Show("Please enter a valid cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (totalquantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bSave1_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            DateTime Day = dtDay.Value;
            int totalcost = int.Parse(txtTotalcost.Text);
            int totalquantity = int.Parse(txtTotalquantity.Text);
            string agent = txtAgent.Text;



            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");
            connection.Open();
            string insertStatement = "INSERT INTO DeliveryNote VALUES (@idnote, @daydelivery,@agent, @totalquantity,@totalcost)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@idnote", ID);
            command.Parameters.AddWithValue("@daydelivery", Day);
            command.Parameters.AddWithValue("@agent", agent);
            command.Parameters.AddWithValue("@totalquantity", totalquantity);
            command.Parameters.AddWithValue("@totalcost", totalcost);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                // Show a message box indicating that the data was saved
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show a message box indicating that the data was not saved
                MessageBox.Show("Data not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayData1();
        }

        private void bSave2_Click(object sender, EventArgs e)
        {

            string idnote = txtIDnote.Text;
            string idproduct = txtIDPro.Text;
            string productname = txtName.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int unitcost = int.Parse(txtUnit.Text);

            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");
            connection.Open();
            string insertStatement = "INSERT INTO DetailsDeliveryNote VALUES (@idnote, @idproduct,@nameproducts, @quantity,@unitcost)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@idnote", idnote);
            command.Parameters.AddWithValue("@idproduct", idproduct);
            command.Parameters.AddWithValue("@nameproducts", productname);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@unitcost", unitcost);
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            if (rowsAffected > 0)
            {
                // Show a message box indicating that the data was saved
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show a message box indicating that the data was not saved
                MessageBox.Show("Data not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIDnote.Text = "";
            txtIDPro.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
            txtName.Focus();
            DisplayData2();
        }
        private void DisplayData1()
        {
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM DeliveryNote where idNote = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }

        private void DisplayData2()
        {
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM DetailsDeliveryNote where idNote = @idnote";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;

                connection.Close();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(PrintPage);
            printPreviewDialog1.Document = document;
            printPreviewDialog1.ShowDialog();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the font for the title and column headers
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);

            // Define the brush for the text
            Brush textBrush = Brushes.Black;

            // Define the title string
            string title = "Goods Delivery Note";
            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;

            // Define the column names and data
            string[] columnNames = { "ID", "Day", "Agent", "Total Quantity","Total Cost" };
            List<string[]> data = new List<string[]>();

            // Retrieve data from database
            using (SqlConnection conn = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DeliveryNote where idNote = @ID", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[] { reader["idNote"].ToString(), reader["dayDelivery"].ToString(), reader["Agent"].ToString(), reader["totalQuantity"].ToString(), reader["totalcost"].ToString() });
                }
            }

            // Set the Margins and PageSettings properties for the document
            PrintDocument printDoc = (PrintDocument)sender;
            printDoc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            printDoc.DefaultPageSettings.Landscape = true;

            // Define the rectangle for the title and column headers
            RectangleF titleRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top - 50, e.MarginBounds.Width, e.MarginBounds.Height);
            RectangleF headerRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, 20);

            // Draw the title in the header
            e.Graphics.DrawString(title, titleFont, textBrush, titleRect);

            // Draw the column headers
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top + 35;
            for (int i = 0; i < columnNames.Length; i++)
            {
                e.Graphics.DrawString(columnNames[i], headerFont, textBrush, x, y);
                x += e.MarginBounds.Width / columnNames.Length + 33;
            }

            // Draw the data
            x = e.MarginBounds.Left;
            y += 20;
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    e.Graphics.DrawString(data[i][j], headerFont, textBrush, x, y);
                    x += e.MarginBounds.Width / columnNames.Length + 36;
                }
                x = e.MarginBounds.Left;
                y += 30;
            }
        }

    }

}
