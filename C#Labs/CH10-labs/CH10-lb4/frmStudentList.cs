using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH10_lb4
{
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }
        string[] firstName = { "sam", "sara", "sean", "noah", "wolf" };
        string[] lastName = { "brown", "lee", "baker", "king", "webster" };
        string[] course = { "awd", "automotive", "Carpenter", "autoMotive desgin", "welding" };
        string[] courseGrade = { "A", "b", "A", "C", "d" };
        double[] gpa = { 3.5, 2.5, 3.0, 2.7, 4.0 };
        const int array = 5;
        string searchTerm = "";


        private void btnFirstName_Click(object sender, EventArgs e)
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
            searchTerm = txtFirstName.Text;
            bool retVal = true;
            if (searchTerm.Trim() == "")
            {
                retVal = false;
            }
            return retVal;
        }
        private void searchTermNotFound()

        {
            if (searchTerm == "")
            {
                lblOutPut.Text = "Student Not Found";
            }
            else
            {
                lblOutPut.Text = " No Records Meet your search";
            }
        }
        private void searchTermFound(int lcv)
        {
            lblOutPut.Text = "first name:" + firstName[lcv] + "\n" + " last name:" + lastName[lcv] + "\n" + "Course:" + course[lcv] + "\n" + "Course grade:" + courseGrade[lcv]+ "\n" + "gpa:" + gpa[lcv].ToString();
        }
        private int perfromSearch()
        {
            string s = searchTerm.ToLower();
            for (int lcv = 0; lcv < array; ++lcv)
            {
                if (firstName[lcv].ToLower().Contains(s) || lastName[lcv].ToLower().Contains(s)
                    || course[lcv].ToLower().Contains(s))
                {
                    return lcv;
                }
            }
            return -1;
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool keepGoing = searchTwo();
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
        private bool searchTwo()
        {
            searchTerm = txtLastName.Text;
            bool retVal = true;
            if (searchTerm.Trim() == "")
            {
                retVal = false;
            }
            return retVal;
        }
        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                
                e.Handled = true;

                btnFirstName.PerformClick();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnLastName.PerformClick();
            }
        }
    }
}
