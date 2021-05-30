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
            this.Visible = false;
            

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            txt_sign_username.Clear();
            panel1.BackColor = Color.Blue;
        }

        private void txt_sign_username_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            if(txt_sign_username.Text == "")
            {
                txt_sign_username.Text = "Username";
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txt_sign_password.Clear();
            txt_sign_password.UseSystemPasswordChar = true;
            panel2.BackColor = Color.Blue;
            panel2.ForeColor = Color.Blue;
        }
        private void txt_sign_password_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            if (txt_sign_password.Text == "")
            {
                txt_sign_password.Text = "Password";
            }               
            txt_sign_password.UseSystemPasswordChar = false;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

            email.Clear();          
            panel18.BackColor = Color.Blue;
            panel18.ForeColor = Color.Blue;           
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            panel18.BackColor = Color.Black;
            if (email.Text == "")
            {
                email.Text = "Email";
            }
               
            
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


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == false)
            {
                txt_sign_password.UseSystemPasswordChar = true;
            }
            if (checkBox.Checked == true)
            {
                txt_sign_password.UseSystemPasswordChar = false;
            }
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.ForeColor = Color.LightGray;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void txt_sign_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
