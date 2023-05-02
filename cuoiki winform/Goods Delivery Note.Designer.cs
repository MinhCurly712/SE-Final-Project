
namespace cuoiki_winform
{
    partial class Goods_Delivery_Note
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods_Delivery_Note));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSave1 = new System.Windows.Forms.Button();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.txtTotalquantity = new System.Windows.Forms.TextBox();
            this.txtTotalcost = new System.Windows.Forms.TextBox();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSave2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtIDPro = new System.Windows.Forms.TextBox();
            this.txtIDnote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bExit = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSave1);
            this.groupBox1.Controls.Add(this.txtAgent);
            this.groupBox1.Controls.Add(this.txtTotalquantity);
            this.groupBox1.Controls.Add(this.txtTotalcost);
            this.groupBox1.Controls.Add(this.dtDay);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Note";
            // 
            // bSave1
            // 
            this.bSave1.Location = new System.Drawing.Point(551, 206);
            this.bSave1.Name = "bSave1";
            this.bSave1.Size = new System.Drawing.Size(92, 39);
            this.bSave1.TabIndex = 10;
            this.bSave1.Text = "Save";
            this.bSave1.UseVisualStyleBackColor = true;
            this.bSave1.Click += new System.EventHandler(this.bSave1_Click);
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(106, 208);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(412, 26);
            this.txtAgent.TabIndex = 9;
            // 
            // txtTotalquantity
            // 
            this.txtTotalquantity.Location = new System.Drawing.Point(379, 124);
            this.txtTotalquantity.Name = "txtTotalquantity";
            this.txtTotalquantity.Size = new System.Drawing.Size(300, 26);
            this.txtTotalquantity.TabIndex = 8;
            // 
            // txtTotalcost
            // 
            this.txtTotalcost.Location = new System.Drawing.Point(106, 124);
            this.txtTotalcost.Name = "txtTotalcost";
            this.txtTotalcost.Size = new System.Drawing.Size(154, 26);
            this.txtTotalcost.TabIndex = 7;
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(379, 45);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(300, 26);
            this.dtDay.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(106, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 26);
            this.txtID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSave2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtUnit);
            this.groupBox2.Controls.Add(this.txtIDPro);
            this.groupBox2.Controls.Add(this.txtIDnote);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(708, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // bSave2
            // 
            this.bSave2.Location = new System.Drawing.Point(397, 202);
            this.bSave2.Name = "bSave2";
            this.bSave2.Size = new System.Drawing.Size(103, 43);
            this.bSave2.TabIndex = 10;
            this.bSave2.Text = "Save";
            this.bSave2.UseVisualStyleBackColor = true;
            this.bSave2.Click += new System.EventHandler(this.bSave2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 202);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 26);
            this.txtName.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(322, 118);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(194, 26);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(322, 48);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(194, 26);
            this.txtUnit.TabIndex = 7;
            // 
            // txtIDPro
            // 
            this.txtIDPro.Location = new System.Drawing.Point(136, 118);
            this.txtIDPro.Name = "txtIDPro";
            this.txtIDPro.Size = new System.Drawing.Size(100, 26);
            this.txtIDPro.TabIndex = 6;
            // 
            // txtIDnote
            // 
            this.txtIDnote.Location = new System.Drawing.Point(135, 50);
            this.txtIDnote.Name = "txtIDnote";
            this.txtIDnote.Size = new System.Drawing.Size(100, 26);
            this.txtIDnote.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Unit Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Note";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(630, 247);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(648, 301);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(602, 247);
            this.dataGridView2.TabIndex = 3;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(671, 554);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(121, 45);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "End";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(483, 554);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(121, 45);
            this.bPrint.TabIndex = 5;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 615);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1238, 289);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Being transferred",
            "Delivered"});
            this.comboBox1.Location = new System.Drawing.Point(293, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Goods_Delivery_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 916);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Goods_Delivery_Note";
            this.Text = "Goods_Delivery_Note";
            this.Load += new System.EventHandler(this.Goods_Delivery_Note_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSave1;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.TextBox txtTotalquantity;
        private System.Windows.Forms.TextBox txtTotalcost;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDnote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bSave2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtIDPro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}