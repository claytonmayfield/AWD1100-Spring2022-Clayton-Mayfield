namespace CH07_lab2
{
    partial class frmCH07Lab2
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
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblQuanity = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtEstDelivery = new System.Windows.Forms.TextBox();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblItemNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(119, 62);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(183, 23);
            this.lblItemNumber.TabIndex = 5;
            this.lblItemNumber.Text = "Item number [100, 999]";
            this.lblItemNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuanity
            // 
            this.lblQuanity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblQuanity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanity.Location = new System.Drawing.Point(119, 132);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(146, 23);
            this.lblQuanity.TabIndex = 6;
            this.lblQuanity.Text = "Quanity [ 1,12 ]";
            this.lblQuanity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEst
            // 
            this.lblEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEst.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEst.Location = new System.Drawing.Point(119, 205);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(230, 23);
            this.lblEst.TabIndex = 7;
            this.lblEst.Text = "Estimated Delivery Days [ 1,30]";
            this.lblEst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(440, 64);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txtItemNumber.TabIndex = 0;
            // 
            // txtEstDelivery
            // 
            this.txtEstDelivery.Location = new System.Drawing.Point(440, 205);
            this.txtEstDelivery.Name = "txtEstDelivery";
            this.txtEstDelivery.Size = new System.Drawing.Size(100, 20);
            this.txtEstDelivery.TabIndex = 2;
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(440, 132);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(100, 20);
            this.txtQuanity.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnValidate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(440, 264);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(100, 44);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblValid
            // 
            this.lblValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblValid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.Location = new System.Drawing.Point(250, 360);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(173, 23);
            this.lblValid.TabIndex = 4;
            this.lblValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCH07Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtQuanity);
            this.Controls.Add(this.txtEstDelivery);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblQuanity);
            this.Controls.Add(this.lblItemNumber);
            this.Name = "frmCH07Lab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblQuanity;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtEstDelivery;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblValid;
    }
}

