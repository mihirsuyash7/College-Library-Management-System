namespace MP
{
    partial class Student_Search
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
            this.txtstu = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Id";
            // 
            // txtstu
            // 
            this.txtstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstu.Location = new System.Drawing.Point(160, 69);
            this.txtstu.Name = "txtstu";
            this.txtstu.Size = new System.Drawing.Size(222, 21);
            this.txtstu.TabIndex = 1;
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(401, 64);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(46, 28);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(23, 119);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(423, 267);
            this.dgv2.TabIndex = 3;
            // 
            // Student_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 426);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txtstu);
            this.Controls.Add(this.label1);
            this.Name = "Student_Search";
            this.Text = "Student_Search";
            this.Load += new System.EventHandler(this.Student_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstu;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.DataGridView dgv2;
    }
}