
using frmMain.GentleDentalDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain
{
    public class AppointmentType
    {
        private readonly AppointmentTypeTableAdapter adapter;

        public AppointmentType()
        {
            adapter = new AppointmentTypeTableAdapter();

        }
        public DataTable Items {
            get
            {
            DataTable table = adapter.GetData();
            table.DefaultView.Sort = "ATDesription";
            return table;
            }
         }
    }
}
