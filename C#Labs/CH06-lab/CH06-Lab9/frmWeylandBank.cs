using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_Lab9
{
    public partial class frmWeylandBank : Form
    {
        public frmWeylandBank()
        {
            InitializeComponent();
        }
        string welcome1 = "welcome mr.smith";
        string accountBlance1 = "You have $10,000.00";
        string welcome2 = "welcome clayton";
        string accountBlance2 = "You have $11,0000.00";
        string person1Pin = "1234";
        string person1Account = "123456789";
        string person2Pin = "5678";
        string person2Account = "987654321";
        //double deposit1 = 0;
        decimal decAccountBlance1 = 10000;
        decimal decAccountBlance2 = 11000;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            string Account = Convert.ToString(txtAccount.Text);
            string pin = Convert.ToString(txtPin.Text);
            if (pin == person1Pin && Account == person1Account)
            {
                lblWelcome.Text = welcome1;
                lblAccountBalance.Text = accountBlance1;
                
            }
            else if (pin == person2Pin && Account == person2Account)
            {
                lblWelcome.Text = welcome2;
                lblAccountBalance.Text = accountBlance2;
              
            }
            else
            {
                MessageBox.Show("Wrong pin or account number", "Please try again",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string Account = Convert.ToString(txtAccount.Text);
            string pin = Convert.ToString(txtPin.Text);
            if (pin == person1Pin && Account == person1Account)
            {
               
                MakeDeposit1();
             
            }
            else if (pin == person2Pin && Account == person2Account)
            {
                MakeDeposit2();
               


            }
            else
            {
                MessageBox.Show("Not logged in", "Please try again",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MakeDeposit1()
        {
            
            decimal deposit = Convert.ToDecimal(txtDepositBox.Text);
            decimal deposit1 = decAccountBlance1 + deposit;
            lblAccountBalance.Text = Convert.ToString("Your new blance is" + " " + deposit1);
        }
        private void MakeDeposit2()
        {
            decimal deposit = Convert.ToDecimal(txtDepositBox.Text);
            decimal deposit2 = decAccountBlance2 + deposit;
            lblAccountBalance.Text = Convert.ToString("Your new blance is" + " " + deposit2);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string Account = Convert.ToString(txtAccount.Text);
            string pin = Convert.ToString(txtPin.Text);
            if (pin == person1Pin && Account == person1Account)
            {
                MakeWithdraw1();

            }
            else if (pin == person2Pin && Account == person2Account)
            {
                MakeWithdraw2();



            }
            else
            {
                MessageBox.Show("Not logged in", "Please try again",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MakeWithdraw1()
        {
            decimal withdraw = Convert.ToDecimal(txtWithdraw.Text);
            decimal deposit1 = decAccountBlance1 - withdraw;
            lblAccountBalance.Text = Convert.ToString("Your new blance is" + " " + deposit1);
        }
        private void MakeWithdraw2()
        {
            decimal withdraw = Convert.ToDecimal(txtWithdraw.Text);
            decimal deposit2 = decAccountBlance1 - withdraw;
            lblAccountBalance.Text = Convert.ToString("Your new blance is" + " " + deposit2);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblAccountBalance.Text = "";
            txtAccount.Text = "";
            txtPin.Text = "";
            lblWelcome.Text = "";
            txtDepositBox.Text = "";
            txtWithdraw.Text = "";
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}