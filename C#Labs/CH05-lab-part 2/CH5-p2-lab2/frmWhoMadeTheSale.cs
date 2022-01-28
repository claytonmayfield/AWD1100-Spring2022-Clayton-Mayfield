using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH5_p2_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double danielleTotal = 0;
        double edwardTotal = 0;
        double francisTotal = 0;
        double grandTotal = 0;
        private void btnDanielle_Click(object sender, EventArgs e)
        {
            
            decimal saleAmount1 = Convert.ToDecimal(txtSaleAmout.Text);
            decimal[] amount1 = {saleAmount1};
            foreach (double i in amount1)
            {
                danielleTotal += i;
            }
            lblDanielleSales.Text = Convert.ToString("Danielle Sales" + " " + danielleTotal);
            txtSaleAmout.Text = String.Empty;
            txtSaleAmout.Focus();

        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            decimal saleAmount2 = Convert.ToDecimal(txtSaleAmout.Text);
            
            decimal[] amount2 = { saleAmount2 };
            foreach (double i in amount2)
            {
                edwardTotal += i;
            }
            lblEdwardSales.Text = Convert.ToString("Edward sales" + " " + edwardTotal);
            txtSaleAmout.Text = String.Empty;
            txtSaleAmout.Focus();
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
        decimal saleAmount3 = Convert.ToDecimal(txtSaleAmout.Text);
            
        decimal[] amount3 = { saleAmount3 };
            foreach (double i in amount3)
            {
                francisTotal += i;
            }
            lblFrancisSales.Text = Convert.ToString("Francis Sales" + " " + francisTotal);
            txtSaleAmout.Text = String.Empty;
            txtSaleAmout.Focus();
        }

        public void btnGrandTotal_Click(object sender, EventArgs e)
        {
            grandTotal = danielleTotal + edwardTotal + francisTotal;
            lblTotal.Text = Convert.ToString("the  grand total is" + " " + grandTotal);

            if (danielleTotal > edwardTotal && danielleTotal > francisTotal)
            {
                lblMostSales.Text = "Danielle has the most sales";
                return;
            }
            else if (edwardTotal > danielleTotal && edwardTotal > francisTotal)
            {
                lblMostSales.Text = "Edward has the most sales";
                return;
            }
            else
            {
                lblMostSales.Text = "Francis has the most sales";
                return;
            }
               
          
           
             
        }
    }
}
