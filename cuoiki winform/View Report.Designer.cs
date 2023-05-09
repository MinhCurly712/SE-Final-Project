
namespace cuoiki_winform
{
    partial class View_Report
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
            this.bIncome = new System.Windows.Forms.Button();
            this.bOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.bEnd = new System.Windows.Forms.Button();
            this.bSell = new System.Windows.Forms.Button();
            this.bRe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bIncome
            // 
            this.bIncome.Location = new System.Drawing.Point(12, 118);
            this.bIncome.Name = "bIncome";
            this.bIncome.Size = new System.Drawing.Size(105, 41);
            this.bIncome.TabIndex = 0;
            this.bIncome.Text = "Incoming";
            this.bIncome.UseVisualStyleBackColor = true;
            this.bIncome.Click += new System.EventHandler(this.bIncome_Click);
            // 
            // bOut
            // 
            this.bOut.Location = new System.Drawing.Point(210, 118);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(102, 41);
            this.bOut.TabIndex = 1;
            this.bOut.Text = "Outgoing";
            this.bOut.UseVisualStyleBackColor = true;
            this.bOut.Click += new System.EventHandler(this.bOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 440);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(111, 32);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(244, 26);
            this.txtMonth.TabIndex = 6;
            // 
            // bEnd
            // 
            this.bEnd.Location = new System.Drawing.Point(834, 118);
            this.bEnd.Name = "bEnd";
            this.bEnd.Size = new System.Drawing.Size(99, 41);
            this.bEnd.TabIndex = 7;
            this.bEnd.Text = "End";
            this.bEnd.UseVisualStyleBackColor = true;
            this.bEnd.Click += new System.EventHandler(this.bEnd_Click);
            // 
            // bSell
            // 
            this.bSell.Location = new System.Drawing.Point(420, 118);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(114, 41);
            this.bSell.TabIndex = 8;
            this.bSell.Text = "Best-Selling";
            this.bSell.UseVisualStyleBackColor = true;
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // bRe
            // 
            this.bRe.Location = new System.Drawing.Point(633, 118);
            this.bRe.Name = "bRe";
            this.bRe.Size = new System.Drawing.Size(113, 41);
            this.bRe.TabIndex = 9;
            this.bRe.Text = "Revenue";
            this.bRe.UseVisualStyleBackColor = true;
            this.bRe.Click += new System.EventHandler(this.bRe_Click);
            // 
            // View_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 634);
            this.Controls.Add(this.bRe);
            this.Controls.Add(this.bSell);
            this.Controls.Add(this.bEnd);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bOut);
            this.Controls.Add(this.bIncome);
            this.Name = "View_Report";
            this.Text = "View_Report";
            this.Load += new System.EventHandler(this.View_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIncome;
        private System.Windows.Forms.Button bOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button bEnd;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.Button bRe;
    }
}