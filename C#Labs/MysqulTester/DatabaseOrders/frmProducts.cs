using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOrders
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        SqlConnection productsConn;
        SqlCommand productsComand;
        SqlDataAdapter productsAdapter;
        DataTable productsTable;
        CurrencyManager productsManger;
        int currentPosition;
        bool dbConnectionEstablished = true;
        bool recordIsValid = true;



        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                var connString = @"Data Source=(LocalDb)\MSSQLocalDB;Initial Catalong=SalesOrders;Integrated Security=SSPI;AttchDBFilename=C:\Users\cpm20\OneDrive\Desktop\AwdRepo\AWD1100-Repo\C#Labs\MysqulTester\DatabaseOrders\SalesOrders.mdf";
                productsConn = new SqlConnection(connString);
                productsConn.Open();
                productsComand = new SqlCommand("SELECT * FROM products ORDER BY poductID", productsConn);
                productsAdapter = new SqlDataAdapter();
                productsTable = new DataTable();
                productsAdapter.SelectCommand = productsComand;
                productsAdapter.Fill(productsTable);
                // bind
                txtProductId.DataBindings.Add("Text", productsTable, "ProductID");
                txtProductName.DataBindings.Add("Text", productsTable, "ProductName");
                pbImage.DataBindings.Add("Text", productsTable, "ProductImage");
                txtProductPrice.DataBindings.Add("Text", productsTable, "ProductPrice");
                txtProductQuantity.DataBindings.Add("Text", productsTable, "ProductQty");
                txtCategory.DataBindings.Add("Text", productsTable, "CategoryID");
                productsManger = (CurrencyManager)BindingContext[productsTable];

                setApplicationState("view");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Database error Occurred:\n\n" + ex.Message, "Database error");
               dbConnectionEstablished=false;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            productsManger.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            productsManger.Position++;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            productsManger.Position = 0;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            productsManger.Position = productsManger.Count - 1;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            setApplicationState("Add");
            try
            {
                currentPosition = productsManger.Position;

                recordIsValid = validateProductName();
                if(!recordIsValid)
                {
                    txtProductName.Focus();
                    throw new Exception("Product name cannot be empty!");
                }
                recordIsValid = validateProductPrice();
                if (!recordIsValid)
                {
                    txtProductPrice.Focus();
                    throw new Exception("Product price cannot be empty!");
                }
                recordIsValid = validateProductQuantity();
                if(!recordIsValid)
                {
                    txtProductQuantity.Focus();
                    throw new Exception("Product quanity cannot be empty!");
                }
                //productsManger.AddNew();
                MessageBox.Show("Record Insert Success \n\n", "Insert Success," +
              MessageBoxButtons.OK);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Record Insert Faile \n\n" + ex.Message, "Insert Failure," +
                   MessageBoxButtons.OK);
            }
        }
        private bool validateProductName()
        {
            bool retVal = true;

            if(txtProductName.Text.Trim() == " ")
            {
                retVal = false;
            }
            return retVal;
        }
        private bool validateProductPrice()
        {
            bool retVal = true;

            if (txtProductPrice.Text.Trim() == " ")
            {
                retVal = false;
            }
            return retVal;
        }
        private bool validateProductQuantity()
        {
            bool retVal = true;

            if (txtProductQuantity.Text.Trim() == " ")
            {
                retVal = false;
            }
            return retVal;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            productsManger.CancelCurrentEdit();
            productsManger.Position = currentPosition;
            setApplicationState("view");
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dbConnectionEstablished)
            {
                productsConn.Close();
                productsConn.Dispose();
                productsComand.Dispose();
                productsAdapter.Dispose();
                productsTable.Dispose();
            }
        }
        private void setApplicationState(string theState)
        {
            txtProductId.ReadOnly = true;
            txtProductId.BackColor = Color.Red;
            txtProductId.ForeColor = Color.White;
            if(theState == "view")
            {
                txtProductName.ReadOnly = true;
                txtProductPrice.ReadOnly = true;
                txtProductQuantity.ReadOnly = true;
                txtCategory.ReadOnly = true;
            }
            else
            {
                txtProductName.ReadOnly = false;
                txtProductPrice.ReadOnly = false;
                txtProductQuantity.ReadOnly = false;
                txtCategory.ReadOnly = false;
            }
            switch(theState)
            {
                case "view":
                    setViewState();
                    break;
                case "Add":
                case "Edit":
                case "Delete":
                    setAddEditDeleteProductState();
                    break;
                case "Save":
                    break;
                case "Cancel":
                    break;
                default:
                    break;
            }
            
        }
        private void setViewState()
        {
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;
            btnAddProduct.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnReturnToMainForm.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void setAddEditDeleteProductState()
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            btnAddProduct.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnReturnToMainForm.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
                lblInvalidPrice.Visible = false;
            }
            else
            {
                e.Handled = true;
                lblInvalidPrice.Visible = true;
            }
        }

        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
                lblInvalidQ.Visible = false;
            }
            else
            {
                e.Handled = true;
                lblInvalidQ.Visible = true;
            }
        }
    }
}
