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
    public partial class Create_Goods_Received : Form
    {
        public Create_Goods_Received()
        {
            InitializeComponent();
        }

        private void Create_Goods_Received_Load(object sender, EventArgs e)
        {
            string receiptNo = txtID.Text;
            DateTime receiptDate = dtDay.Value;
            int totalmoney;
            if (!int.TryParse(txtTotal.Text, out totalmoney))
            {
                MessageBox.Show("Please enter a data.", "Information", MessageBoxButtons.OK);
                return;
            }

            string idreceipt = txtIDRe.Text;
            string idproduct = txtIDPro.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int unitprice = int.Parse(txtUnitPrice.Text);
            
            if (string.IsNullOrEmpty(receiptNo))
            {
                MessageBox.Show("Please enter a receipt number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(idreceipt))
            {
                MessageBox.Show("Please enter an id receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(idproduct))
            {
                MessageBox.Show("Please enter an id product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (totalmoney <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (unitprice <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            


        }

        private void bSave1_Click(object sender, EventArgs e)
        {
            string receiptNo = txtID.Text;
            DateTime receiptDate = dtDay.Value;
            int totalmoney = int.Parse(txtTotal.Text);
    


            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");
            connection.Open();
            string insertStatement = "INSERT INTO WarehouseReceipt VALUES (@id, @dayreceive, @TotalMoney)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@id", receiptNo);
            command.Parameters.AddWithValue("@dayreceive", receiptDate);
            command.Parameters.AddWithValue("@TotalMoney", totalmoney);
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
            revenue();
        }
        private void revenue()
        {
            DateTime receiptDate = dtDay.Value;
            int totalmoney = int.Parse(txtTotal.Text);
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "UPDATE Revenue SET importmoney = importmoney + @cost WHERE month = MONTh(@day)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cost", totalmoney);
                command.Parameters.AddWithValue("@day", receiptDate);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

            }

        }

        private void bSave2_Click(object sender, EventArgs e)
        {
            string idreceipt = txtIDRe.Text;
            string idproduct = txtIDPro.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int unitprice = int.Parse(txtUnitPrice.Text);


            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");
            connection.Open();
            string insertStatement = "INSERT INTO DetailsWarehouseReceipt VALUES (@idreceipt, @idproduct, @quantity,@unitprice)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@idreceipt", idreceipt);
            command.Parameters.AddWithValue("@idproduct", idproduct);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@unitprice", unitprice);
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
            DisplayData2();
            txtIDRe.Text = "";
            txtIDPro.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            txtIDRe.Focus();



        }

        private void DisplayData1()
        {
            string receiptNo = txtID.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM WarehouseReceipt where id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", receiptNo);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }

        private void DisplayData2()
        {
            string idreceipt = txtIDRe.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM DetailsWarehouseReceipt where IDReceipt = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", idreceipt);

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
            string receiptNo = txtID.Text;


            // Define the font for the title and column headers
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);

            // Define the brush for the text
            Brush textBrush = Brushes.Black;

            // Define the title string
            string title = "Goods Received";
            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;

            // Define the column names and data
            string[] columnNames = { "ID", "Day","Total Cost" };
            List<string[]> data = new List<string[]>();

            // Retrieve data from database
            using (SqlConnection conn = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM WarehouseReceipt where id = @ID ", conn);
                cmd.Parameters.AddWithValue("@ID", receiptNo);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[] { reader["id"].ToString(), reader["dayreceive"].ToString(), reader["TotalMoney"].ToString() });
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

            int lineSpacing = 20; // Set the line spacing to 20 pixels

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
                y += lineSpacing;
                y += 30;
            }

            y += 50;

            string[] columnNames1 = { "ID", "ID Product", "Quantity", "Unit Cost" };
            List<string[]> data1 = new List<string[]>();

            // Retrieve data from database
            using (SqlConnection conn = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DetailsWarehouseReceipt where IDReceipt = @ID ", conn);
                cmd.Parameters.AddWithValue("@ID", receiptNo);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data1.Add(new string[] { reader["IDReceipt"].ToString(), reader["IDProducts"].ToString(), reader["quantity"].ToString(), reader["UnitPrice"].ToString() });
                }
            }
            e.Graphics.DrawString(title, titleFont, textBrush, titleRect);

            // Draw the column headers

            for (int i = 0; i < columnNames1.Length; i++)
            {
                e.Graphics.DrawString(columnNames1[i], headerFont, textBrush, x, y);
                x += e.MarginBounds.Width / columnNames1.Length + 33;
            }

            // Draw the data
            x = e.MarginBounds.Left;
            y += 20;
            for (int i = 0; i < data1.Count; i++)
            {
                for (int j = 0; j < data1[i].Length; j++)
                {
                    e.Graphics.DrawString(data1[i][j], headerFont, textBrush, x, y);
                    x += e.MarginBounds.Width / columnNames1.Length + 36;
                }
                x = e.MarginBounds.Left;
                y += 30;
            }
        }
    }
}
