using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] rooms = new string[count];
        int numElements = 0;
        static int roomCount;
        const int count = 20;
        List<Class1> list = new List<Class1>(count);
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            nameInput();
        }
       
       private void nameInput()
        {
         Class1 nm = new Class1(txtName.Text, Convert.ToInt32(txtWidth.Text),Convert.ToInt32(txtLength.Text));
            if (numElements < count)
            {
                list.Add(nm);
                txtOutPut.Text += nm.ToString() + "\r\n";
                rooms = txtOutPut.Text.Split('\n');
                ++numElements;
                ++roomCount;
                lblRooms.Text = "rooms" + roomCount.ToString() + "/20";
            }
       }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutPut.Text = "";
            Class1 nm = new Class1("dog",(5),(7));
            txtOutPut.Text += nm + "\r\n";
            rooms[0] = txtOutPut.Text;
            ++numElements;
        }
    }
}
