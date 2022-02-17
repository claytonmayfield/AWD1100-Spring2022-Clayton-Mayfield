using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH10_lab2
{
    public partial class frmSearchResult : Form
    {
        public frmSearchResult()
        {
            InitializeComponent();
        }
        string job1 = "Web Developer";
        string job2 = "Aerospace engineer";
        string job3 = "junior Chemical Engineering";
        string job4 = "ventilation";
        string job5 = "Automotive designer";
       
        public void outPut()
        {
            
        }
        public void btnExit_Click(object sender, EventArgs e)
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

        public void frmSearchResult_Load(object sender, EventArgs e)
        {
            
        }
    }
}
