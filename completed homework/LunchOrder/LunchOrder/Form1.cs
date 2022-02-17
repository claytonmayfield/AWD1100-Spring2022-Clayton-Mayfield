using System;
using System.Windows.Forms;


namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double taxRate = 0.0725;
        double hamburger = 6.95;
        double pizza = 5.95;
        double salad = 4.95;
        //hamburger add ons
        double lettuce = .75;
        double ketchup = .75;
        double french = .75;
        //pizza add ons 
        double Pepperoni = .50;
        double Sausage = .50;
        double Olives = .50;
        // salad add ons
        double croutons = .25;
        double bacon = .25;
        double bread = .25;
        public static double outPutStr;
        private void clearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }
        private void clearAddOns()
        {
            cbLettuce.Checked = false;
            cbFrenchFries.Checked = false;
            cbKetchup.Checked = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKetchup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(rbHamburger.Checked)
            {
                HamburgerTotal();
            }
            if(rbPizza.Checked)
            {
                pizzaTotal();
            }
            if(rbSalad.Checked)
            {
                saladTotal();
            }
        }
        private void HamburgerTotal()
        {
            if(cbLettuce.Checked)
            {
                double addOn1 = hamburger + lettuce;
                txtSubtotal.Text = addOn1.ToString("c");
                double tax = addOn1 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn1;
                txtOrderTotal.Text = orderTotal.ToString("c");
                    outPutStr = addOn1;
            }
            if (cbKetchup.Checked)
            {
                double addOn2 = hamburger + ketchup;
                txtSubtotal.Text = addOn2.ToString("c");
                double tax = addOn2 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn2;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn2;
            }
            if (cbFrenchFries.Checked)
            {
                double addOn3 = hamburger + french;
                txtSubtotal.Text = addOn3.ToString("c");
                double tax = addOn3 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn3;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn3;
            }
            if (cbFrenchFries.Checked && cbLettuce.Checked)
            {
                double addOn4 = hamburger + french + lettuce;
                txtSubtotal.Text = addOn4.ToString("c");
                double tax = addOn4 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn4;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn4;
            }
            if (cbLettuce.Checked && cbKetchup.Checked)
            {
                double addOn6 = hamburger + lettuce + ketchup;
                txtSubtotal.Text = addOn6.ToString("c");
                double tax = addOn6 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn6;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn6;
            }
            if (cbKetchup.Checked && cbFrenchFries.Checked)
            {
                double addOn7 = hamburger + ketchup + french;
                txtSubtotal.Text = addOn7.ToString("c");
                double tax = addOn7 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn7;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn7;
            }
            if (cbLettuce.Checked && cbKetchup.Checked && cbFrenchFries.Checked)
            {
                double addOn5 = hamburger + lettuce + french + ketchup;
                txtSubtotal.Text = addOn5.ToString("c");
                double tax = addOn5 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn5;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn5;
            }

        }
        private void pizzaTotal()
        {
            if (cbLettuce.Checked)
            {
                double addOn1 = pizza + Pepperoni;
                txtSubtotal.Text = addOn1.ToString("c");
                double tax = addOn1 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn1;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn1;
            }
            if (cbKetchup.Checked)
            {
                double addOn2 = pizza + Sausage;
                txtSubtotal.Text = addOn2.ToString("c");
                double tax = addOn2 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn2;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn2;
            }
            if (cbFrenchFries.Checked)
            {
                double addOn3 = pizza + Olives;
                txtSubtotal.Text = addOn3.ToString("c");
                double tax = addOn3 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn3;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn3;
            }
            if (cbFrenchFries.Checked && cbLettuce.Checked)
            {
                double addOn4 = pizza + Olives + Pepperoni;
                txtSubtotal.Text = addOn4.ToString("c");
                double tax = addOn4 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn4;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn4;
            }
            if (cbLettuce.Checked && cbKetchup.Checked)
            {
                double addOn6 = pizza + Pepperoni + Sausage;
                txtSubtotal.Text = addOn6.ToString("c");
                double tax = addOn6 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn6;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn6;
            }
            if (cbKetchup.Checked && cbFrenchFries.Checked)
            {
                double addOn7 = pizza + Sausage + Olives;
                txtSubtotal.Text = addOn7.ToString("c");
                double tax = addOn7 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn7;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn7;
            }
            if (cbLettuce.Checked && cbKetchup.Checked && cbFrenchFries.Checked)
            {
                double addOn5 = pizza + Pepperoni + Olives + Sausage;
                txtSubtotal.Text = addOn5.ToString("c");
                double tax = addOn5 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn5;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn5;
            }
        }
        private void saladTotal()
        {
            if (cbLettuce.Checked)
            {
                double addOn1 = salad + croutons;
                txtSubtotal.Text = addOn1.ToString("c");
                double tax = addOn1 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn1;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn1;
            }
            if (cbKetchup.Checked)
            {
                double addOn2 = salad + bacon;
                txtSubtotal.Text = addOn2.ToString("c");
                double tax = addOn2 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn2;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn2;
            }
            if (cbFrenchFries.Checked)
            {
                double addOn3 = salad + bread;
                txtSubtotal.Text = addOn3.ToString("c");
                double tax = addOn3 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn3;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn3;
            }
            if (cbFrenchFries.Checked && cbLettuce.Checked)
            {
                double addOn4 = salad + bread + croutons;
                txtSubtotal.Text = addOn4.ToString("c");
                double tax = addOn4 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn4;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn4;
            }
            if (cbLettuce.Checked && cbKetchup.Checked)
            {
                double addOn6 = salad + croutons + bacon;
                txtSubtotal.Text = addOn6.ToString("c");
                double tax = addOn6 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn6;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn6;
            }
            if (cbKetchup.Checked && cbFrenchFries.Checked)
            {
                double addOn7 = salad + bacon + bread;
                txtSubtotal.Text = addOn7.ToString("c");
                double tax = addOn7 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn7;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn7;
            }
            if (cbLettuce.Checked && cbKetchup.Checked && cbFrenchFries.Checked)
            {
                double addOn5 = salad + croutons + bread + bacon;
                txtSubtotal.Text = addOn5.ToString("c");
                double tax = addOn5 * taxRate;
                txtSalesTax.Text = tax.ToString("c");
                double orderTotal = tax + addOn5;
                txtOrderTotal.Text = orderTotal.ToString("c");
                outPutStr = addOn5;
            }
        }

        private void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPizza.Checked)
            {
                cbLettuce.Text = "pepperoni";
                cbKetchup.Text = "Sausage";
                cbFrenchFries.Text = "Olives";
                gbAddOns.Text = "Add-on items ($.50/each)";
                clearAddOns();
                clearTotals();
            }
        }

        private void rbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHamburger.Checked)
            {
                cbLettuce.Text = "lettuce,tomato, and onions";
                cbKetchup.Text = "Ketchup,mustard, and mayo";
                cbFrenchFries.Text = "French Fries";
                gbAddOns.Text = "Add-on items ($.75/each)";
                clearAddOns();
                clearTotals();

            }
        }

        private void rbSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalad.Checked)
            {
                cbLettuce.Text = "Croutons";
                cbKetchup.Text = "Bacon bits";
                cbFrenchFries.Text = "Bread Stick";
                gbAddOns.Text = "Add-on items ($.25/each)";
                clearAddOns();
                clearTotals();
            }
        }

        private void btnSaletax_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            frm2.Show();
            txtSalesTax.Text = outPutStr.ToString("c");
            

        }
    }
}
