using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Conferences
{
    public partial class HotelConferences : Form
    {
        public HotelConferences()
        {
            InitializeComponent();
        }
        
        List<Conference> meeting = new List<Conference>(count);
        const int count = 20;
        string[] info = new string[count];
        int numElements = 0;
        static int totCount;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            if (keepGoing)
            {
                 Meet();
            }
            else
            {
                return;
            }

          
        }
        private void Meet()
        {
            Conference cl = new Conference(txtGroupName.Text, Convert.ToDateTime(txtStartingDate.Text), Convert.ToInt32(txtAttendees.Text), txtRoom.Text );
            if (numElements < count)
            {
                meeting.Add(cl);
                txtOutput.Text += cl.ToString() + "\r\n";
                info = txtOutput.Text.Split('\n');
                ++numElements;
                ++totCount;
                lblConferences.Text = "Conferences" + " " + totCount.ToString() + "/20";
                double dog = Convert.ToDouble(txtAttendees.Text);
                
                Clear();
               
            }

        }
        private void Clear()
        {
            txtGroupName.Text = "";
            txtAttendees.Text = "";
            txtStartingDate.Text = "";
            txtRoom.Text = "";
            txtGroupName.Focus();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
