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
    public partial class Issue_Report : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DB obj;
        string sql;
        public Issue_Report()
        {   obj=new DB();
            InitializeComponent();
        }

        private void Issue_Report_Load(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            dtpend.Visible = false;
            dtpstr.Visible = false;
            cmbctr.Items.Add("For a Particular Date");
            cmbctr.Items.Add("Between Two Dates");

        }

        private void cmbctr_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgviss.Columns.Clear();
            if (cmbctr.SelectedItem == "For a Particular Date")
            {
                lbl4.Visible = true;
                dtpstr.Visible = true;
                lbl3.Visible = false;
                lbl2.Visible = false;
                dtpend.Visible = false;
            }
            else if (cmbctr.SelectedItem == "Between Two Dates")
            {
                lbl4.Visible = false;
                dtpstr.Visible = true;
                lbl3.Visible = true;
                lbl2.Visible = true;
                dtpend.Visible = true;
            }
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (cmbctr.SelectedItem == "For a Particular Date")
                sql = "SELECT * FROM Issue WHERE Time ='" + dtpstr.Text + "';";
            else if (cmbctr.SelectedItem == "Between Two Dates")
                sql = "SELECT * FROM Issue WHERE Time BETWEEN '" + dtpstr.Text + "' AND '" + dtpend.Text + "';";
            da = obj.adapt(sql);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dr = obj.read(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgviss.DataSource = ds;
                }
            }
            else
            {
                MessageBox.Show("Entries Not Found");
                this.Hide();
            }
        }
    }
}
