﻿using System;
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
    public partial class frmPatientsShow : Form
    {
        public frmPatientsShow()
        {
            InitializeComponent();
        }

        private void frmPatientsShow_Load(object sender, EventArgs e)
        {

        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentEdit frmAppointmentEdit = new frmAppointmentEdit();
            frmAppointmentEdit.Show();
        }
    }
}
