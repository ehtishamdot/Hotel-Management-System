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

        

       
      
        private void Sign_Click(object sender, EventArgs e)
        {
            Login login = new Login(txt_sign_username.Text,txt_sign_password.Text);
            login.Show();

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            txt_sign_username.Clear();
            panel1.BackColor = Color.Blue;
            panel1.ForeColor = Color.Blue;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txt_sign_password.Clear();
            txt_sign_password.UseSystemPasswordChar = true;
            panel2.BackColor = Color.Blue;
            panel2.ForeColor = Color.Blue;

        }

        private void textBox3_Click(object sender, EventArgs e)
        {

            textBox3.Clear();
            textBox3.BackgroundImage = Properties.Resources.email_icon;            
            panel18.BackColor = Color.Blue;
            panel18.ForeColor = Color.Blue;
           
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

        private void Sign_MouseHover(object sender, EventArgs e)
        {
            Sign.BackColor = Color.White;
            Sign.ForeColor = Color.Black;
        }

        private void Sign_MouseLeave(object sender, EventArgs e)
        {
            Sign.BackColor = Color.FromArgb(43, 34, 54);
            Sign.ForeColor = Color.White;
        }

        private void Signin_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_sign_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txt_sign_password.UseSystemPasswordChar = true;
            }
            if (checkBox1.Checked == true)
            {
                txt_sign_password.UseSystemPasswordChar = false;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {

        }
    }
    
}
