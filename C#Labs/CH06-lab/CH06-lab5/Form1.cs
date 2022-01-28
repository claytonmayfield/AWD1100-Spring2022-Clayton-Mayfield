using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalVowels = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {

            string vowels = Convert.ToString(txtEnterPhrase.Text);

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == 'a' || vowels[i] == 'e' || vowels[i] == 'i' || vowels[i] == 'o' || vowels[i] == 'u')
                {
                    totalVowels++;
                }
                else if (vowels[i] == 'A' || vowels[i] == 'E' || vowels[i] == 'I' || vowels[i] == 'O' || vowels[i] == 'U')
                {
                    totalVowels++;
                }
            }

            lblVowelOutPut.Text = Convert.ToString("total are" + " " + totalVowels + " " + "vowels in the phrase");

        }
    }
}
