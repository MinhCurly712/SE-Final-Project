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
                MessageBox.Show("Please enter a data.", "Information", MessageBoxButtons.OK);
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
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            DisplayData1();
            insert_status();
            DisplayData3();
            revenue();

        }
        private void insert_status()
        {
            string ID = txtID.Text;

            SqlConnection connection = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True");
            connection.Open();
            string insertStatement = "INSERT INTO Status VALUES (@idnote, @orderStatus,@paymentStatus)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@idnote", ID);
            command.Parameters.AddWithValue("@orderStatus", "not delivered");
            command.Parameters.AddWithValue("@paymentStatus", "unpaid");
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
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
            DisplayData2();
            txtIDnote.Text = "";
            txtIDPro.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
            txtName.Text ="";
            txtIDnote.Focus();
        }
        private void DisplayData1()
        {
            string ID = txtID.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM DeliveryNote where idNote = @idnote";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idNote", ID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
        }

        private void DisplayData2()
        {
            string idnote = txtIDnote.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM DetailsDeliveryNote where idNote = @idnote";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idNote", idnote);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;

                connection.Close();
            }
        }

        private void DisplayData3()
        {
            string ID = txtID.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT * FROM Status where idNote = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView3.DataSource = dataTable;

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
            string ID = txtID.Text;

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM DeliveryNote where idNote = @ID ", conn);
                cmd.Parameters.AddWithValue("@ID", ID);

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


            string[] columnNames1 = { "ID", "ID Product", "Name", "Quantity", "Unit Cost" };
            List<string[]> data1 = new List<string[]>();
            using (SqlConnection conn = new SqlConnection("Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DetailsDeliveryNote where idNote = @ID ", conn);
                cmd.Parameters.AddWithValue("@ID",ID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data1.Add(new string[] { reader["idNote"].ToString(), reader["idProducts"].ToString(), reader["nameProducts"].ToString(), reader["quantity"].ToString(), reader["unitcost"].ToString() });
                }
            }
            e.Graphics.DrawString(title, titleFont, textBrush, titleRect);


            for (int i = 0; i < columnNames1.Length; i++)
            {
                e.Graphics.DrawString(columnNames1[i], headerFont, textBrush, x, y);
                x += e.MarginBounds.Width / columnNames1.Length + 33;
            }

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

        private void bSave3_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a value from the combo box.");
                return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a value from the combo box.");
                return;
            }
            string selectedValue1 = comboBox1.SelectedItem.ToString();
            string selectedValue2 = comboBox2.SelectedItem.ToString();
            string query1 = "UPDATE Status SET orderStatus = @SelectedValue1 WHERE idNote = @ID";
            string query2 = "UPDATE Status SET paymentStatus = @SelectedValue2 WHERE idNote = @ID";
            using (SqlConnection connection1 = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query1, connection1))
            {
                command.Parameters.AddWithValue("@SelectedValue1", selectedValue1);
                command.Parameters.AddWithValue("@ID",ID);
                connection1.Open();
                int rowsAffected = command.ExecuteNonQuery();
              
                MessageBox.Show("Data updated successfully.");


            }
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query2, connection2))
            {
                command.Parameters.AddWithValue("@SelectedValue2", selectedValue2);
                command.Parameters.AddWithValue("@ID",ID);
                connection2.Open();
                int rowsAffected = command.ExecuteNonQuery();

            }
            DisplayData3();

        }   
        private void revenue()
        {
            DateTime Day = dtDay.Value;
            int totalcost = int.Parse(txtTotalcost.Text);
            string connectionString = "Data Source=THIENHUY\\SQLEXPRESS;Initial Catalog=finalproject;Integrated Security=True";
            string query = "UPDATE Revenue SET salesmoney = salesmoney + @cost WHERE month = MONTh(@day)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cost", totalcost);
                command.Parameters.AddWithValue("@day", Day); 
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
      
            }

        }


    }

}
