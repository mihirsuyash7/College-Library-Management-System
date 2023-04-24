using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MP
{
    public partial class Book_Details : Form
    {
        OleDbDataReader dr;
        string sql;
        DB obj;
        public Book_Details()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Book_Details_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM BOOK";
            dr = obj.read(sql);
            int count = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ++count;
                }
            }
            if (count.ToString().Length == 1)
                lblBId.Text = "B000" + (count + 1);
            else if (count.ToString().Length == 2)
                lblBId.Text = "B00" + (count + 1);
            else if (count.ToString().Length == 3)
                lblBId.Text = "B0" + (count + 1);
            else
                lblBId.Text = "B" + (count + 1);
            rtbbook.Focus();

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (rtbbook.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Incorrect Entry!!! Re-Enter");
                    rtbbook.Focus();
            }
            else
            {
                sql = "INSERT INTO BOOK VALUES('" + lblBId.Text + "','" + rtbbook.Text + "','"+rtbauth.Text+"','"+rtbpub.Text+"','"+rtbdep.Text+"'," + txtqty.Text + ")";
                if (obj.Execute(sql) > 0)
                {
                    MessageBox.Show("BOOK ADDED SUCCESSFULLY");
                    this.Hide();
                }
                else
                    MessageBox.Show("FAILED");
            }
        }

        private void btncnl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
