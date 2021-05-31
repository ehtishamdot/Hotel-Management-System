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

        ///  public Recipt(string userid)
        //  {
        // this.userid = userid;
        //  }
        public Recipt(string starters, string maincourse, string Desserts, string beverages, string breakfast, string lunch,
            string dinner, int starter_int, int maincourse_int, string desserts_int, int beverages_int, int breakfast_int, string lunch_int, string dinner_int)
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

       
        
        private void calculate_Click(object sender, EventArgs e)     //for starter
        {
            int price = 0, price2 = 0, price3 = 0;
            int price4 = 0, price5 = 0, price6=0 ,price7=0;
            int sum;
           

            if (starters != "Options:")
            {
                price += 250 * starter_int;
                starters_price.Text = price + "Rs";
            }
            else { starters_price.Text = "0RS"; }

            MessageBox.Show(dish2.Text);
            if (maincourse != "Options:")
            {
                price2 += 550 * maincourse_int;
                maincourse_price.Text = price2 + "Rs";
            }
            else { maincourse_price.Text = "0RS"; }
            
            if (Desserts != "Options:")
            {
                if (desserts_int == "Half")
                {
                    price3 += 200;
                    dessert_price.Text = price3 + "Rs";
                }
                else if (desserts_int == "Full")
                {
                    price3 += 400;
                    dessert_price.Text = price3 + "Rs";
                }
            }
            else { dessert_price.Text = "0RS"; }

            if (beverages != "Options:")
            {
                price4 += 150 * beverages_int;
                beverages_price.Text = price4 + "Rs";
            }
            else { beverages_price.Text = "0RS"; }

            if (breakfast != "Options:")
            {
                price5 += 200 * breakfast_int;
                breakfast_price.Text = price5 + "Rs";
            }
            else { breakfast_price.Text = "0RS"; }

            if (lunch != "Options:")
            {
                if (lunch_int == "Half")
                {
                    price6 += 200;
                    lunch_price.Text = price6 + "Rs";
                }
                else if (lunch_int == "Full")
                {
                    price6 += 400;
                    lunch_price.Text = price6 + "Rs";
                }
            }
            else { lunch_price.Text = "0RS"; }

            if (dinner != "Options:")
            {
                price7 += 200 * breakfast_int;
                dinner_price.Text = price7 + "Rs";
            }
            else { dinner_price.Text = "0RS"; }

            //final BIll
            sum = price + price2 + price3 + price4 + price5 + price6 + price7;
            finalbill.Text = sum.ToString();
            modepayment.Text = paymentmode.Text;
            finalbill.Visible = true;
            paymentmode.Visible = true;

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
        private void reciptbutton_Click_1(object sender, EventArgs e)
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
            if (dish1.Text == "Options:")
            {
                dish1.Text = "No item";
            }
            if (dish2.Text == "Options:")
            {
                dish2.Text = "No item";
            }
            if (dish3.Text == "Options:")
            {
                dish3.Text = "No item";
            }
            if (dish4.Text == "Options:")
            {
                dish4.Text = "No item";
            }
            if (dish5.Text == "Options:")
            {
                dish5.Text = "No item";
            }
            if (dish6.Text == "Options:")
            {
                dish6.Text = "No item";
            }
            if (dish7.Text == "Options:")
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

        private void exit_Click_1(object sender, EventArgs e)
        {

        }
    }
}