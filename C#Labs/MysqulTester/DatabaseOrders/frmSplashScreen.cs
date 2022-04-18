using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOrders
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        Timer T;

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            T = new Timer();

            T.Interval = 5000;

            T.Start();

            T.Tick += new EventHandler(T_Tick);

        }
        private void T_Tick(object Sender, EventArgs e)
        {
            T.Stop();
            Form1 main = new Form1();
            this.Hide();
            main.Show();
        }
    }
}
