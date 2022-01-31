namespace CH06_Lab9
{
    partial class frmWeylandBank
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblWithDrawal = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDepositBox = new System.Windows.Forms.TextBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(67, 27);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(100, 23);
            this.lblAccount.TabIndex = 9;
            this.lblAccount.Text = "Account #";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPin
            // 
            this.lblPin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(67, 68);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(100, 23);
            this.lblPin.TabIndex = 10;
            this.lblPin.Text = "Pin #";
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(173, 27);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 20);
            this.txtAccount.TabIndex = 0;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(173, 68);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(301, 41);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 31);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcome.Location = new System.Drawing.Point(89, 115);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(302, 23);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAccountBalance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccountBalance.Location = new System.Drawing.Point(89, 163);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(302, 23);
            this.lblAccountBalance.TabIndex = 4;
            this.lblAccountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWithDrawal
            // 
            this.lblWithDrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblWithDrawal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithDrawal.Location = new System.Drawing.Point(66, 308);
            this.lblWithDrawal.Name = "lblWithDrawal";
            this.lblWithDrawal.Size = new System.Drawing.Size(261, 23);
            this.lblWithDrawal.TabIndex = 12;
            this.lblWithDrawal.Text = "Would you like to make a withdrawal?";
            this.lblWithDrawal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeposit
            // 
            this.lblDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDeposit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(67, 223);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(260, 23);
            this.lblDeposit.TabIndex = 11;
            this.lblDeposit.Text = "Would you like to make a deposit?";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepositBox
            // 
            this.txtDepositBox.Location = new System.Drawing.Point(69, 249);
            this.txtDepositBox.Name = "txtDepositBox";
            this.txtDepositBox.Size = new System.Drawing.Size(100, 20);
            this.txtDepositBox.TabIndex = 5;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(67, 334);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(100, 20);
            this.txtWithdraw.TabIndex = 7;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(346, 249);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 38);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(346, 334);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 37);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "WIthdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(198, 368);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 43);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmWeylandBank
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.txtDepositBox);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblWithDrawal);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblAccount);
            this.Name = "frmWeylandBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weyland Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblWithDrawal;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDepositBox;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnLogout;
    }
}

