using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace deskapp
{
    public partial class Form2 : Form
    {
        string result = "";
        
        public Form2()
        {
            InitializeComponent();
            cottonRadio.Checked = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer = "", type = "";
            int amount, quantity;
            



            //quantity = int.Parse(textBox2.Text);
            if (cottonRadio.Checked)
            {
                type = "cotton";
            }
            else if(pcottonRadio.Checked)
            {
                type = "p cotton";
            }
            
            

            takhaLabel.Text = "Takha(Unit): "+takhaBox.Text;                            //for quantity
            custLabel.Text = "Customer: "+CustomerBox.Text;                           //for customer name




            if (takhaBox.Text.ToString() != "")
            {
                if (cottonRadio.Checked == true)
                {
                    pricepermtrLabel.Text = "Price/meter: 7 Rs";              //price per meter 
                    amount = (int.Parse(takhaBox.Text)*80) * 7;                               // convert and calculate amount according to quantity of cotton
                    amountBox.Text = amount.ToString();
                }
                else if (pcottonRadio.Checked == true)
                {
                    pricepermtrLabel.Text = "Price/meter: 5 Rs";              //price per meter 
                    amount = (int.Parse(takhaBox.Text)*80) * 5;                               // convert and calculate amount according to quantity of paper cotton
                    amountBox.Text = amount.ToString();
                }
                else
                {
                    amount = 0;
                    amountBox.Text = amount.ToString();
                }
                amount = int.Parse(amountBox.Text.ToString());
                amountLabel.Text = "Amount(Rs): " + amountBox.Text;
                quantitybox.Text = (int.Parse(takhaBox.Text) * 80).ToString();
                quantityLabel.Text="Quantity(mtrs):"+ (int.Parse(takhaBox.Text) * 80).ToString();
            }
            else
            {
                MessageBox.Show("Enter takha");
                
            }
                                     // for total amount

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                                           // convert and calculate amount according to quantity according to cotton
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerBox.Text = "";
            takhaBox.Text = "";
            amountBox.Text = "";
            custLabel.Text = "Customer: ";
            pricepermtrLabel.Text = "Price/meter: ";
            takhaLabel.Text = "Takha(Unit): ";
            amountLabel.Text = "Amount(Rs): ";
            quantitybox.Text = "";
            quantityLabel.Text = "Quantity(mtrs):";
            cottonRadio.Checked = true;
            pcottonRadio.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionAddress = "server=localhost;port=3306;database=tajtextiles;uid='root';password='root'";

            using (MySqlConnection connect = new MySqlConnection(connectionAddress))
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand("select * from orders", connect))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = result + dr.GetValue(0) + "-" + dr.GetValue(1) + "-" + dr.GetValue(2) + "-" + dr.GetValue(3) + "\n";
                            }
                        }
                        MessageBox.Show(result);
                        result = "";
                    }
                }
                connect.Close();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string type = "none";
            if (cottonRadio.Checked)
            {
                type = "cotton";
            }
            else if(pcottonRadio.Checked)
            {
                type = "p cotton";
            }
            else
            {
                MessageBox.Show("Select Order Type(cotton\\paper cotton?)");
            }
            
            

            string connectionAddress = "server=localhost;port=3306;database=tajtextiles;uid='root';password='root'";
            if (CustomerBox.Text.ToString() != "" && takhaBox.Text.ToString() != "" && amountBox.Text.ToString() != "" && quantitybox.Text.ToString() != "")
            {string customer = CustomerBox.Text.ToString() ;
                int amount = int.Parse(amountBox.Text), quantity = int.Parse(quantitybox.Text), takhaunit = int.Parse(takhaBox.Text);
                using (MySqlConnection connect = new MySqlConnection(connectionAddress))
                {
                    connect.Open();
                    string insert = "insert into orderstest(customername,quatity,typeoforder,totalamount,takha,ordertime) values('" + customer + "'," + quantity + ",'" + type + "'," + amount + "," + takhaunit + ",current_timestamp())";
                    MessageBox.Show(insert);

                    using (MySqlCommand cmd = new MySqlCommand(insert, connect))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record saved");

                    }
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill required fields \nIf already done Clicke on Calculate Button");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void num_only(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
