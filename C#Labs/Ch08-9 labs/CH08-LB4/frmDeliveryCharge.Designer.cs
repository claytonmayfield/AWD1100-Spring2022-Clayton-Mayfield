namespace CH08_LB4
{
    partial class frmDeliveryCharge
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
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblDeliveryfee = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblZipCode
            // 
            this.lblZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblZipCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(117, 130);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(103, 23);
            this.lblZipCode.TabIndex = 3;
            this.lblZipCode.Text = "Zip Code";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelivery
            // 
            this.lblDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDelivery.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(439, 130);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(133, 23);
            this.lblDelivery.TabIndex = 4;
            this.lblDelivery.Text = "Delivery Charge";
            this.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeliveryfee
            // 
            this.lblDeliveryfee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDeliveryfee.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.lblDeliveryfee.Location = new System.Drawing.Point(439, 156);
            this.lblDeliveryfee.Name = "lblDeliveryfee";
            this.lblDeliveryfee.Size = new System.Drawing.Size(133, 24);
            this.lblDeliveryfee.TabIndex = 2;
            this.lblDeliveryfee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(120, 156);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(263, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 25);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmDeliveryCharge
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblDeliveryfee);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblZipCode);
            this.Name = "frmDeliveryCharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblDeliveryfee;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnCalculate;
    }
}

