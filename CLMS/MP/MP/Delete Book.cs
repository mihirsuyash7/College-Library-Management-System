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
    public partial class Delete_Book : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DB obj;
        string sql;
        public Delete_Book()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Delete_Book_Load(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtbook.Text == "All")
            {
                sql = "SELECT * FROM BOOK";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgvbook.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtbook.Text = "";
                    txtbook.Focus();
                }
            }
            else
            {
                sql = "SELECT * FROM BOOK WHERE Book_Id='" + txtbook.Text + "'";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgvbook.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtbook.Text = "";
                    txtbook.Focus();
                }
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            sql = "Delete * from Book where Book_Id='" + txtbook.Text + "'";
                if (obj.Execute(sql) > 0)
                {
                    sql = "SELECT * FROM BOOK";
                    da = obj.adapt(sql);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dr = obj.read(sql);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            dgvbook.DataSource = ds;
                        }
                    }
                    MessageBox.Show("BOOK DELETED SUCCESSFULLY");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("FAILED");
                    this.Hide();
                }

        }

        private void btncnl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvbook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbook.Text = dgvbook.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
