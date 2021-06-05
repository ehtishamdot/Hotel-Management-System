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
            int starter_value;
            int maincourse_value;
            int beverages_value;

            starter_value = int.Parse(starter_int.Text);
            maincourse_value = int.Parse(maincourse_int.Text);
            beverages_value = int.Parse(beverages_int.Text);
            if (starter_value == 0 && maincourse_value == 0 && beverages_value == 0
               && desserts_int.Text == "Select")
            {
                MessageBox.Show("Please Select the Qty!");
            }
            else
            {
                Recipt starter = new Recipt(starters.Text, maincourse.Text, Desserts.Text, beverages.Text,
                  starter_value, maincourse_value, desserts_int.Text, beverages_value);
                starter.ShowDialog();
                this.Close();
            }



        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Signin v = new Signin();
            v.Show();
        }
    }
}
