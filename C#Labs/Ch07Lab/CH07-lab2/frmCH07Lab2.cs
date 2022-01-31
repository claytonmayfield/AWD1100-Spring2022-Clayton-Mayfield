using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH07_lab2
{
    public partial class frmCH07Lab2 : Form
    {
        public frmCH07Lab2()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            double itemNumber = Convert.ToDouble(txtItemNumber.Text);
            double quanity = Convert.ToDouble(txtQuanity.Text);
            double estimate = Convert.ToDouble(txtEstDelivery.Text);

            if(itemNumber >= 100 && itemNumber <= 999 && quanity >= 1 && quanity <= 12 && estimate >=1 && estimate <= 30 )
            {
                lblValid.Text = "order is vaild";
            }
            else
            {
                lblValid.Text = "Order is not vaild";
            }

        }
    }
}
