using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Loan
{
    public partial class frmBankLoan : Form
    {
        public frmBankLoan()
        {
            InitializeComponent();
        }
       List<ShortTerm> termList = new List<ShortTerm>();
        const double LONGTERMPAY = 200;
        const double SHORTTERMPAY = 450;
        const double LONGTERMPAYINT = 0.05;
        const double SHORTTERMPAYINT = 0.10;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            double vaild = Convert.ToDouble(txtAmount.Text);
            if (vaild < 0)
            {
                MessageBox.Show("please put a vaild input", "No negative numbers");
                txtAmount.Text = "";
            }
            else
            {
                RaidoButton();
            }
            
        }
        
        
        private void RaidoButton()
        {
            if (rbShortTerm.Checked)
            {
               double nm = Convert.ToDouble(txtAmount.Text);
                lblNameOutPut.Text = txtName.Text;
                lblTypeOutPut.Text = "Short-Term Loan of" + " " + nm.ToString("c");

            }
            else if (rbLongTerm.Checked)
            {
                double nm = Convert.ToDouble(txtAmount.Text);
                lblNameOutPut.Text = txtName.Text;
                lblTypeOutPut.Text = "Long-Term Loan of" + " " + nm.ToString("c");
            }
        }
        
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            Calcu();
        }
        private void Calcu()
        {
            if (rbShortTerm.Checked)
            {
              
                    double pay = Convert.ToDouble(txtAmount.Text);
                    double sub = pay - SHORTTERMPAY;
                    lblPayment.Text = "After the last payment the loan is down to" + " " + sub.ToString("c");
                    //////////////////////////////
                    double inter = SHORTTERMPAYINT * sub;
                    double total = sub + inter;
                    lblInterest.Text = "After the last interest accumulation the loan is now" + " " + total.ToString("c");


            }
            else if (rbLongTerm.Checked)
            {
                double pay = Convert.ToDouble(txtAmount.Text);
                double sub = pay - LONGTERMPAY;
                lblPayment.Text = "After the last payment the loan is down to" + " " + sub.ToString("c");
                //////////////////////////////
                double inter = LONGTERMPAYINT * sub;
                double total = sub + inter;
                lblInterest.Text = "After the last interest accumulation the loan is now" + " " + total.ToString("c");
            }
        }

       
    }
}
