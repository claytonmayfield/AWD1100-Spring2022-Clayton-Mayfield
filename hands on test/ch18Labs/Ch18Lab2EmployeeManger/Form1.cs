using System;
using LINQLibary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Ch18Lab2EmployeeManger
{
    public partial class Form1 : Form
    {
        static List<Employee> workers = Employees.LoadData();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
            searchCity();
        }
        private void searchCity()
        {
            lvDisplay.Items.Clear();
            string city = Interaction.InputBox("Enter a city to search for employee");
            if (city.Trim() == "")
            {
                MessageBox.Show("there was no city inputted");
            }
            else
            {
                var citySearch =
                    from s in workers
                    orderby s.City ascending
                    where s.City.ToUpper().Contains(city.ToUpper())
                    select s;
                foreach (var s in citySearch)
                {
                    ListViewItem item = new ListViewItem(s.FirstName);
                    item.SubItems.Add(s.LastName);
                    item.SubItems.Add(s.SocSecNumber);
                    item.SubItems.Add(s.Address);
                    item.SubItems.Add(s.City);
                    item.SubItems.Add(s.State);
                    item.SubItems.Add(s.ZipCode);
                    lvDisplay.Items.Add(item);

                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
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
            lvDisplay.Items.Clear();
        }
    }
}
