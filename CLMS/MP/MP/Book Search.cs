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
    public partial class Book_Search : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DB obj;
        string sql;
        public Book_Search()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Book_Search_Load(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "All")
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
                        dgv1.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtId.Text = "";
                    txtId.Focus();
                }
            }
            else
            {
                sql = "SELECT * FROM BOOK WHERE Book_Id='" + txtId.Text + "'";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgv1.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtId.Text = "";
                    txtId.Focus();
                }
            }

        }
    }
}
