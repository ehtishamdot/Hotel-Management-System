﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Our_project
{
    public partial class choices : Form
    {
        public choices()
        {
            InitializeComponent();
        }

     

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Blue;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {           
            Entry v = new Entry();
            v.Show();
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            label2.ForeColor = Color.Blue;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void recipt_Click(object sender, EventArgs e)
        {
            this.Close();
            Voice v = new Voice();
            v.Show();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
           Recipt v = new Recipt();
           v.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Signin v = new Signin();
            v.Show();
        }
    }
}
