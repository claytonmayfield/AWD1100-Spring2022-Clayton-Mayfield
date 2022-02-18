namespace HOT10_11
{
    partial class frmCardStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardStore));
            this.cbOccasion = new System.Windows.Forms.ComboBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.GroupBox();
            this.checkCustom = new System.Windows.Forms.CheckBox();
            this.checkStamp = new System.Windows.Forms.CheckBox();
            this.checkEnvelope = new System.Windows.Forms.CheckBox();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.pbCards = new System.Windows.Forms.PictureBox();
            this.btnSplashScreen = new System.Windows.Forms.Button();
            this.lblCardMessage = new System.Windows.Forms.Label();
            this.lblExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCards)).BeginInit();
            this.SuspendLayout();
            // 
            // cbOccasion
            // 
            this.cbOccasion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOccasion.FormattingEnabled = true;
            this.cbOccasion.Location = new System.Drawing.Point(86, 43);
            this.cbOccasion.Name = "cbOccasion";
            this.cbOccasion.Size = new System.Drawing.Size(193, 21);
            this.cbOccasion.TabIndex = 0;
            this.cbOccasion.SelectedIndexChanged += new System.EventHandler(this.CbOccasion_SelectedIndexChanged);
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(86, 111);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(193, 21);
            this.cbStyle.TabIndex = 1;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.CbStyle_SelectedIndexChanged);
            // 
            // lblOccasion
            // 
            this.lblOccasion.AutoSize = true;
            this.lblOccasion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(15, 43);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(65, 16);
            this.lblOccasion.TabIndex = 7;
            this.lblOccasion.Text = "Occasion";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(25, 111);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(43, 18);
            this.lblStyle.TabIndex = 8;
            this.lblStyle.Text = "Style";
            // 
            // lblExtras
            // 
            this.lblExtras.Controls.Add(this.checkCustom);
            this.lblExtras.Controls.Add(this.checkStamp);
            this.lblExtras.Controls.Add(this.checkEnvelope);
            this.lblExtras.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(28, 156);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(251, 145);
            this.lblExtras.TabIndex = 2;
            this.lblExtras.TabStop = false;
            this.lblExtras.Text = "Extras";
            // 
            // checkCustom
            // 
            this.checkCustom.AutoSize = true;
            this.checkCustom.Location = new System.Drawing.Point(33, 108);
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Size = new System.Drawing.Size(176, 20);
            this.checkCustom.TabIndex = 2;
            this.checkCustom.Text = "Custom Message ($0.30)";
            this.checkCustom.UseVisualStyleBackColor = true;
            this.checkCustom.CheckedChanged += new System.EventHandler(this.CheckCustom_CheckedChanged);
            // 
            // checkStamp
            // 
            this.checkStamp.AutoSize = true;
            this.checkStamp.Location = new System.Drawing.Point(33, 67);
            this.checkStamp.Name = "checkStamp";
            this.checkStamp.Size = new System.Drawing.Size(107, 20);
            this.checkStamp.TabIndex = 1;
            this.checkStamp.Text = "Stamp($0.50)";
            this.checkStamp.UseVisualStyleBackColor = true;
            this.checkStamp.CheckedChanged += new System.EventHandler(this.CheckStamp_CheckedChanged);
            // 
            // checkEnvelope
            // 
            this.checkEnvelope.AutoSize = true;
            this.checkEnvelope.Location = new System.Drawing.Point(33, 32);
            this.checkEnvelope.Name = "checkEnvelope";
            this.checkEnvelope.Size = new System.Drawing.Size(129, 20);
            this.checkEnvelope.TabIndex = 0;
            this.checkEnvelope.Text = "Envelope ($0.25)";
            this.checkEnvelope.UseVisualStyleBackColor = true;
            this.checkEnvelope.CheckedChanged += new System.EventHandler(this.CheckEnvelope_CheckedChanged);
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(28, 308);
            this.txtCustom.Multiline = true;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.ReadOnly = true;
            this.txtCustom.Size = new System.Drawing.Size(251, 85);
            this.txtCustom.TabIndex = 3;
            this.txtCustom.TextChanged += new System.EventHandler(this.TxtCustom_TextChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalCost.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(25, 411);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(251, 30);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbCards
            // 
            this.pbCards.Image = ((System.Drawing.Image)(resources.GetObject("pbCards.Image")));
            this.pbCards.Location = new System.Drawing.Point(398, 12);
            this.pbCards.Name = "pbCards";
            this.pbCards.Size = new System.Drawing.Size(342, 362);
            this.pbCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCards.TabIndex = 7;
            this.pbCards.TabStop = false;
            // 
            // btnSplashScreen
            // 
            this.btnSplashScreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSplashScreen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashScreen.Location = new System.Drawing.Point(488, 387);
            this.btnSplashScreen.Name = "btnSplashScreen";
            this.btnSplashScreen.Size = new System.Drawing.Size(148, 51);
            this.btnSplashScreen.TabIndex = 5;
            this.btnSplashScreen.Text = "Splash screen";
            this.btnSplashScreen.UseVisualStyleBackColor = true;
            this.btnSplashScreen.Click += new System.EventHandler(this.BtnSplashScreen_Click);
            // 
            // lblCardMessage
            // 
            this.lblCardMessage.BackColor = System.Drawing.Color.White;
            this.lblCardMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMessage.Location = new System.Drawing.Point(469, 170);
            this.lblCardMessage.Name = "lblCardMessage";
            this.lblCardMessage.Size = new System.Drawing.Size(183, 23);
            this.lblCardMessage.TabIndex = 10;
            this.lblCardMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCardStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnSplashScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCardMessage);
            this.Controls.Add(this.btnSplashScreen);
            this.Controls.Add(this.pbCards);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.cbOccasion);
            this.Name = "frmCardStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Store";
            this.Load += new System.EventHandler(this.FrmCardStore_Load);
            this.lblExtras.ResumeLayout(false);
            this.lblExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOccasion;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.GroupBox lblExtras;
        private System.Windows.Forms.CheckBox checkCustom;
        private System.Windows.Forms.CheckBox checkStamp;
        private System.Windows.Forms.CheckBox checkEnvelope;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.PictureBox pbCards;
        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Label lblCardMessage;
    }
}