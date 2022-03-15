namespace Bank_Loan
{
    partial class frmBankLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbLongTerm = new System.Windows.Forms.RadioButton();
            this.rbShortTerm = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbMangeLoans = new System.Windows.Forms.GroupBox();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTypeOutPut = new System.Windows.Forms.Label();
            this.lblNameOutPut = new System.Windows.Forms.Label();
            this.gbCreate.SuspendLayout();
            this.gbMangeLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreate
            // 
            this.gbCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbCreate.Controls.Add(this.btnCreate);
            this.gbCreate.Controls.Add(this.rbLongTerm);
            this.gbCreate.Controls.Add(this.rbShortTerm);
            this.gbCreate.Controls.Add(this.txtAmount);
            this.gbCreate.Controls.Add(this.txtName);
            this.gbCreate.Controls.Add(this.lblType);
            this.gbCreate.Controls.Add(this.lblAmount);
            this.gbCreate.Controls.Add(this.lblName);
            this.gbCreate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreate.Location = new System.Drawing.Point(12, 12);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(776, 208);
            this.gbCreate.TabIndex = 0;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Create Loan";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(7, 164);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 34);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Loan";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbLongTerm
            // 
            this.rbLongTerm.AutoSize = true;
            this.rbLongTerm.Location = new System.Drawing.Point(218, 145);
            this.rbLongTerm.Name = "rbLongTerm";
            this.rbLongTerm.Size = new System.Drawing.Size(133, 20);
            this.rbLongTerm.TabIndex = 4;
            this.rbLongTerm.TabStop = true;
            this.rbLongTerm.Text = " Long-Term Loan";
            this.rbLongTerm.UseVisualStyleBackColor = true;
            // 
            // rbShortTerm
            // 
            this.rbShortTerm.AutoSize = true;
            this.rbShortTerm.Location = new System.Drawing.Point(218, 119);
            this.rbShortTerm.Name = "rbShortTerm";
            this.rbShortTerm.Size = new System.Drawing.Size(131, 20);
            this.rbShortTerm.TabIndex = 3;
            this.rbShortTerm.TabStop = true;
            this.rbShortTerm.Text = "Short-Term Loan";
            this.rbShortTerm.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(218, 68);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(267, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 130);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 16);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(17, 68);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 16);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // gbMangeLoans
            // 
            this.gbMangeLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbMangeLoans.Controls.Add(this.lblNameOutPut);
            this.gbMangeLoans.Controls.Add(this.btnMakePayment);
            this.gbMangeLoans.Controls.Add(this.lblInterest);
            this.gbMangeLoans.Controls.Add(this.lblPayment);
            this.gbMangeLoans.Controls.Add(this.lblTypeOutPut);
            this.gbMangeLoans.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMangeLoans.Location = new System.Drawing.Point(12, 241);
            this.gbMangeLoans.Name = "gbMangeLoans";
            this.gbMangeLoans.Size = new System.Drawing.Size(776, 197);
            this.gbMangeLoans.TabIndex = 1;
            this.gbMangeLoans.TabStop = false;
            this.gbMangeLoans.Text = "Manage Loan";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(33, 89);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(121, 34);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblInterest.Location = new System.Drawing.Point(30, 164);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(455, 30);
            this.lblInterest.TabIndex = 4;
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPayment
            // 
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPayment.Location = new System.Drawing.Point(30, 126);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(455, 27);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeOutPut
            // 
            this.lblTypeOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTypeOutPut.Location = new System.Drawing.Point(30, 61);
            this.lblTypeOutPut.Name = "lblTypeOutPut";
            this.lblTypeOutPut.Size = new System.Drawing.Size(455, 25);
            this.lblTypeOutPut.TabIndex = 1;
            this.lblTypeOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameOutPut
            // 
            this.lblNameOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNameOutPut.Location = new System.Drawing.Point(30, 27);
            this.lblNameOutPut.Name = "lblNameOutPut";
            this.lblNameOutPut.Size = new System.Drawing.Size(455, 25);
            this.lblNameOutPut.TabIndex = 0;
            this.lblNameOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBankLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMangeLoans);
            this.Controls.Add(this.gbCreate);
            this.Name = "frmBankLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank loan";
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbMangeLoans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rbLongTerm;
        private System.Windows.Forms.RadioButton rbShortTerm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbMangeLoans;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblTypeOutPut;
        private System.Windows.Forms.Label lblNameOutPut;
    }
}

