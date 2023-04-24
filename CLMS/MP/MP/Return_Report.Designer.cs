namespace MP
{
    partial class Return_Report
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
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvret = new System.Windows.Forms.DataGridView();
            this.btngo = new System.Windows.Forms.Button();
            this.dtpend1 = new System.Windows.Forms.DateTimePicker();
            this.dtpstr1 = new System.Windows.Forms.DateTimePicker();
            this.cmbctr1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvret)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(258, 23);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(125, 18);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "Date:";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(416, 23);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 18);
            this.lbl3.TabIndex = 16;
            this.lbl3.Text = "End Date:";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(258, 23);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 18);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Criteria:";
            // 
            // dgvret
            // 
            this.dgvret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvret.Location = new System.Drawing.Point(30, 94);
            this.dgvret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvret.Name = "dgvret";
            this.dgvret.Size = new System.Drawing.Size(624, 347);
            this.dgvret.TabIndex = 13;
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(571, 42);
            this.btngo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(83, 24);
            this.btngo.TabIndex = 12;
            this.btngo.Text = "Submit";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // dtpend1
            // 
            this.dtpend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpend1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend1.Location = new System.Drawing.Point(419, 44);
            this.dtpend1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpend1.Name = "dtpend1";
            this.dtpend1.Size = new System.Drawing.Size(96, 21);
            this.dtpend1.TabIndex = 11;
            // 
            // dtpstr1
            // 
            this.dtpstr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstr1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstr1.Location = new System.Drawing.Point(261, 44);
            this.dtpstr1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpstr1.Name = "dtpstr1";
            this.dtpstr1.Size = new System.Drawing.Size(96, 21);
            this.dtpstr1.TabIndex = 10;
            // 
            // cmbctr1
            // 
            this.cmbctr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbctr1.FormattingEnabled = true;
            this.cmbctr1.Location = new System.Drawing.Point(30, 45);
            this.cmbctr1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbctr1.Name = "cmbctr1";
            this.cmbctr1.Size = new System.Drawing.Size(172, 23);
            this.cmbctr1.TabIndex = 9;
            this.cmbctr1.Text = "Select";
            this.cmbctr1.SelectedIndexChanged += new System.EventHandler(this.cmbctr1_SelectedIndexChanged);
            // 
            // Return_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 465);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvret);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.dtpend1);
            this.Controls.Add(this.dtpstr1);
            this.Controls.Add(this.cmbctr1);
            this.Name = "Return_Report";
            this.Text = "Return_Report";
            this.Load += new System.EventHandler(this.Return_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvret;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.DateTimePicker dtpend1;
        private System.Windows.Forms.DateTimePicker dtpstr1;
        private System.Windows.Forms.ComboBox cmbctr1;
    }
}