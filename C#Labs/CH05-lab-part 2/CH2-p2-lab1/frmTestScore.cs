using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH2_p2_lab1
{
    public partial class frmTestScore : Form
    {
        public frmTestScore()
        {
            InitializeComponent();
        }

        //const double NUMBERONE = 0.00;
        //const double NUMBERTWO = 0.00;
        //const double NUMBERTHREE = 0.00;
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double hi = Convert.ToDouble(txtEnterScore.Text);
            //string txtEnterScocore = "";

            string lblSumOfScores = "";

            int num1, num2;
            int.TryParse(hi, out num1);
            int.TryParse(hi, out num2);
            {
                string lblSumOfTestScores = (num1 + num2).ToString();
            }
        }

        private void lblTestScore_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
