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
    public partial class Return : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DB obj;
        string sql;
        public Return()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txts.Text == "All")
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
                        dgvs.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txts.Text = "";
                    txts.Focus();
                }
            }
            else
            {
                sql = "SELECT * FROM STUDENT WHERE Student_Id='" + txts.Text + "'";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgvs.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txts.Text = "";
                    txts.Focus();
                }
            }
        }

        private void dgvs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txts.Text = dgvs.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbls.Text=dgvs.Rows[e.RowIndex].Cells[1].Value.ToString();
            sql = "SELECT Book_Id,Book_Name FROM Issue WHERE Id='" + txts.Text + "'";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgvb.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txts.Text = "";
                    txts.Focus();
                    dgvb.DataSource = ds;
                }
            }

        private void dgvb_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        lblbId.Text = dgvb.Rows[e.RowIndex].Cells[0].Value.ToString();
        lblb.Text=dgvb.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txts.Text != "" && lblbId.Text != "")
            {
                sql = "Insert into Return values('" + lblbId.Text + "','" + lblb.Text + "','" + txts.Text + "','" + lbls.Text + "','" + dateTimePicker1.Text + "')";
                if (obj.Execute(sql) > 0)
                {
                    MessageBox.Show("BOOK RETURNED SUCCESSFULLY");
                    sql = "Select Quantity from Book where Book_Id='" + lblbId.Text + "'";
                    dr = obj.read(sql);
                    int pre = 0;
                    if (dr.HasRows)
                    {
                        dr.Read();
                        pre = Convert.ToInt32(dr[0].ToString());
                        pre = pre + 1;
                    }
                    sql = "Update Book set Quantity=" + pre + " where Book_Id='" + lblbId.Text + "'";
                    if (obj.Execute(sql) > 0)
                    { MessageBox.Show("BOOK QUANTITY UPDATED"); }

                    sql = "Select Book_Issued from Student where Id='" + txts.Text + "'";
                    dr = obj.read(sql);
                    int pres = 0;
                    if (dr.HasRows)
                    {
                        dr.Read();
                        pres = Convert.ToInt32(dr[0].ToString());
                        pres = pres - 1;
                    }
                    sql = "Update Student set Book_Issued=" + pres + " where Id='" + txts.Text + "'";
                    if (obj.Execute(sql) > 0)
                    { MessageBox.Show("RETURN STATUS UPDATED"); }
                    this.Hide();                   
                }
            }
            else
                MessageBox.Show("FAILED");
        }
    }
}
