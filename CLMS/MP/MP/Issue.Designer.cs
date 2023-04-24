namespace MP
{
    partial class Issue
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtstuId = new System.Windows.Forms.TextBox();
            this.dgvstu = new System.Windows.Forms.DataGridView();
            this.btngo = new System.Windows.Forms.Button();
            this.btngo1 = new System.Windows.Forms.Button();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.txtbookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsub = new System.Windows.Forms.Button();
            this.btncnl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblstuname = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Id";
            // 
            // txtstuId
            // 
            this.txtstuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstuId.Location = new System.Drawing.Point(148, 65);
            this.txtstuId.Name = "txtstuId";
            this.txtstuId.Size = new System.Drawing.Size(139, 21);
            this.txtstuId.TabIndex = 1;
            // 
            // dgvstu
            // 
            this.dgvstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstu.Location = new System.Drawing.Point(24, 136);
            this.dgvstu.Name = "dgvstu";
            this.dgvstu.Size = new System.Drawing.Size(311, 273);
            this.dgvstu.TabIndex = 2;
            this.dgvstu.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstu_RowHeaderMouseClick);
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(297, 61);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(37, 27);
            this.btngo.TabIndex = 3;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btngo1
            // 
            this.btngo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo1.Location = new System.Drawing.Point(668, 61);
            this.btngo1.Name = "btngo1";
            this.btngo1.Size = new System.Drawing.Size(37, 27);
            this.btngo1.TabIndex = 7;
            this.btngo1.Text = "Go";
            this.btngo1.UseVisualStyleBackColor = true;
            this.btngo1.Click += new System.EventHandler(this.btngo1_Click);
            // 
            // dgvbook
            // 
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Location = new System.Drawing.Point(395, 136);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.Size = new System.Drawing.Size(311, 273);
            this.dgvbook.TabIndex = 6;
            this.dgvbook.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbook_RowHeaderMouseClick);
            // 
            // txtbookId
            // 
            this.txtbookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookId.Location = new System.Drawing.Point(519, 65);
            this.txtbookId.Name = "txtbookId";
            this.txtbookId.Size = new System.Drawing.Size(139, 21);
            this.txtbookId.TabIndex = 5;
            this.txtbookId.TextChanged += new System.EventHandler(this.txtbookId_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Book Id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 437);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(159, 480);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(142, 43);
            this.btnsub.TabIndex = 9;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btncnl
            // 
            this.btncnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncnl.Location = new System.Drawing.Point(424, 480);
            this.btncnl.Name = "btncnl";
            this.btncnl.Size = new System.Drawing.Size(142, 43);
            this.btncnl.TabIndex = 10;
            this.btncnl.Text = "Cancel";
            this.btncnl.UseVisualStyleBackColor = true;
            this.btncnl.Click += new System.EventHandler(this.btncnl_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Book Name";
            // 
            // lblstuname
            // 
            this.lblstuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstuname.Location = new System.Drawing.Point(145, 102);
            this.lblstuname.Name = "lblstuname";
            this.lblstuname.Size = new System.Drawing.Size(189, 20);
            this.lblstuname.TabIndex = 13;
            // 
            // lblbookname
            // 
            this.lblbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookname.Location = new System.Drawing.Point(516, 102);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(189, 20);
            this.lblbookname.TabIndex = 14;
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 541);
            this.Controls.Add(this.lblbookname);
            this.Controls.Add(this.lblstuname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncnl);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btngo1);
            this.Controls.Add(this.dgvbook);
            this.Controls.Add(this.txtbookId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.dgvstu);
            this.Controls.Add(this.txtstuId);
            this.Controls.Add(this.label1);
            this.Name = "Issue";
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstuId;
        private System.Windows.Forms.DataGridView dgvstu;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btngo1;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.TextBox txtbookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btncnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblstuname;
        private System.Windows.Forms.Label lblbookname;
    }
}