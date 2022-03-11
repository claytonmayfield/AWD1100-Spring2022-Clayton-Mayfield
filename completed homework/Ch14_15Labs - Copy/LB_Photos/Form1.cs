using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 *      Write a GUI application for a photography business.
 *      
 *      ●	8" by 10" photos  are $3.99
 *      
 *      ●	10" by 12" photos are $5.99
 *      
 *      ●	All other sizes   are $9.99
 *      
 *      ●	Customers can add either a Matte or a Frame.
 *      
 *      ●	Matted photos are an additional $10.
 *      
 *      ●	Framed photos are an additional $25.	
 *      
 *      ●	Override the ToString() methods on the Photo,
 *          MattedPhoto, and FramedPhoto classes so they 
 *          display all of the information in the fields.
 * 
 */

namespace LB_Photos
{
    public partial class formPhotoshop : Form
    {
        //  Global constants
        const decimal EIGHTXTEN   =  3.99M;     //   8" x 10" cost
        const decimal TENXTWELVE  =  5.99M;     //  10" x 12" cost
        const decimal OTHERSIZES  =  9.99M;     //  Size other than 8 x 10 or 10 x 12 cost
        const decimal UNFRAMED    =  0.00M;     //  Unframed cost
        const decimal MATTED      = 10.00M;     //  Matted cost
        const decimal FRAMED      = 25.00M;     //  Framed cost

        //  Global variables
        double  width             =  0.00;      //  width  inputted
        double  height            =  0.00;      //  height inputted
        decimal totalCost         =  0.00M;     //  total cost for picture
        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonMaterial;
        RadioButton radioButtonStyle;
        string      frameStr      = "";         //  Unframed, Matted, or Framed
        string      colorStr      = "";         //  Black, Red, Green, Blue,  or White
        string      materialStr   = "";         //  Pine, Oak, Steel, Sivler, or Gold
        string      styleStr      = "";         //  Simple, Modern, Antique, Vintage, or Eclectic

