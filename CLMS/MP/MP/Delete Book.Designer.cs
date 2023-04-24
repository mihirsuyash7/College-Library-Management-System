namespace MP
{
    partial class Delete_Book
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
            this.txtbook = new System.Windows.Forms.TextBox();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.btncnl = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book Id";
            // 
            // txtbook
            // 
            this.txtbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbook.Location = new System.Drawing.Point(156, 64);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(143, 21);
            this.txtbook.TabIndex = 1;
            // 
            // dgvbook
            // 
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Location = new System.Drawing.Point(32, 107);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.Size = new System.Drawing.Size(334, 281);
            this.dgvbook.TabIndex = 2;
            this.dgvbook.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbook_RowHeaderMouseClick);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(156, 413);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(96, 28);
            this.btndel.TabIndex = 3;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncnl
            // 
            this.btncnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncnl.Location = new System.Drawing.Point(270, 413);
            this.btncnl.Name = "btncnl";
            this.btncnl.Size = new System.Drawing.Size(96, 28);
            this.btncnl.TabIndex = 4;
            this.btncnl.Text = "Cancel";
            this.btncnl.UseVisualStyleBackColor = true;
            this.btncnl.Click += new System.EventHandler(this.btncnl_Click);
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(320, 60);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(46, 26);
            this.btngo.TabIndex = 5;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // Delete_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 453);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btncnl);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.dgvbook);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.label1);
            this.Name = "Delete_Book";
            this.Text = "Delete_Book";
            this.Load += new System.EventHandler(this.Delete_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncnl;
        private System.Windows.Forms.Button btngo;
    }
}