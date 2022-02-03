using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch06_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string msg;
        string error1 = "Associated input is missing for first Name";
        string error2 = "Associated input is missing for Department name";
        string error3 = "Non-numeric input for hours worked";
        string error4 = "Out-Of-Range input fo hourly rate!";
        decimal person1Entery = 0;
        decimal person2Entery = 0;
        int MIN = 0;
        int MAX = 100;
        static int totEmp;
        static decimal grossPay = 0m;
        static decimal avgLow = 0m;
        static decimal avgHigh = 0m;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool result;
            try
            {
                result = IsPresent(txtFristName.Text, txtFristName.Tag.ToString());

                if (!result)
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("system message:" + ane.Message + "\n\nProgrammer Message: " + msg, error1);
            }
            try
            {
                result = IsPresent2(txtDepartment.Text, txtDepartment.Tag.ToString());

                if (!result)
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("system message:" + ane.Message + "\n\nProgrammer Message: " + msg, error2);
            }
            try
            {
                decimal hours = Convert.ToDecimal(txtHoursworked.Text);
            }
            catch (FormatException ane)
            {
                MessageBox.Show("system message:" + ane.Message + "\n\nProgrammer Message: hours worked must be a viald decimal value " + msg, error3);
            }
            try
            {
                result = IsOutOfRange(txtHourlyRate.Text, txtHourlyRate.Tag.ToString(), MIN, MAX);

                if (!result)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ane)
            {
                MessageBox.Show("system message:" + ane.Message + "\n\nProgrammer Message: hourlyrate must be between 0.00 and 99.99 " + msg, error4);
            }
            double hoursWorked = Convert.ToDouble(txtHoursworked.Text);
            double hourRate = Convert.ToDouble(txtHourlyRate.Text);

            double total = hoursWorked * hourRate;
            txtGrossPay.Text = total.ToString("c");

            double[] smallestAmount = {total};
            foreach (double i in smallestAmount)
            {
                double smallestNumber  = smallestAmount.Min();
                txtLowestGross.Text = Convert.ToString(smallestNumber);
            }
            double[] largestAmount = { total };
            foreach (double i in largestAmount)
            {
                double largestNumber = largestAmount.Min();
                txtHighestGross.Text = Convert.ToString(largestNumber);
            }
            updateTotals();



        }
        private void updateTotals()
        {
            ++totEmp;
            txtTotalEmployees.Text = totEmp.ToString();

            if(grossPay < avgLow)
            {
                avgLow = grossPay;
                txtLowestGross.Text = avgLow.ToString("n3");
            }
            if (grossPay > avgHigh)
            {
                avgHigh = grossPay;
                txtHighestGross.Text = avgHigh.ToString("n3");
            }
        }

            private bool IsPresent(string value, string name)
        {
            bool retVal = true;
            msg = "";
            if (value == "")
            {
                msg += name + " is a required field!\n";
                retVal = false;
            }
            return retVal;

        }
        private bool IsPresent2(string value, string name)
        {
            bool retVal = true;
            msg = "";
            if (value == "")
            {
                msg += name + " is a required field!\n";
                retVal = false;
            }
            return retVal;

        }
        private bool IsOutOfRange(String value, String name, decimal MIN, decimal MAX)
        {
            bool retVal = true;
            msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if ((number < MIN) || (number > MAX))
                {
                    msg = name + " must be between " + MIN + " and " + MAX + "!\n";
                    retVal = false;
                }
            }
            return retVal;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGui();
        }
        private void ClearGui()
        {
            txtFristName.Text = "";
            txtLastName.Text = "";
            txtDepartment.Text = "";
            txtHoursworked.Text = "";
            txtHourlyRate.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