        public formPhotoshop()
        {
            InitializeComponent();
            //  https://social.msdn.microsoft.com/Forums/windows/en-US/c0c36595-9d98-40f7-8e6a-176a5a3af929/how-to-detect-which-radio-button-is-checked-inside-a-groupbox-control?forum=winforms
             // Set up framed groupBox radioButtons
            radioButtonUnframed.CheckedChanged  += new EventHandler(framed_Check_Changed);
            radioButtonMatted.CheckedChanged    += new EventHandler(framed_Check_Changed);
            radioButtonFramed.CheckedChanged    += new EventHandler(framed_Check_Changed);

            ////  Set up color groupBox radioButtons
            radioButtonBlack.CheckedChanged     += new EventHandler(color_Check_Changed);
            radioButtonRed.CheckedChanged       += new EventHandler(color_Check_Changed);
            radioButtonGreen.CheckedChanged     += new EventHandler(color_Check_Changed);
            radioButtonBlue.CheckedChanged      += new EventHandler(color_Check_Changed);
            radioButtonWhite.CheckedChanged     += new EventHandler(color_Check_Changed);

            ////  Set up material groupBox radioButtons
            radioButtonPine.CheckedChanged      += new EventHandler(material_Check_Changed);
            radioButtonOak.CheckedChanged       += new EventHandler(material_Check_Changed);
            radioButtonSteel.CheckedChanged     += new EventHandler(material_Check_Changed);
            radioButtonSilver.CheckedChanged    += new EventHandler(material_Check_Changed);
            radioButtonGold.CheckedChanged      += new EventHandler(material_Check_Changed);

            ////  Set up style groupBox radioButtons
            radioButtonSimple.CheckedChanged    += new EventHandler(style_Check_Changed);
            radioButtonModern.CheckedChanged    += new EventHandler(style_Check_Changed);
            radioButtonAntique.CheckedChanged   += new EventHandler(style_Check_Changed);
            radioButtonVintage.CheckedChanged   += new EventHandler(style_Check_Changed);
            radioButtonEclectic.CheckedChanged  += new EventHandler(style_Check_Changed);
        }
        private void framed_Check_Changed(object sender,EventArgs e)
        {
            radioButtonFrame = (RadioButton)sender;
            int len = frameStr.Length;
            frameStr = radioButtonFrame.Name.Substring(len);
            MessageBox.Show("The current Chosen Radio Button is:" + frameStr, "Chosen Button");
            switch (frameStr)
            {
                case "radUnFramed": // clicked first radio button 
                    groupBoxColor.Enabled = false;
                    groupBoxMaterial.Enabled = false;
                    groupBoxStyle.Enabled = false;
                    break;
                case "radMatted":
                    groupBoxColor.Enabled= true;
                    groupBoxMaterial.Enabled = false;
                    groupBoxStyle.Enabled = false;
                    break;
                case "radFramed":
                    groupBoxColor.Enabled = false;
                    groupBoxMaterial.Enabled = true;
                    groupBoxStyle.Enabled = true;
                    break;
                   default:
                    groupBoxColor.Enabled = false;
                    groupBoxMaterial.Enabled = false;
                    groupBoxStyle.Enabled = false;
                    break;


            }
        }
        private void color_Check_Changed(object sender, EventArgs e)
        {
            if(sender is RadioButton)
            {
                radioButtonColor = (RadioButton)sender;
                int len = colorStr.Length;
                colorStr = radioButtonColor.Name.Substring(len);
            }
        }
        private void material_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonMaterial = (RadioButton)sender;
                int len = materialStr.Length;
                materialStr = radioButtonMaterial.Name.Substring(len);
            }
        }
        private void style_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonStyle = (RadioButton)sender;
                int len = styleStr.Length;
                materialStr = radioButtonMaterial.Name.Substring(len);
            }
        }

            //  This method is called when the calculate button is clicked
            private void buttonCalculate_Click(object sender, EventArgs e)
            {
            bool keepGoing = ValidateWidth();
                if (keepGoing)
                {
                keepGoing = ValidateHeight();
                }
                else
                {
                return;
                }
                if(keepGoing)
                {
                keepGoing = CalcCost();
                }

            }
        private bool ValidateWidth()
        { 
            try
            {
                width = Convert.ToDouble(textBoxWidth.Text);
                if(width <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                writeMessage(fe.Message + "\n\n" + "width Inputted was not numeric\n please try again", "Non-Numeric Width INputted");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                writeMessage(aoore.Message + "\n\n" + "width Inputted was not netagive \n please try again", "netagive Width INputted");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }
        }
       public bool ValidateHeight()
        {
            try
            {
                height = Convert.ToDouble(textBoxHeight.Text);
                if (width <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                writeMessage(fe.Message + "\n\n" + "width Inputted was not numeric\n please try again", "Non-Numeric Width INputted");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                writeMessage(aoore.Message + "\n\n" + "width Inputted was not netagive \n please try again", "netagive Width INputted");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }
        }
        public void CalcCost()
        {
            decimal aeraCost = calcAeraCost();
            decimal frameCost = calcFrameCost();
        }
        private decimal calcAeraCost()
        {
            double area = width * height;
            decimal ac = 0.00m;
            switch (area)
            {
                case 80.0:
                    ac = EIGHTXTEN;
                    break;
                case 120.0:
                    ac = TENXTWELVE;
                    break;
                default:
                    ac = OTHERSIZES;
                    break;
            }
            return ac;
        }
        private decimal calcFrameCost()
        {
            decimal fc = 0.0m;
            switch(radioButtonFramed.Name.Substring(Name.Length - 1))
            {
                case " radUnFramed":
                    fc = UNFRAMED;
                    Photo p = new Photo(width, height);
                    labelTotals.Text = p.ToString();
                    break;
                case "radMatted":
                    fc = MATTED;
                    MattedPhoto.Color colorEnum = (MattedPhoto.Color)Enum.Parse(typeof(MattedPhoto.Color),radioButtonColor.Text.ToUpper());
                    MattedPhoto mp = new MattedPhoto(width,height,colorEnum);
                    labelTotals.Text = mp.ToString();
                    break ;
                case " radFramed":
                    fc = FRAMED;
                    FramedPhoto.Material materialEnum = (FramedPhoto.Material)Enum.Parse(typeof(FramedPhoto.Material), radioButtonMaterial.Text.ToUpper());
                    FramedPhoto fp = new MattedPhoto(width, height, materialEnum);
                    labelTotals.Text = fp.ToString();
                    break;
            }
            return 0;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            width                       = 0.0;
            height                      = 0.0;
            textBoxWidth.Text           = "";
            textBoxHeight.Text          = "";
            radioButtonUnframed.Checked = true;
            radioButtonBlack.Checked    = true;
            radioButtonPine.Checked     = true;
            radioButtonSimple.Checked   = true;
            labelTheCost.Text           = "";
            labelTotals.Text            = "";
            textBoxWidth.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void writeMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
