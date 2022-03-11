
namespace LB_Letters
{
    partial class FormLetterDelivery
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
            this.groupBoxLetterInfo = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelAdditionalFee = new System.Windows.Forms.Label();
            this.textBoxTrackingNumber = new System.Windows.Forms.TextBox();
            this.textBoxSentDate = new System.Windows.Forms.TextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.labelTrackingNumber = new System.Windows.Forms.Label();
            this.labelSentDate = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.groupBoxLetterHistory = new System.Windows.Forms.GroupBox();
            this.textBoxLetterHistory = new System.Windows.Forms.TextBox();
            this.groupBoxLetterInfo.SuspendLayout();
            this.groupBoxLetterHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLetterInfo
            // 
            this.groupBoxLetterInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxLetterInfo.Controls.Add(this.buttonExit);
            this.groupBoxLetterInfo.Controls.Add(this.buttonClear);
            this.groupBoxLetterInfo.Controls.Add(this.buttonSend);
            this.groupBoxLetterInfo.Controls.Add(this.labelAdditionalFee);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxTrackingNumber);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxSentDate);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxRecipient);
            this.groupBoxLetterInfo.Controls.Add(this.labelTrackingNumber);
            this.groupBoxLetterInfo.Controls.Add(this.labelSentDate);
            this.groupBoxLetterInfo.Controls.Add(this.labelRecipient);
            this.groupBoxLetterInfo.Location = new System.Drawing.Point(53, 38);
            this.groupBoxLetterInfo.Name = "groupBoxLetterInfo";
            this.groupBoxLetterInfo.Size = new System.Drawing.Size(480, 531);
            this.groupBoxLetterInfo.TabIndex = 0;
            this.groupBoxLetterInfo.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(320, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 58);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(180, 363);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 58);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(43, 363);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(105, 58);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelAdditionalFee
            // 
            this.labelAdditionalFee.AutoSize = true;
            this.labelAdditionalFee.Font = new System.Drawing.Font("Arial Narrow", 18.25F, System.Drawing.FontStyle.Bold);
            this.labelAdditionalFee.Location = new System.Drawing.Point(39, 251);
            this.labelAdditionalFee.Name = "labelAdditionalFee";
            this.labelAdditionalFee.Size = new System.Drawing.Size(372, 30);
            this.labelAdditionalFee.TabIndex = 7;
            this.labelAdditionalFee.Text = "(Additional Fee For Certified Letter)";
            this.labelAdditionalFee.Visible = false;
            // 
            // textBoxTrackingNumber
            // 
            this.textBoxTrackingNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrackingNumber.Location = new System.Drawing.Point(234, 157);
            this.textBoxTrackingNumber.Name = "textBoxTrackingNumber";
            this.textBoxTrackingNumber.Size = new System.Drawing.Size(220, 32);
            this.textBoxTrackingNumber.TabIndex = 2;
            this.textBoxTrackingNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSentDate
            // 
            this.textBoxSentDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentDate.Location = new System.Drawing.Point(234, 96);
            this.textBoxSentDate.Name = "textBoxSentDate";
            this.textBoxSentDate.Size = new System.Drawing.Size(220, 32);
            this.textBoxSentDate.TabIndex = 1;
            this.textBoxSentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecipient.Location = new System.Drawing.Point(234, 36);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(220, 32);
            this.textBoxRecipient.TabIndex = 0;
            this.textBoxRecipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTrackingNumber
            // 
            this.labelTrackingNumber.AutoSize = true;
            this.labelTrackingNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackingNumber.Location = new System.Drawing.Point(40, 157);
            this.labelTrackingNumber.Name = "labelTrackingNumber";
            this.labelTrackingNumber.Size = new System.Drawing.Size(189, 24);
            this.labelTrackingNumber.TabIndex = 6;
            this.labelTrackingNumber.Text = "Tracking Number:";
            // 
            // labelSentDate
            // 
            this.labelSentDate.AutoSize = true;
            this.labelSentDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentDate.Location = new System.Drawing.Point(113, 99);
            this.labelSentDate.Name = "labelSentDate";
            this.labelSentDate.Size = new System.Drawing.Size(115, 24);
            this.labelSentDate.TabIndex = 5;
            this.labelSentDate.Text = "Sent Date:";
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipient.Location = new System.Drawing.Point(117, 39);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(111, 24);
            this.labelRecipient.TabIndex = 4;
            this.labelRecipient.Text = "Recipient:";
            // 
            // groupBoxLetterHistory
            // 
            this.groupBoxLetterHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBoxLetterHistory.Controls.Add(this.textBoxLetterHistory);
            this.groupBoxLetterHistory.Location = new System.Drawing.Point(558, 38);
            this.groupBoxLetterHistory.Name = "groupBoxLetterHistory";
            this.groupBoxLetterHistory.Size = new System.Drawing.Size(480, 531);
            this.groupBoxLetterHistory.TabIndex = 1;
            this.groupBoxLetterHistory.TabStop = false;
            // 
            // textBoxLetterHistory
            // 
            this.textBoxLetterHistory.BackColor = System.Drawing.Color.White;
            this.textBoxLetterHistory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxLetterHistory.Location = new System.Drawing.Point(20, 19);
            this.textBoxLetterHistory.Multiline = true;
            this.textBoxLetterHistory.Name = "textBoxLetterHistory";
            this.textBoxLetterHistory.ReadOnly = true;
            this.textBoxLetterHistory.Size = new System.Drawing.Size(437, 492);
            this.textBoxLetterHistory.TabIndex = 0;
            // 
            // FormLetterDelivery
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(1092, 611);
            this.Controls.Add(this.groupBoxLetterHistory);
            this.Controls.Add(this.groupBoxLetterInfo);
            this.Name = "FormLetterDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Delivery";
            this.Load += new System.EventHandler(this.FormLetterDelivery_Load);
            this.groupBoxLetterInfo.ResumeLayout(false);
            this.groupBoxLetterInfo.PerformLayout();
            this.groupBoxLetterHistory.ResumeLayout(false);
            this.groupBoxLetterHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLetterInfo;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelAdditionalFee;
        private System.Windows.Forms.TextBox textBoxTrackingNumber;
        private System.Windows.Forms.TextBox textBoxSentDate;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.Label labelTrackingNumber;
        private System.Windows.Forms.Label labelSentDate;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.GroupBox groupBoxLetterHistory;
        private System.Windows.Forms.TextBox textBoxLetterHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
    }
}

