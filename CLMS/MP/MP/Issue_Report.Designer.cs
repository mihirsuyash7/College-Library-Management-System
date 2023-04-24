namespace MP
{
    partial class Issue_Report
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
            this.cmbctr = new System.Windows.Forms.ComboBox();
            this.dtpstr = new System.Windows.Forms.DateTimePicker();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.btngo = new System.Windows.Forms.Button();
            this.dgviss = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgviss)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbctr
            // 
            this.cmbctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbctr.FormattingEnabled = true;
            this.cmbctr.Location = new System.Drawing.Point(29, 46);
            this.cmbctr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbctr.Name = "cmbctr";
            this.cmbctr.Size = new System.Drawing.Size(172, 23);
            this.cmbctr.TabIndex = 0;
            this.cmbctr.Text = "Select";
            this.cmbctr.SelectedIndexChanged += new System.EventHandler(this.cmbctr_SelectedIndexChanged);
            // 
            // dtpstr
            // 
            this.dtpstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstr.Location = new System.Drawing.Point(260, 45);
            this.dtpstr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpstr.Name = "dtpstr";
            this.dtpstr.Size = new System.Drawing.Size(96, 21);
            this.dtpstr.TabIndex = 1;
            // 
            // dtpend
            // 
            this.dtpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(418, 45);
            this.dtpend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(96, 21);
            this.dtpend.TabIndex = 2;
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(570, 43);
            this.btngo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(83, 24);
            this.btngo.TabIndex = 3;
            this.btngo.Text = "Submit";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // dgviss
            // 
            this.dgviss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviss.Location = new System.Drawing.Point(29, 95);
            this.dgviss.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgviss.Name = "dgviss";
            this.dgviss.Size = new System.Drawing.Size(624, 347);
            this.dgviss.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Criteria:";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(257, 24);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 18);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Start Date:";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(415, 24);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 18);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "End Date:";
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(257, 24);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(125, 18);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Date:";
            // 
            // Issue_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 465);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgviss);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstr);
            this.Controls.Add(this.cmbctr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Issue_Report";
            this.Text = "Issue_Report";
            this.Load += new System.EventHandler(this.Issue_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbctr;
        private System.Windows.Forms.DateTimePicker dtpstr;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.DataGridView dgviss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}