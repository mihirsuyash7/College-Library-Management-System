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
    public partial class Return_Report : Form
    {
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DB obj1;
        string sql1;
        public Return_Report()
        {
            obj1 = new DB();
            InitializeComponent();
        }

        private void Return_Report_Load(object sender, EventArgs e)
        {
            lbl4.Visible = false;
            dtpstr1.Visible = false;
            lbl3.Visible = false;
            lbl2.Visible = false;
            dtpend1.Visible = false;
            cmbctr1.Items.Add("For a Particular Date");
            cmbctr1.Items.Add("Between Two Dates");

        }

        private void cmbctr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvret.Columns.Clear();
            if (cmbctr1.SelectedItem == "For a Particular Date")
            {
                lbl4.Visible = true;
                dtpstr1.Visible = true;
                lbl3.Visible = false;
                lbl2.Visible = false;
                dtpend1.Visible = false;
            }
            else if (cmbctr1.SelectedItem == "Between Two Dates")
            {
                lbl4.Visible = false;
                dtpstr1.Visible = true;
                lbl3.Visible = true;
                lbl2.Visible = true;
                dtpend1.Visible = true;
            }
        }


        private void btngo_Click(object sender, EventArgs e)
        {
            if (cmbctr1.SelectedItem == "For a Particular Date")
                sql1 = "SELECT * FROM Return WHERE Time ='" + dtpstr1.Text +"';";
            else if (cmbctr1.SelectedItem == "Between Two Dates")
                sql1 = "SELECT * FROM Return WHERE Time BETWEEN '" + dtpstr1.Text + "' AND '" + dtpend1.Text + "';";
            da = obj1.adapt(sql1);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dr = obj1.read(sql1);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvret.DataSource = ds;
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
