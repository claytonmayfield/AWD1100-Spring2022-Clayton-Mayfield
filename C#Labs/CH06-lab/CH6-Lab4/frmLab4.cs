using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH6_Lab4
{
    public partial class frmLab4 : Form
    {
        public frmLab4()
        {
            InitializeComponent();
        }
       
        string strAccpet = "accpet";
        string strRejct = "reject";
        private void btnAdmit_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(txtGpa.Text);
            double testscore = Convert.ToDouble(txtTestScore.Text);

            if (gpa >= 3.0 && testscore >= 60)
            {
                bool accept = CheckAll();

            }
            else if (gpa < 3.0 && testscore >= 80)
            {

                bool accept = CheckAll();

            }
            else
            {
                bool reject = CheckAll2();
               
            }

        }
        private bool CheckAll()
        {
            bool accept = true;
            if (accept)
            {
                lblAccept.Text = strAccpet;
                return true;

            }
            else
            {
                lblAccept.Text = strAccpet;
                return true;
            }


        }
        private bool CheckAll2()
        {
            bool reject = false;
            if (reject)
            {
                lblAccept.Text = strRejct;
                return false;

            }
            else
            {
                lblAccept.Text = strRejct;
                return false;
            }
        }



    }
}
