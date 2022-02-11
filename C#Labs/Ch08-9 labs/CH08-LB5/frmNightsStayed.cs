using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH08_LB5
{
    public partial class frmNightsStayed : Form
    {
        public frmNightsStayed()
        {
            InitializeComponent();
        }
        double[] nights = { 1, 2, 3, 4, 5, 6, 7, 8 };
        double[] rate = { 200,200, 180,180, 160,160,160, 145 };
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double text = Convert.ToDouble(txtNightsStayed.Text);
           
            for(int lcv = 0; lcv < nights.Length; ++lcv)
            {
                if (nights[lcv] == text)
                {
                    lblCost.Text = rate[lcv].ToString("c");
                  double total =  rate[lcv] * nights[lcv];
                    lblTotalCost.Text = total.ToString("c");
                    
                }
                else if (text > 8)
                {
                    lblCost.Text = "$200";
                }

            }
        }
     
    }
}
