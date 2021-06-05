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
    public partial class menudinein : Form
    {
      
        public menudinein()
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry v = new Entry();
            v.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Signin v = new Signin();
            v.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int check1=0,check2=0,check3=0;
            
            if(checkBox1.Checked == true)
            {
                check1 = 1;
            }
            if(checkBox2.Checked == true)
            {
                check2 = 1;
            }
            if(checkBox3.Checked == true)
            {
                check3 = 1;
            }



            int starter_value;
            int maincourse_value;
            int beverages_value;
            int breakfast_value;


            starter_value = int.Parse(starter_int.Text);
            maincourse_value = int.Parse(maincourse_int.Text);
            beverages_value = int.Parse(beverages_int.Text);
            breakfast_value = int.Parse(breakfast_int.Text);

            if (starter_value == 0 && maincourse_value == 0 && beverages_value == 0 && breakfast_value == 0
                && desserts_int.Text == "Select" && lunch_int.Text == "Select" && dinner_int.Text == "Select")
            {
                MessageBox.Show("Please Select the Qty!");
            }
            else
            {
                
                Recipt starter = new Recipt(starters.Text, maincourse.Text,
                    Desserts.Text, beverages.Text, breakfast.Text,
                   lunch.Text, dinner.Text, starter_value, maincourse_value,
                   desserts_int.Text, beverages_value, breakfast_value,
                   lunch_int.Text, dinner_int.Text,check1,check2,check3);
                starter.ShowDialog();
                 this.Close();

            }
            

        }

    }
}
