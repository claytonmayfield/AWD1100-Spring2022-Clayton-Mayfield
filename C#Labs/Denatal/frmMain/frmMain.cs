using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void addNewPatientMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientNew frmPatientNew = new frmPatientNew();
            frmPatientNew.Show();
        }

        private void showAllPatientsMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientsShow frmPatientsShow = new frmPatientsShow();
            frmPatientsShow.Show();
        }

        private void addNewAppointmentMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentNew frmAppointmentNew = new frmAppointmentNew();
            frmAppointmentNew.Show();
        }

        private void showAllAppointmentsMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentsShow frmAppointmentsShow = new frmAppointmentsShow();
            frmAppointmentsShow.Show();
        }
    }
}
