using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH09_LB4
{
    public partial class frmSortedPhrase : Form
    {
        private object line;

        public frmSortedPhrase()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortWords();
        }
        private void SortWords()
        {
            string sort = (txtPhrase.Text);
            string outPut = "";
            List<string> wordsList = new List<string>();
            string[] words = sort.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                outPut += words[i] + " ";
            }
            wordsList.Add(outPut);
            foreach (string s in wordsList)
            {
                lblSort.Text = s;

            }
        }
    }
}
