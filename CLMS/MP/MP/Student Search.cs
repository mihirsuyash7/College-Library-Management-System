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
    public partial class Student_Search : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DB obj;
        string sql;
        public Student_Search()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Student_Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtstu.Text == "All")
            {
                sql = "SELECT * FROM STUDENT";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgv2.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtstu.Text = "";
                    txtstu.Focus();
                }
            }
            else
            {
                sql = "SELECT * FROM STUDENT WHERE Id='" + txtstu.Text + "'";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgv2.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtstu.Text = "";
                    txtstu.Focus();
                }
            }
        }
    }
}
