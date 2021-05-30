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
    public partial class choices : Form
    {
        public choices()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            starters.Items.Add("Starter options:");
            string[] items = {
               "Chicken corn soup",
               "Hot & Sour soup" ,
               "Russian Salad",
               "Chicken stick boti"
                             };
         
        }
        private void maincourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            maincourse.Items.Add("Main Course:");
            string[] items = {
               "Chicken Malai Handi" ,
               "Mutton Rogan Josh",
               "Chicken Shinwari Karhai",
               "Beef Biryani" ,
               "Dhaga Kabab/ seekh kabab / gola kabab"
                             };
          
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Desserts.Items.Add("Dessert:");
            string[] items = {
               "Gulab Jamun",
               "Kheer",
               "Doodh Dulari" ,
               "Rabri" ,
               "Gajar Ka Halwa"
                             };
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            maincourse.Items.Add("Beverage options: ");
            string[] items = {
               "Chai" ,
               "Soft drinks",
               "Fruit juices",
               "Falooda",
               "Mineral Water"
                             };
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
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void recipt_Click(object sender, EventArgs e)
        {
            Voice v = new Voice();
            v.Show();
        }
    }
}
