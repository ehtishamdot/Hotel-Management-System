using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Our_project.Resources
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Starter options:");
            string[] items = {  
               "Chicken corn soup", 
               "Hot & Sour soup" ,
               "Russian Salad",  
               "Chicken stick boti" 
                             };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Main Course:");
            string[] items = {  
               "Chicken Malai Handi" ,
               "Mutton Rogan Josh",  
               "Chicken Shinwari Karhai",  
               "Beef Biryani" ,
               "Dhaga Kabab/ seekh kabab / gola kabab"
                             };
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Add("Dessert:");
            string[] items = {  
               "Gulab Jamun",  
               "Kheer",  
               "Doodh Dulari" ,
               "Rabri" ,
               "Gajar Ka Halwa"
                             };
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Beverage options: ");
            string[] items = {  
               "Chai" ,
               "Soft drinks",  
               "Fruit juices",  
               "Falooda",
               "Mineral Water" 
                             };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Form3 myform = new Form3(); 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            myform.ShowDialog();
        }
    }
}
