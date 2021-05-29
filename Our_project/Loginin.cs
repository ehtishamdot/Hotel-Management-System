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
   
    public partial class Login : Form
    {

        
        public Login(string userid,string pass)
        {
            InitializeComponent();
            this.userid = userid;
            this.pass = pass;
        }

        string userid;
        string pass;

        private void Loginin_Load(object sender, EventArgs e)
        {
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
        }  
        private void username_Click(object sender, EventArgs e)
        {
           
           
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void register_Click(object sender, EventArgs e)
        {
            Signin sign = new Signin();
            sign.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            username.Clear();
        }

        private void Sign_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void Sign_Click(object sender, EventArgs e)
        {
                       
                if (userid == username.Text)
                {
                    if (pass == password.Text)
                    {

                    MessageBox.Show("Login sucess Welcome to Homepage ");
                    }
                    else
                    {
                    MessageBox.Show("Enter Correct Password");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
         
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Clear();
            password.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==false)
            {
                password.UseSystemPasswordChar = true;
            }
            if(checkBox1.Checked==true)
            {
                password.UseSystemPasswordChar = false;
            }
                       
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
          
        }
    }
    
}
