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
    public partial class Recipt : Form
    {  
        public Recipt()
        {
            InitializeComponent();
        }

      ///  public Recipt(string userid)
      //  {
           // this.userid = userid;
      //  }
        public Recipt(string starters, string maincourse, string Desserts, string beverages, string breakfast, string lunch, 
            string dinner,int starter_int, int maincourse_int, string desserts_int, int beverages_int, int breakfast_int, string lunch_int, string dinner_int)
        {
            InitializeComponent();
            this.starters = starters;
            this.maincourse = maincourse;
            this.Desserts = Desserts;
            this.beverages = beverages;
            this.breakfast = breakfast;
            this.lunch = lunch;
            this.dinner = dinner;
            this.starter_int = starter_int;
            this.maincourse_int = maincourse_int;
            this.desserts_int = desserts_int;
            this.beverages_int = beverages_int;
            this.breakfast_int = breakfast_int;
            this.lunch_int = lunch_int;
            this.dinner_int = dinner_int;
            
        }
        //PRICES
        // int starters;
        // int maincourse;
        // int Desserts;
        //  int beverages;
        // int breakfast;
        //  int lunch;
        // int dinner;

        int price=0,sum;

        private void calculate_Click(object sender, EventArgs e)
        {
            if (dish1.Text != "Options:")
            {
                price += 250 * starter_int;
                starters_price.Text = price + "Rs";
            }
            else { starters_price.Text = "0RS"; }
        }


        //VALUES PASSING FROM MENU
        string starters;
        string maincourse;
        string Desserts;
        string beverages;
        string breakfast;
        string lunch;
        string dinner;
        int starter_int;
        int maincourse_int;
        string desserts_int;
        int beverages_int;
        int breakfast_int;
        string lunch_int;
        string dinner_int;

        //logicID
      //  string userid;
        
        private void reciptbutton_Click(object sender, EventArgs e)
        {
            //PRICES
            /* Hot and sour soup
               Chicken corn soup
               Russian Salad
               Chicken sticks 
            */

          


            //menu items
            dish1.Text = starters;
           dish2.Text = maincourse;
           dish3.Text = Desserts;
           dish4.Text = beverages;
           dish5.Text = breakfast;
           dish6.Text = lunch;
           dish7.Text = dinner;
            if(dish1.Text == "Options:")
            {
                dish1.Text = "No item";
            }if(dish2.Text == "Options:")
            {
                dish2.Text = "No item";
            }if(dish3.Text == "Options:")
            {
                dish3.Text = "No item";
            }if(dish4.Text == "Options:")
            {
                dish4.Text = "No item";
            }if(dish5.Text == "Options:")
            {
                dish5.Text = "No item";
            }if(dish6.Text == "Options:")
            {
                dish6.Text = "No item";
            }if(dish7.Text == "Options:")
            {
                dish7.Text = "No item";
            }


            //LOGIN ID

           // loginid.Text = userid;
                
                
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

      

        
    }
}
