using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH08_LB4
{
    public partial class frmDeliveryCharge : Form
    {
        public frmDeliveryCharge()
        {
            InitializeComponent();
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double[] zipCode = { 63101, 63103, 63105, 63109, 63113, 63118, 63130, 63133, 63136, 63137 };
            double[] charge = { 20, 12, 25, 15, 10, 23, 18, 20, 17, 12 };
            double text = Convert.ToDouble(txtZipCode.Text);
           

            for (int lcv = 0; lcv < zipCode.Length; ++lcv)
            {
                if (zipCode[lcv] == text)
                {
                    lblDeliveryfee.Text = charge[lcv].ToString("c");
                }

            }
        }
        
        
    }
}
