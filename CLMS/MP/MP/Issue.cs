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
    public partial class Issue : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DB obj;
        string sql;
        int c = 0,s=0;
        public Issue()
        {
            InitializeComponent();
            obj = new DB();
        }

        private void Issue_Load(object sender, EventArgs e)
        {
           
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtstuId.Text == "All")
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
                        dgvstu.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtstuId.Text = "";
                    txtstuId.Focus();
                }
            }
            else
            {
                sql = "SELECT * FROM STUDENT WHERE Id='" + txtstuId.Text + "'";
                da = obj.adapt(sql);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dr = obj.read(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgvstu.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    txtstuId.Text = "";
                    txtstuId.Focus();
                }
            }
        }

        private void btngo1_Click(object sender, EventArgs e)
        {
            if (txtbookId.Text == "All")
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
                    txtbookId.Text = "";
                    txtbookId.Focus();
                }
            }
            else
            {
                sql = "SELECT * FROM BOOK WHERE Book_Id='" + txtbookId.Text + "'";
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
                    txtbookId.Text = "";
                    txtbookId.Focus();
                }
            }

        }

        private void dgvstu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtstuId.Text = dgvstu.Rows[e.RowIndex].Cells[0].Value.ToString();
           lblstuname.Text = dgvstu.Rows[e.RowIndex].Cells[1].Value.ToString();
           sql = "Select Book_Issued from Student where Id='" + txtstuId.Text + "'";
           dr = obj.read(sql);
           if (dr.HasRows)
           {
               dr.Read();
               s = Convert.ToInt32(dr[0].ToString());
           }
        }

        private void dgvbook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbookId.Text = dgvbook.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblbookname.Text = dgvbook.Rows[e.RowIndex].Cells[1].Value.ToString();
            sql = "Select Quantity from Book where Book_Id='" + txtbookId.Text + "'";
                    dr = obj.read(sql);
                    if (dr.HasRows)
                    {
                        dr.Read();
                        c = Convert.ToInt32(dr[0].ToString());
                    }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txtstuId.Text != "" && txtbookId.Text != "")
            {
                if ((c == 0)||s>5)
                { if(c==0)
                 MessageBox.Show("BOOK ISN'T AVAILABLE");
                else if(s>5)
                 MessageBox.Show("CAN'T ISSUE BOOK!!! MAXIMUM BOOKS ISSUED TO STUDENT");
                this.Hide();
                }
                else
                {
                    sql = "Insert into Issue values('" + txtbookId.Text + "','" + lblbookname.Text + "','" + txtstuId.Text + "','" + lblstuname.Text + "','" + dateTimePicker1.Text + "')";
                    if (obj.Execute(sql) > 0)
                    {
                        MessageBox.Show("BOOK ISSUED SUCCESSFULLY");
                        sql = "Select Quantity from Book where Book_Id='" + txtbookId.Text + "'";
                        dr = obj.read(sql);
                        int pre = 0;
                        if (dr.HasRows)
                        {
                            dr.Read();
                            pre = Convert.ToInt32(dr[0].ToString());
                            pre = pre - 1;
                        }
                        sql = "Update Book set Quantity=" + pre + " where Book_Id='" + txtbookId.Text + "'";
                        if (obj.Execute(sql) > 0)
                        { MessageBox.Show("BOOK QUANTITY UPDATED"); }

                        sql = "Select Book_Issued from Student where Id='" + txtstuId.Text + "'";
                        dr = obj.read(sql);
                        int pres=0;
                        if (dr.HasRows)
                        { dr.Read();
                        pres = Convert.ToInt32(dr[0].ToString());
                        pres = pres + 1;
                        }
                        sql = "Update Student set Book_Issued=" + pres + " where Id='" + txtstuId.Text + "'";
                        if (obj.Execute(sql) > 0)
                        { MessageBox.Show("ISSUE STATUS UPDATED"); }
                        this.Hide();
                    }
                }
            }
            else
                MessageBox.Show("FAILED");
        }

        private void btncnl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtbookId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
