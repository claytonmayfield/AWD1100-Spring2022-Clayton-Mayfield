namespace CH08_LB8
{
    partial class frmCreditMasker
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
            this.btnMask = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblHidden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMask
            // 
            this.btnMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMask.Location = new System.Drawing.Point(459, 188);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(75, 44);
            this.btnMask.TabIndex = 1;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = false;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(63, 174);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(351, 20);
            this.txtCardNumber.TabIndex = 0;
            // 
            // lblHidden
            // 
            this.lblHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHidden.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHidden.Location = new System.Drawing.Point(60, 224);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(354, 23);
            this.lblHidden.TabIndex = 2;
            this.lblHidden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCreditMasker
            // 
            this.AcceptButton = this.btnMask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.btnMask);
            this.Name = "frmCreditMasker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMask;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblHidden;
    }
}

