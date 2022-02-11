using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT1_9_Promblem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] firstName = { "John", "Mary", "Karen", "Barry", "ken" };
        string[] lastName = { "Doe", "Clemens", "Smith", "Johnson", "Clark" };
        string[] department = { "Accounting", "Programming", "Web", "Programming", "Shipping" };
        int[] salary = { 45000, 55555, 67900, 50000, 7500 };
        const int maxArray = 5;
        string searchTerm = "";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool keepGoing = enterSearch();
            if (keepGoing)
            {
                index = perfromSearch();
            }
            if (index < 0)
            {
                searchTermNotFound();
            }
            else
            {
                searchTermFound(index);
            }
        }
        private bool enterSearch()
        {
            searchTerm = txtSearch.Text;
            bool retVal = true;
            if (searchTerm.Trim() == "")
            {
                retVal = false;
            }
            return retVal;
        }
        private int perfromSearch()
        {
            string s = searchTerm.ToLower();
            for (int lcv = 0; lcv < maxArray; ++lcv)
            {
                if (firstName[lcv].ToLower().Contains(s) || lastName[lcv].ToLower().Contains(s) 
                    || department[lcv].ToLower().Contains(s))
                {
                    return lcv;
                }
            } 
            return -1;
        }
        private void searchTermFound(int lcv)
        {
            lblOutPut.Text = "first name:" + firstName[lcv] + "\n" + " last name:" + lastName[lcv] + "\n" + "Department:" + department[lcv] + "\n" + "salary" + salary[lcv].ToString("c");
        }
        private void searchTermNotFound()
           
        {
            if (searchTerm == "")
            {
                MessageBox.Show("Search term text box can not be empty", "Search Term text box empty",MessageBoxButtons.OK);
            }
            else
            {
                lblOutPut.Text = " No Records Meet your search criteria";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGui();
        }
        private void ClearGui()
        {
            txtSearch.Text = "";
            lblOutPut.Text = "";
            txtSearch.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
          ExitGui();
        }
        private void ExitGui()
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
