﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value >=100)
            { timer1.Stop();
            Login obj = new Login();
            obj.Show();
            this.Hide();
            }
        }

    }
}
