using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_Lab6
{
    public partial class r : Form
    {
        public r()
        {
            InitializeComponent();
        }
        double PAINT = 6;
        double CEILINGHEIGHT = 9;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            CalculateTotalArea();
            CalculatePaintEstimate();
        }
        private void CalculateTotalArea()
        {
          
           
            double Length = Convert.ToDouble(txtLength.Text);
            double Width = Convert.ToDouble(txtWidth.Text);

            double area = Length + Length + Width + Width;
            double area2 = area * CEILINGHEIGHT;
            lblTotalAreaOutPut.Text = Convert.ToString(area2);

            double TotalCost = area2 * PAINT;
            lblTotalCostOutPut.Text = Convert.ToString("$" + TotalCost);
        }
        private void CalculatePaintEstimate()
        {
            double Length = Convert.ToDouble(txtLength.Text);
            double Width = Convert.ToDouble(txtWidth.Text);

            double area = Length + Length + Width + Width;
            double area2 = area * CEILINGHEIGHT;
            lblTotalAreaOutPut.Text = Convert.ToString(area2);

            double TotalCost = area2 * PAINT;
            lblTotalCostOutPut.Text = Convert.ToString("$" + TotalCost);
        }
    }
}
