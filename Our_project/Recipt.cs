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
        int check1;
        int check2;
        int check3;
        public Recipt()
        {
            InitializeComponent();
        }
        string userid;
        public Recipt(string userid)
          {
       
          }

        //TAKEAWAY
        public Recipt(string starters, string maincourse, string Desserts, string beverages,
          int starter_int, int maincourse_int, string desserts_int, int beverages_int)
        {
            InitializeComponent();
            this.starters = starters;
            this.maincourse = maincourse;
            this.Desserts = Desserts;
            this.beverages = beverages;
            this.breakfast = "Not Available!";
            this.starter_int = starter_int;
            this.maincourse_int = maincourse_int;
            this.desserts_int = desserts_int;
            this.beverages_int = beverages_int;

        }


        ///DINEIN
        public Recipt(string starters, string maincourse, string Desserts, string beverages, 
            string breakfast, string lunch,string dinner, int starter_int, int maincourse_int, 
            string desserts_int, int beverages_int, int breakfast_int, string lunch_int,
            string dinner_int,int check1,int check2,int check3)
        {
            InitializeComponent();


            //Dishes
            this.starters = starters;
            this.maincourse = maincourse;
            this.Desserts = Desserts;
            this.beverages = beverages;
            this.breakfast = breakfast;
            this.lunch = lunch;
            this.dinner = dinner;

            //Quantity
            this.starter_int = starter_int;
            this.maincourse_int = maincourse_int;
            this.desserts_int = desserts_int;
            this.beverages_int = beverages_int;
            this.breakfast_int = breakfast_int;
            this.lunch_int = lunch_int;
            this.dinner_int = dinner_int;

            //CheckBox
            this.check1 = check1;
            this.check2 = check2;
            this.check3 = check3;
           

        }

      
        private void reset_Click(object sender, EventArgs e)
        {

            starters_price.Text = "0RS";
            maincourse_price.Text = "0RS";
            dessert_price.Text = "0RS";
            beverages_price.Text = "0RS";
            breakfast_price.Text = "0RS";
            lunch_price.Text = "0RS";
            dinner_price.Text = "0RS";

            if (dish1.Text != "No item")
            {
                dish1.Text = "No item";
            }
            if (dish2.Text != "No item")
            {
                dish2.Text = "No item";
            }
            if (dish3.Text != "No item")
            {
                dish3.Text = "No item";
            }
            if (dish4.Text != "No item")
            {
                dish4.Text = "No item";
            }
            if (dish5.Text != "No item")
            {
                dish5.Text = "No item";
            }
            if (dish6.Text != "No item")
            {
                dish6.Text = "No item";
            }
            if (dish7.Text != "No item")
            {
                dish7.Text = "No item";
            }

            if (starter_int != 0)
            {                
                starter_qt.Visible = false;
            }

            if (maincourse_int != 0)
            {              
                maincourse_qt.Visible = false;
            }
            if (desserts_int != "Select")
            {
                desserts_qt.Visible = false;
            }
            if (beverages_int != 0)
            {
                beverages_qt.Visible = false;
            }

            if (breakfast_int != 0)
            {
                breakfast_qt.Visible = false;
            }
            if (lunch_int != "Select")
            {
                lunch_qt.Visible = false;
            }
            if (dinner_int != "Select")
            {
                dinner_qt.Visible = false;
            }
            if (check1 == 1)
            {
                pictureBox1.Visible = false;
            }
            if (check2 == 1)
            {
                pictureBox2.Visible = false;
            }
            if (check3 == 1)
            {
                pictureBox3.Visible = false;
            }

            finalbill.Text = "0Rs";
        }
        private void calculate_Click(object sender, EventArgs e)     //for starter
        {
            int price = 0, price2 = 0, price3 = 0;
            int price4 = 0, price5 = 0, price6 = 0, price7 = 0;
            int sum;


            //Price Calculator

            if (starters != "Options:")
            {
                price += 250;
                if (starter_int != 0)
                {
                    price *= starter_int;
                }               
                starters_price.Text = price + "Rs";
            }
            else { starters_price.Text = "0RS"; }

           
            if (maincourse != "Options:")
            {
                price2 += 550;
                if (maincourse_int != 0)
                {
                    price2 *= maincourse_int;
                }
              
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
                price4 += 150;
                if (beverages_int != 0)
                {
                    price4 *= beverages_int;
                }                
                beverages_price.Text = price4 + "Rs";
            }
            else { beverages_price.Text = "0RS"; }


                if (breakfast != "Options:")
                {
                    price5 += 200;
                    if (breakfast_int != 0)
                    {
                        price5 *= breakfast_int;
                    }

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
                    if (dinner_int == "Half")
                    {
                        price7 += 200;
                        dinner_price.Text = price7 + "Rs";
                    }
                    else if (dinner_int == "Full")
                    {
                        price7 += 400;
                        dinner_price.Text = price7 + "Rs";
                    }
                }
                else { dinner_price.Text = "0RS"; }
            
            //Quantity qtQ

            if (starter_int != 0)
            {
                starter_qt.Text = "x" + starter_int;
                starter_qt.Visible = true;
            }
            
            if (maincourse_int != 0)
            {
                maincourse_qt.Text = "x" +maincourse_int ;
                maincourse_qt.Visible = true;
            }
            if (desserts_int != "Select")
            {
                desserts_qt.Text = "" + desserts_int;
                desserts_qt.Visible = true;
            }
            if (beverages_int != 0)
            {
                beverages_qt.Text = "x" + beverages_int;
                beverages_qt.Visible = true;
            }
           
            if (breakfast_int != 0)
            {
                breakfast_qt.Text = "x" + breakfast_int;
                breakfast_qt.Visible = true;
            }
                      
            if (lunch_int != "Select")
            {
                lunch_qt.Text = "" + lunch_int;
                lunch_qt.Visible = true;
            } 
      //    if (lunch_int != "xNot Available!") { lunch_qt.Visible = false; }


            if (dinner_int != "Select")
            {
                dinner_qt.Text = "" + dinner_int;
                dinner_qt.Visible = true;
            }
       //  if (dinner_int != "xNot Available!") { dinner_qt.Visible = false; }


            //Special needs

            if (check1 == 1)
            {
                pictureBox1.Visible = true;
            }
            if (check2 == 1)
            {
                pictureBox2.Visible = true;
            }
            if (check3 == 1)
            {
                pictureBox3.Visible = true;
            }

            //menu items

            dish1.Text = starters;
            dish2.Text = maincourse;
            dish3.Text = Desserts;
            dish4.Text = beverages;
            dish5.Text = lunch;
            dish6.Text = breakfast;
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

            

            //final BIll
            sum = price + price2 + price3 + price4 + price5 + price6 + price7;
            finalbill.Text = sum+"Rs";
            modepayment.Text = paymentmode.Text;
            finalbill.Visible = true;
            paymentmode.Visible = true;
            loginid.Visible = true;

        }

 


        //logicID
        //  string userid;
        private void reciptbutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
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
   
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Signin v = new Signin();
            v.Show();
        }

        private void star1_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }

        private void star2_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }

        private void star3_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
        }

        private void star4_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel5.BackColor = Color.Black;
        }

        private void star5_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Entry v = new Entry();
            v.Show();
            this.Close();
        }

        private void Dinein_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Signin v = new Signin();
            v.Show();
            this.Close();
        }

        
    }
}