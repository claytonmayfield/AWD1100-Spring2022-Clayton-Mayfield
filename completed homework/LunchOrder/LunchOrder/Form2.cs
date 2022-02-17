using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        private void vaild()
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double outPutStr = Form1.outPutStr;
            double convert = Convert.ToDouble(outPutStr);
            double newSaleTax = Convert.ToDouble(txtSaleTax.Text);
            double saleTaxChange = newSaleTax * convert;
            double newOrderTotal = saleTaxChange + convert;
            lblOutPut.Text = "The sub total is:" + convert.ToString("c") + "\n" + "The new sales tax is:" + saleTaxChange.ToString("c") + "\n" + "The new order total is:" + newOrderTotal.ToString("c");
                
        }
    }
}
