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
    public class Patients
    {
        private readonly PatientsTableAdapter adapter;
        PatientsRow orginalPatientRow;

        public Patients()
        {
            adapter = new PatientsTableAdapter();
        }
        public DataTable Items
        {
            get
            {
                DataTable table = adapter.GetData();
                table.DefaultView.Sort = "PatName";
                return table;
            }
        }
        public int NextPatientID
        {
            get
            {
                var lastPatID = adapter.GetLastPatID();
                const int INCREMENT_VALUE = 1;

                if(lastPatID == 0)
                {
                    return 500;
                }
                else
                {
                    return Convert.ToInt32(lastPatID + INCREMENT_VALUE);
                }
            }
        }
        public PatientsRow FillByID(int PatId)
        {
            var table = adapter.FillByID(PatId);
            return (PatientsRow)table.Rows[0];
        }
        public bool Insert(int PatID,  string PatName, string PatEmail, string PatPhone)
        {
            try
            {
                adapter.Insert(PatID, PatName, PatEmail, PatPhone);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new patient due to: \n\n" +
                    ex.Message, "patient insert failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Update(int PatId, string PatName, string PatEmail, string PatPhone)
        {
            try
            {
                orginalPatientRow = adapter.GetData().FindByPatID(PatId);
                adapter.Update(PatId, PatName, PatEmail, PatPhone,
                   orginalPatientRow.PatID,
                   orginalPatientRow.PatName,
                   orginalPatientRow.PatEmail,
                   orginalPatientRow.PatPhone);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update new patient due to: \n\n" +
                    ex.Message, "patient update failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Delete(int PatId)
        {
            var rowsAffected = 0;
            if(MessageBox.Show("Delete this patient?","DELETE PATIENT", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                orginalPatientRow = adapter.GetData().FindByPatID(PatId);
                if (adapter.PatientHasAppointments(orginalPatientRow.PatID) != null)
                {
                    MessageBox.Show("Cannot delete this patient: " +
                      "as patient has appointments",
                   "CANNOT DELETE PATIENT",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                rowsAffected = adapter.Delete(orginalPatientRow.PatID, orginalPatientRow.PatName, orginalPatientRow.PatEmail, orginalPatientRow.PatPhone);
            }
            return rowsAffected > 0;
        }

    }

}
