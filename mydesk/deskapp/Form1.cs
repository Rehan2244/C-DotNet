using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deskapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userbox.Text == "Rehan" && passwordbox.Text == "54321")
            {
                Form2 successform = new Form2();
                successform.Show();
                this.Visible = false;
                
            }

            else
            {
                label1.Text = "Welcome Stranger";
                Form errfrm = new Form();
                errfrm.Text = "Error Try again";
                errfrm.Show();
            }
                    // && passwordbox.Text=="54321")
                //label1.Text = "Welcome "+userbox.Text;
        }
    }
}
