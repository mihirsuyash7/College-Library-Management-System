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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        { txtId.Text = "Enter User Id";
          txtpwd.Text = "Enter Password";
          txtId.Focus();
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "Enter User Id")
            {
                txtId.Text = "";
            }
            else if (txtId.Text == "")
            {
                txtId.Text = "Enter User Id";
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "Enter User Id";
            }
        }

        private void txtpwd_Enter(object sender, EventArgs e)
        {
            if (txtpwd.Text == "Enter Password")
            {
                txtpwd.Text = "";
            }
            else if (txtpwd.Text == "")
            {
                txtpwd.Text = "Enter Password";
            }
        }

        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "Enter Password";
            }

        }

        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        { if(e.KeyChar !=9)
            txtpwd.PasswordChar = '*';
        else
            txtpwd.PasswordChar = '\0';
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "Enter User Id" || txtpwd.Text == "Enter Password")
            {
                MessageBox.Show("Incorrect Details!!! Enter Again");
                if (txtId.Text == "")
                    txtId.Focus();
                else if (txtpwd.Text == "")
                    txtpwd.Focus();
            }
            else if(txtId.Text == "suyash" && txtpwd.Text == "mihir")
            {   MessageBox.Show("LOGGED IN SUCCESSFULLY");
                this.Hide();
                Dashboard obj1 = new Dashboard();
                obj1.Show();
                }
        else
                { MessageBox.Show("Incorrect Details!!! Enter Again");
                txtId.Text = "Enter User Id";
                txtpwd.Text = "Enter Password";
                txtpwd.PasswordChar = '\0';
                txtId.Focus();
                }
            }

        private void btncnl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
