using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT10_11
{
    public partial class frmCardStore : Form
    {
        public frmCardStore()
        {
            InitializeComponent();
        }
        double total = 0;
       
        string[] occasion = { "Birthday($2.50 each)", "Graduation ($3.50 each)", "Sympathy ($1.50 each)", "Thank You ($1.00 each)" };
       
        string[] birthdayCard = { "birthday card 01", "birthday Card 02", "birthday card 03" };
        string[] GraduationCard = { "Graduation card 01", "Graduation Card 02", "Graduation card 03" };
        string[] sympathyCard = { "Sympathy card 01", "Sympathy Card 02", "Sympathy 03" };
        string[] ThankCard = { "Thank You card 01", "Thank You Card 02", "Thank you card 03" };
        
       

        private void BtnSplashScreen_Click(object sender, EventArgs e)
        {
            frmSplashScreen frm1 = new frmSplashScreen();
            frm1.Show();
        }
        

        private void FrmCardStore_Load(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < occasion.Length; ++lcv)
            {
                cbOccasion.Items.Add(occasion[lcv]);

            }
            DropDownList();
        }
       private void ClearExtras()
        {
            checkEnvelope.Checked = false;
            checkCustom.Checked = false;
            checkStamp.Checked = false;
        }

        private void CbOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selct = cbOccasion.SelectedIndex;
            switch (selct)
            {
                case 0:
                    ClearExtras();
                    total = 2.50;
                    lblTotalCost.Text = total.ToString("c");
                    break;
                case 1:
                    ClearExtras();
                    total = 3.50;
                    lblTotalCost.Text = total.ToString("c");
                    break;
                case 2:
                    ClearExtras();
                    total = 1.50;
                    lblTotalCost.Text = total.ToString("c");
                    break;
                case 3:
                    ClearExtras();
                    total = 1.00;
                    lblTotalCost.Text = total.ToString("c");
                    break;
                default:
                    break;

            }
            DropDownList();
        }
        private void DropDownList()
        {
            if(cbOccasion.SelectedIndex == 0)
            {
                cbOccasion.SelectedIndex = cbOccasion.FindStringExact("Birthday($2.50 each)");
                ClearStyle();
                BirthDayCard();
            }
            if (cbOccasion.SelectedIndex == 1)
            {
                cbOccasion.SelectedIndex = cbOccasion.FindStringExact("Graduation ($3.50 each)");
                ClearStyle();
                Graduation();
            }
            if (cbOccasion.SelectedIndex == 2)
            {
                cbOccasion.SelectedIndex = cbOccasion.FindStringExact("Sympathy ($1.50 each)");
                ClearStyle();
                Sympathy();
            } if (cbOccasion.SelectedIndex == 3)
            {
                cbOccasion.SelectedIndex = cbOccasion.FindStringExact("Thank You ($1.00 each)");
                ClearStyle();
                ThankYouCard();
            }

        }
        private void BirthdayI()
        {
            int selct = cbStyle.SelectedIndex;
            switch (selct)
            {
                case 0:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Birthday01.jpg");
                    break;
                case 1:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Birthday02.jpg");
                    break;
                case 2:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Birthday03.jpg");
                    break;
                    default:
                    break;

            }

        }
        private void GraduationI()
        {
            int selct = cbStyle.SelectedIndex;
            switch (selct)
            {
                case 0:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Graduation01.jpg");
                    break;
                case 1:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Graduation02.jpg");
                    break;
                case 2:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Graduation03.jpg");
                    break;
                default:
                    break;
            }
        }
        private void SympathyI()
        {
            int selct = cbStyle.SelectedIndex;
            switch (selct)
            {
                case 0:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Sympathy01.jpg");
                    break;
                case 1:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Sympathy02.jpg");
                    break;
                case 2:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\Sympathy03.jpg");
                    break;
                default:
                    break;
            }
        }
        private void ThankYouI()
        {
            int selct = cbStyle.SelectedIndex;
            switch (selct)
            {
                case 0:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\ThankYou01.jpg");
                    break;
                case 1:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\ThankYou02.jpg");
                    break;
                case 2:
                    pbCards.Image = Image.FromFile("C:\\Users\\cpm20\\OneDrive\\Desktop\\AwdRepo\\AWD1100-Repo\\hands on test\\HOT10-11\\HOT10-11\\NewFolder2\\ThankYou03.jpg");
                    break;
                default:
                    break;
            }
        }
        private void BirthDayCard()
            {  
            for (int lcv = 0; lcv < birthdayCard.Length; ++lcv)
            {
                cbStyle.Items.Add(birthdayCard[lcv]);
           
            }
            

            }
        private void ThankYouCard()
        {
            for (int lcv = 0; lcv < ThankCard.Length; ++lcv)
            {
                cbStyle.Items.Add(ThankCard[lcv]);

            }
        }
        private void Graduation()
        {
            for (int lcv = 0; lcv < GraduationCard.Length; ++lcv)
            {
                cbStyle.Items.Add(GraduationCard[lcv]);

            }
        }
        private void Sympathy()
        {
            for (int lcv = 0; lcv < sympathyCard.Length; ++lcv)
            {
                cbStyle.Items.Add(sympathyCard[lcv]);

            }
        }
        private void ClearStyle()
        {
            cbStyle.Items.Clear();
        }

        private void CbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOccasion.SelectedIndex == 0)
            {
                    BirthdayI();
            }
            if(cbOccasion.SelectedIndex == 1)
                {
                    GraduationI();
                }
            if( cbOccasion.SelectedIndex == 2)
            {
                SympathyI();
            }
            if(cbOccasion.SelectedIndex == 3)
            {
                ThankYouI();
            }
            
        }
        private void CheckEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEnvelope.Checked)
            {
              total += 0.25;
                lblTotalCost.Text = total.ToString("c");
            }
            if(!checkEnvelope.Checked)
            {
                total -= 0.25;
                lblTotalCost.Text = total.ToString("c");
            }
        }
        
       

        private void CheckStamp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStamp.Checked)
            {
                total += 0.50;
                lblTotalCost.Text = total.ToString("c");
            }
            if (!checkStamp.Checked)
            {
                total -= 0.50;
                lblTotalCost.Text = total.ToString("c");
            }
        }
        private void CheckCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustom.Checked)
            {
                txtCustom.ReadOnly = false;
                total += 0.30;
                lblTotalCost.Text = total.ToString("c");
              
            }
            if (!checkCustom.Checked)
            {
                total -= 0.30;
                lblTotalCost.Text = total.ToString("c");
                txtCustom.ReadOnly = true;
                txtCustom.Text = "";
            }
        }

        private void TxtCustom_TextChanged(object sender, EventArgs e)
        {
            lblCardMessage.Text = txtCustom.Text;
        }
    }
}
