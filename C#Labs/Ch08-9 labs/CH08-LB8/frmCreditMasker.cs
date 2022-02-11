using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH08_LB8
{
    public partial class frmCreditMasker : Form
    {
       

        public frmCreditMasker()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {

            string cardNumber = (txtCardNumber.Text);
            if (cardNumber.Length > 4)
            {
                string fourDigts = cardNumber.Substring(cardNumber.Length - 4);
                string requiredMask = new String('#', cardNumber.Length - fourDigts.Length);
                string maskedString = string.Concat(requiredMask, fourDigts);
                lblHidden.Text = maskedString;
            }
            else
            {
                string fourDigts = cardNumber.Substring(cardNumber.Length - 0);
                string requiredMask = new String('#', cardNumber.Length - fourDigts.Length);
                string maskedString = string.Concat(requiredMask, fourDigts);
                lblHidden.Text = maskedString;
            }
        }
      

       
    }
}
