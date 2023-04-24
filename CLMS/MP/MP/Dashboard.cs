using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Details obj= new Book_Details();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Details obj1 = new Student_Details();
            obj1.MdiParent = this;
            obj1.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Book obj2 = new Delete_Book();
            obj2.MdiParent = this;
            obj2.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Search obj3 = new Book_Search();
            obj3.MdiParent = this;
            obj3.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Student_Search obj4 = new Student_Search();
            obj4.MdiParent = this;
            obj4.Show();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue obj5 = new Issue();
            obj5.MdiParent = this;
            obj5.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return obj6 = new Return();
            obj6.MdiParent = this;
            obj6.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void issueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue_Report obj7 = new Issue_Report();
            obj7.MdiParent = this;
            obj7.Show();
        }

        private void returnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Report obj8 = new Return_Report();
            obj8.MdiParent = this;
            obj8.Show();
        }
    }
}
