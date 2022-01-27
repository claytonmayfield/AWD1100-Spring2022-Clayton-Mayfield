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
            double testScoreOne = Convert.ToDouble(txtScore1.Text);
            double testScoreTwo = Convert.ToDouble(txtScore2.Text);
            double testScoreThree = Convert.ToDouble(txtScore3.Text);
            double totalSum = 0;
            double testAvgRound = 0;
            double[] scores = {testScoreOne,testScoreTwo,testScoreThree};
            foreach (double i in scores)
            {
                if (i >= 0 && i <= 100)
                {
                    totalSum += i;
                    double testAvg = totalSum / 3;
                    testAvgRound = Math.Round((double)testAvg, 2);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show(
                "Invaild input",
                "Retry Again?", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                    txtScore1.Text = "";
                    txtScore2.Text = "";
                    txtScore3.Text = "";
                    txtScore1.Focus();
                }

            }
            double[] SmallestAmount = { testScoreOne, testScoreTwo, testScoreThree};
            foreach (double i in SmallestAmount)
            {
                double SmallestNumber = SmallestAmount.Min();

                lblLowestScore.Text = Convert.ToString("Lowest test score" + " " + SmallestNumber);

            }
            double[] biggestNumber = { testScoreOne, testScoreTwo, testScoreThree };
            foreach (double i in biggestNumber)
            {
                double biggestScore = biggestNumber.Max();

                lblHighestScore.Text = Convert.ToString("Lowest test score" + " " + biggestScore);

            }
            // find the sum and the avgerage 

            lblNumScores.Text = Convert.ToString("Number of scores Entered 3");
            lblSumScores.Text = Convert.ToString("the sum total is" + " " +  totalSum);
            lblAverageScore.Text = String.Format("the average test score is" + " " + testAvgRound);

            


            
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblNumScores.Text = "";
            lblAverageScore.Text = "";
            lblSumScores.Text = "";
            lblLowestScore.Text = "";
            lblHighestScore.Text = "";
            txtScore1.Text = "";
            txtScore2.Text = "";
            txtScore3.Text = "";
            txtScore1.Focus();
        }
    }
}
