using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * 
 *      Create a GUI application for a letter delivery service.
 *      
 *      ●	Letters cost 50 cents to send.
 *      
 *      ●	Certified letter cost an additional 15 cents to send, 
 *          but include a tracking number.
 *          
 *      ●	The user can send up to 10 letters.
 *      
 *      ●	Every time a letter is sent it will be added to the 
 *          top of the transaction log.
 *          
 *      ●	Store the list of sent letters in a single array.
 *      
 *      ●	If the letter does not include a tracking number 
 *          then instantiate a Letter object.
 *          
 *      ●	If the letter includes a tracking number then 
 *          instantiate a CertifiedLetter object.
 * 
 */

namespace LB_Letters
{
    public partial class FormLetterDelivery : Form
    {
        public FormLetterDelivery()
        {
            InitializeComponent();
        }
        //declare and initialize 
        const int MAX = 10;
        // global var
        List<Letter>          letter           = new List<Letter>(MAX);
        List<CertifiedLetter> certifiedLetters = new List<CertifiedLetter>(MAX);
        string[]              sentLetters      = new string[MAX];
        int                   numElements      = 0;
        //  This method runs when the Send button is clicked
        private void buttonSend_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateRecipient();
            if (keepGoing)
            {
                keepGoing = ValidateSentDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                isThereATrackingNumber();
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                instantiateACertfiedLetter();
            }
            else
            {
              instantiateALetter();
            }
        }
        private void instantiateACertfiedLetter()
        {
            CertifiedLetter cl = new CertifiedLetter (textBoxRecipient.Text,Convert.ToDateTime(textBoxSentDate.Text),textBoxTrackingNumber.Text);
            labelTrackingNumber.Visible = true;
            if(numElements < MAX)
            {
                certifiedLetters.Add (cl);
                textBoxLetterHistory.Text += cl.ToString() + "\r\n";
                sentLetters = textBoxLetterHistory.Text.Split('\n');
                ++numElements;
            }
        }
        private void instantiateALetter()
        {
            Letter l = new Letter(textBoxRecipient.Text, Convert.ToDateTime(textBoxSentDate.Text));
            labelTrackingNumber.Visible = true;
            if (numElements < MAX)
            {
                letter.Add (l);
                textBoxLetterHistory.Text += l.ToString() + "\r\n";
                sentLetters = textBoxLetterHistory.Text.Split('\n');
                ++numElements;
            }
        }
        private bool ValidateSentDate()
        {
            bool retVal = true;
            try
            {
                DateTime.Parse(textBoxSentDate.Text.Trim());
            }
            catch (Exception ex)
            {
                showMessage("Invaild date inputted" + "please try again", "invalid Date");
                textBoxSentDate.Text = "";
                textBoxSentDate.Focus();
                retVal = true;
            }
            return retVal;
        }
        private bool isThereATrackingNumber()
        {
            bool retVal = true;
            if (textBoxTrackingNumber.Text.Trim() == "")
            {
                retVal = false;
            }
            return retVal;
        }

        private bool ValidateRecipient()
        {
            bool retVal = true;
            if(textBoxRecipient.Text == "")
            {
                showMessage("Recipient Name Cannot be left blank.\n" + "Please try again", "Blank Recipient");
                textBoxRecipient.Focus();
                retVal = false;
            }
            return true;
        }
        //  This method runs when the Clear button is clicked
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //  This method clears all input fields and sets the focus
        public void clearAll()
        {
            textBoxRecipient.Text = "";
            textBoxSentDate.Text = "";
            textBoxTrackingNumber.Text = "";
            labelAdditionalFee.Text = "";
            textBoxRecipient.Focus();
        }

        //  This method runs when the Exit button is clicked
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitProgramNowOrNot();
        }

        //  This method lets the user exit the program if desired
        private void ExitProgramNowOrNot()
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

        //  This method prints a customized MessageBox
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void FormLetterDelivery_Load(object sender, EventArgs e)
        {
            textBoxLetterHistory.Text = "";
            Letter l1 = new Letter("mom", Convert.ToDateTime("03/07/2022"));
            textBoxLetterHistory.Text += l1 + "\r\n";
            sentLetters[0] = textBoxLetterHistory.Text;
            ++numElements;

            
        }
    }
}
