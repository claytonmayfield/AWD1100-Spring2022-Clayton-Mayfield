using frmMain.GentleDentalDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static frmMain.GentleDentalDataSet;

namespace frmMain
{
    public class Appointments
    {
        private readonly AppointmentsTableAdapter adapter;
        private AppointmentsRow orginalAppointmentRow;
        public Appointments()
        {
            adapter = new AppointmentsTableAdapter();
        }
        public DataTable Items => adapter.GetData();
        public DataTable GetByPatientID(int PatID)
        {
            var table = adapter.GetData();
            table.DefaultView.RowFilter = "Patient ID =" + PatID;
            return table;
        }
        public AppointmentsRow FindByApptID(int ApptID)
        {
            var table = adapter.GetData().FindByApptID(ApptID);
            return table;
        }
        public bool Insert(int ApptID, int ATTypeID, string ApptDescription, int PatID, DateTime ApptScheduled)
        {
            try
            {
                adapter.Insert(ApptID, ATTypeID, ApptDescription, PatID, ApptScheduled);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new appointment due to: \n\n" +
                   ex.Message, "Appointment insert failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Update(int ApptID, int ATTypeID, string ApptDescription, int PatID, DateTime ApptScheduled)
        {
            try
            {
                orginalAppointmentRow = adapter.GetData().FindByApptID(ApptID);
                adapter.Update(ApptID, ATTypeID, ApptDescription, PatID, ApptScheduled, orginalAppointmentRow.ApptID,
                    orginalAppointmentRow.ATTypeID, orginalAppointmentRow.ApptDescription, orginalAppointmentRow.PatID,
                    orginalAppointmentRow.ApptScheduled);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to update new appointment due to: \n\n" +
                   ex.Message, "Appointment update failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Delete(int ApptID)
        {
            var affectedRows = 0;
            if(MessageBox.Show("Delete Currently Highlighted Appointment?", "Delete  current Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                orginalAppointmentRow = adapter.GetData().FindByApptID(ApptID);
                affectedRows = adapter.Delete(orginalAppointmentRow.ApptID, orginalAppointmentRow.ATTypeID, orginalAppointmentRow.ApptDescription, orginalAppointmentRow.PatID, orginalAppointmentRow.ApptScheduled);

            }
            return affectedRows > 0;
        }
    }
}
