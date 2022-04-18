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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTables.Items.Add("Display products Table");
            lbTables.Items.Add("Display products Table");

        }

        private void btnChooseTable_Click(object sender, EventArgs e)
        {
            chooseCorrectTableToDisplay();
        }
        private void chooseCorrectTableToDisplay()
        {
           switch(lbTables.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("No table Selected", "Nothing Selected ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                    case 0:
                    frmProducts products = new frmProducts();
                    this.Hide();
                    products.Show();
                    break;
                default:
                    return;
            }
        }
    }
}
