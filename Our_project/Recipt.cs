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
    public partial class Recipt : Form
    {  
        public Recipt()
        {
            InitializeComponent();
        }
        //starters.Text, maincourse.Text, Desserts.Text
        public Recipt(string starters, string maincourse, string Desserts)
        {
            InitializeComponent();
            this.starters = starters;
            
        }
        string starters;
        
        private void reciptbutton_Click(object sender, EventArgs e)
        {
           dish1.Text = starters;
            MessageBox.Show(starters);
            dish1.Visible = true;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel.BackColor = Color.Blue;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Color.Black;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry v = new Entry();
            v.Show();
        }

        private void star1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }
   


        private void star1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel5.BackColor = Color.Black;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Signin v = new Signin();
            v.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
