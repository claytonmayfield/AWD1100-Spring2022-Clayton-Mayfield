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
    public partial class Form1 : Form
    {
        string[] industries = { "Information Technology", "Mechanical Engineering", "Chemical Engineering", "HVAC", "AutoMotive" };
        string[] job = { "Web Developer", "Aerospace engineer", "junior Chemical Engineering", "ventilation", "Automotive designer" };
        const int array = 5;
        public Form1()
        {
            InitializeComponent();
        }
        string job1 = "Web Developer";
        string job2 = "Aerospace engineer";
        string job3 = "junior Chemical Engineering";
        string job4 = "ventilation";
        string job5 = "Automotive designer";
        public static string outputStr;
        public void listIndustries_SelectedIndexChanged(object sender, EventArgs e)
        {
            callList();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < industries.Length; ++lcv)
            {
                listIndustries.Items.Add(industries[lcv]);
            }

            callList();
        }
        public void select()
        {
            for (int lcv = 0; lcv < array; ++lcv)
            {
                if (industries[lcv].ToLower().Contains(s) || job[lcv].ToLower()
                  
                {
                    return lcv;
                }
            }



        }
        public void callList()
        {
            
            
            
        }
        public void vaild()
        {
            if (listIndustries.SelectedIndex == -1)
            {
                MessageBox.Show("you must pick a industry",
                                        "No industry choosen");
                return;

            }
        }
    
        public void btnSearch_Click(object sender, EventArgs e)
        {
            vaild(); select();
            frmSearchResult frm2 = new frmSearchResult();
            frm2.Show();
        }
    }

}
