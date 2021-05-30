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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }
      
        private void dinein_MouseHover(object sender, EventArgs e)
        {
            dinein.BackColor = Color.LightGray;
        }

        private void dinein_MouseLeave(object sender, EventArgs e)
        {
            dinein.BackColor = Color.White;
        }

        private void takeaway_MouseHover(object sender, EventArgs e)
        {
            takeaway.BackColor = Color.LightGray;
        }

        private void takeaway_MouseLeave(object sender, EventArgs e)
        {
            takeaway.BackColor = Color.White;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.ForeColor = Color.LightGray;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        
        private void takeaway_Click(object sender, EventArgs e)
        {
             this.Close();
            choices takeawy = new choices();
            takeawy.Show();

        }
    }
}
