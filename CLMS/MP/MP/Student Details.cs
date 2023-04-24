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
    public partial class Student_Details : Form
    {
        OleDbDataReader dr;
        string sql;
        DB obj;
        public Student_Details()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Student_Details_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM STUDENT";
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
                lblSId.Text = "S000" + (count + 1);
            else if (count.ToString().Length == 2)
                lblSId.Text = "S00" + (count + 1);
            else if (count.ToString().Length == 3)
                lblSId.Text = "S0" + (count + 1);
            else
                lblSId.Text = "S" + (count + 1);
            rtbstu.Focus();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (rtbstu.Text == "" || txtstr.Text == "" || txtph.Text == "")
            {
                MessageBox.Show("Incorrect Entry!!! Re-Enter");
                if (rtbstu.Text == "")
                    rtbstu.Focus();
                else if (rtbroll.Text == "")
                    rtbroll.Focus();
                else if (txtstr.Text == "")
                    txtstr.Focus();
                else if (txtph.Text == "")
                    txtph.Focus();
            }
            else
            {
                sql = "INSERT INTO STUDENT VALUES('" + lblSId.Text + "','" + rtbstu.Text + "','" + rtbroll.Text + "','" + txtstr.Text + "'," + txtph.Text + ",0)";
                if (obj.Execute(sql) > 0)
                {
                    MessageBox.Show("STUDENT ENROLED SUCCESSFULLY");
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
