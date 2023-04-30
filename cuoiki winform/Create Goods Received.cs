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
                MessageBox.Show("Please enter a valid integer value for TotalMoney.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }   
    }
}
