using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_1
{
    public partial class frmScoreCalculator : Form
    {

        public frmScoreCalculator()
        {
            InitializeComponent();
        }
        //  Global constants
        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        const int NUMSCORES = 10;

        //  Global variables
        int count = 0;
        int[] scores = new int[NUMSCORES];
        string msg = "10 scores";

        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            Array();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result;

            try
            {
                result = IsPresent(txtScore.Text,
                                   txtScore.Tag.ToString());

                if (!result)
                {
                    throw new ArgumentNullException();
                }

                result = IsInteger(txtScore.Text,
                                   txtScore.Tag.ToString());

                if (!result)
                {
                    throw new FormatException();
                }

                result = IsWithinRange(txtScore.Text,
                                       txtScore.Tag.ToString(),
                                       MINSCORE, MAXSCORE);

                if (!result)
                {
                    throw new ArgumentOutOfRangeException();
                }

                int score = Convert.ToInt32(txtScore.Text);

                if (count < NUMSCORES)
                {
                    scores[count] = score;
                    ++count;

                    int total = 0;
                    foreach (int s in scores)
                    {
                        total += s;
                    }

                    decimal average = (decimal)total / (decimal)count;

                    txtScoreTotal.Text = total.ToString();
                    txtCount.Text = count.ToString();
                    txtAvg.Text = average.ToString();

                    txtScore.Focus();
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No Input!",
                                "NO INPUT");
                txtScore.Text = "";
                txtScore.Focus();
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Out Of-Range Input (< 0 or > 100)!",
                                "OUT-OF-RANGE INPUT");
                txtScore.Text = "";
                txtScore.Focus();
            }

            catch (FormatException)
            {
                MessageBox.Show("Non-Numeric Input!",
                                "NON-NUMERIC INPUT");
                txtScore.Text = "";
                txtScore.Focus();
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Too Many Test Scores!\n" +
                                "Ending Program Now.",
                                "TOO MUCH INPUT. BYE");
                Application.Exit();
            }
        }

        private bool IsPresent(string value, string name)
        {
            bool retVal = true;
            msg = "";

            if (value == "")
            {
                msg = name + " is a required field!\n";
                retVal = false;
            }

            return retVal;
        }

        private bool IsInteger(string value, string name)
        {
            bool retVal = true;
            msg = "";

            if (!int.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value!\n";
                retVal = false;
            }

            return retVal;
        }

        private bool IsWithinRange(string value, string name,
                             decimal min, decimal max)
        {
            bool retVal = true;
            msg = "";

            if (Decimal.TryParse(value, out decimal number))
            {
                if ((number < min) || (number > max))
                {
                    msg = name + " must be between " + min +
                           " and " + max + "!\n";
                    retVal = false;
                }
            }

            return retVal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAvg.Text = "";
            txtCount.Text = "";
            txtScore.Text = "";
            txtScoreTotal.Text = "";
        }
        private void Array()
        {
           
                    //MessageBox.Show(s.ToString());
                


            
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
