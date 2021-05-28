using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Our_project
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

 

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
          // panel18.ForeColor = Color.FromArgb(43, 34, 54);
         //  textBox3.ForeColor = Color.FromArgb(43, 34, 54);

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.UseSystemPasswordChar = true;

        }

        private void textBox3_Click(object sender, EventArgs e)
        {

            textBox3.Clear();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
