using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_FoodOrder
{
    public partial class Form1 : Form
    {
        const double SUNDAEBASEPRICE = 4.50;
        const double TOPPINGPRICE = 0.50;
        const double SODABASEPRICE = 1.75;
        const double FLAVORPRICE = 0.15;
       const string sundaeYes = "";
        string toppingYes = "";
        string sodaYes = "";
        const string sundaeNo = " ";
        string flavorYes = "";
        string name = "";
        double totalCost = 0;
        CheckBox checkBoxSundae;
        CheckBox checkBoxSoda;
        CheckBox checkBoxToppings;
        CheckBox checkBoxFlavor;
        const int count = 3;
        string[] orders = new string[count];
        int numElements = 0;

        public Form1()
        {
            InitializeComponent();
            cbSundae.CheckedChanged += new EventHandler(cbSundae_CheckedChanged);
            cbSoda.CheckedChanged += new EventHandler(cbSoda_CheckedChanged);
            cbSprinkles.CheckedChanged += new EventHandler(cbSprinkles_CheckedChanged);
            cbNuts.CheckedChanged += new EventHandler(cbSprinkles_CheckedChanged);
            cbChocolate.CheckedChanged += new EventHandler(cbSprinkles_CheckedChanged);
            cbLime.CheckedChanged += new EventHandler (cbLime_CheckedChanged);
            cbPeach.CheckedChanged += new EventHandler(cbLime_CheckedChanged);
            cbMango.CheckedChanged += new EventHandler(cbLime_CheckedChanged);

        }
        List<Order> ticket = new List<Order>(count);
        List<Sundae> sundaeOrder = new List<Sundae>(count);

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            if(keepGoing)
            {
                keepGoing = vaildName();

            }
            else
            {
                return;
            }
            if(keepGoing)
            {
             


            }
                

        }
        private bool vaildName()
        {
            try
            {
                string name = txtOrderName.Text;
                if (name == "")
                {
                    lblErrorName.Text = " Name required/no food selected";
                    
                }
                else
                {
                    Order nm = new Order(txtOrderName.Text);
                    if (numElements < count)
                    {
                        ticket.Add(nm);
                        txtTicket.Text += nm.ToString() + "\r\n" + "-----------------------------" + "\r\n";
                        orders = txtTicket.Text.Split('\n');
                        ++numElements;
                        lblErrorName.Text = "";
                       
                    }
                }
                return true;

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Must enter a name in for the order" + fe.Message + "NO NAME INPUTTED");
                txtOrderName.Text = "";
                txtOrderName.Focus();
                return false;
            }
        }

        private void vaildSundae()
        {
          
           
            
        }


        private void cbSundae_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSundae.Checked)
            {
                cbChocolate.Enabled = true;
                cbNuts.Enabled = true;
                cbSprinkles.Enabled = true;
                cbPeach.Enabled = false;
                cbLime.Enabled = false;
                cbMango.Enabled = false;
                cbSoda.Enabled = false;

                if (numElements < count)
                {
                  
                    Sundae sd = new Sundae(cbChocolate.Text,cbNuts.Text,cbSprinkles.Text );
                    txtTicket.Text = sd.ToString();
                    ticket.Add(sd);
                    txtTicket.Text += sd.ToString() + "\r\n" + "-----------------------------" + "\r\n";
                    orders = txtTicket.Text.Split('\n');
                    ++numElements;
                    lblErrorName.Text = "";

                }
               
            }
            else
            {
                cbChocolate.Enabled = false;
                cbNuts.Enabled = false;
                cbSprinkles.Enabled = false;
                cbPeach.Enabled = false;
                cbLime.Enabled = false;
                cbMango.Enabled = false;
                cbSoda.Enabled = true;
               

            }


        }

        private void cbSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoda.Checked)
            {
                cbChocolate.Enabled = false;
                cbNuts.Enabled = false ;
                cbSprinkles.Enabled = false;
                cbPeach.Enabled = true;
                cbLime.Enabled = true;
                cbMango.Enabled = true;
                cbSundae.Enabled = false;
            }
            else
            {
                cbChocolate.Enabled = false;
                cbNuts.Enabled = false;
                cbSprinkles.Enabled = false;
                cbPeach.Enabled = false;
                cbLime.Enabled = false;
                cbMango.Enabled = false;
                cbSoda.Enabled = true;
                cbSundae.Enabled = true;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbSprinkles_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                checkBoxToppings = (CheckBox)sender;
                toppingYes = checkBoxToppings.Name.Remove(2);

            }
        }

        private void cbLime_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                checkBoxFlavor = (CheckBox)sender;
                flavorYes = checkBoxFlavor.Name.Remove(2);

            }
        }
    }

}
