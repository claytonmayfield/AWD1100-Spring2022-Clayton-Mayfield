using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH09_LB6
{
    public partial class frmIntegerStats : Form
    {
        public frmIntegerStats()
        {
            InitializeComponent();
        }
        static int numsEnterd;
        double average = 20;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            CalculateStats();
        }
        private void CalculateStats()
        {
            double input = Convert.ToDouble(txtNumber.Text);
            double[] numbers = { input };
            double[] count = { input };
            foreach (double i in numbers)
            {
                double lowestNumber = numbers.Min();

                lblOutPutLowest.Text = Convert.ToString(lowestNumber);
            }
            foreach (double i in numbers)
            {
                double highestNumber = numbers.Max();

                lblOutPutHighest.Text = Convert.ToString(highestNumber);
            }
            // sum of the numbers
            double avg = input / average;
            lblOutPutSum.Text = Convert.ToString(avg);

            // updates the amout of numbers enetered
            ++numsEnterd;
            lblOutPutNumbers.Text = numsEnterd.ToString();

        }   
    }
}
