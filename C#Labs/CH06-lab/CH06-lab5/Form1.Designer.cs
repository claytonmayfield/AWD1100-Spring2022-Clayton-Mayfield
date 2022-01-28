namespace CH06_lab5
{
    partial class Form1
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
            this.lblPleaseEnterPhase = new System.Windows.Forms.Label();
            this.txtEnterPhrase = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblVowelOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPleaseEnterPhase
            // 
            this.lblPleaseEnterPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPleaseEnterPhase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseEnterPhase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPleaseEnterPhase.Location = new System.Drawing.Point(61, 43);
            this.lblPleaseEnterPhase.Name = "lblPleaseEnterPhase";
            this.lblPleaseEnterPhase.Size = new System.Drawing.Size(191, 24);
            this.lblPleaseEnterPhase.TabIndex = 3;
            this.lblPleaseEnterPhase.Text = "Please enter pharse";
            this.lblPleaseEnterPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnterPhrase
            // 
            this.txtEnterPhrase.Location = new System.Drawing.Point(61, 82);
            this.txtEnterPhrase.Name = "txtEnterPhrase";
            this.txtEnterPhrase.Size = new System.Drawing.Size(191, 20);
            this.txtEnterPhrase.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(341, 78);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(86, 24);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblVowelOutPut
            // 
            this.lblVowelOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVowelOutPut.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVowelOutPut.Location = new System.Drawing.Point(58, 125);
            this.lblVowelOutPut.Name = "lblVowelOutPut";
            this.lblVowelOutPut.Size = new System.Drawing.Size(239, 38);
            this.lblVowelOutPut.TabIndex = 2;
            this.lblVowelOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVowelOutPut);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnterPhrase);
            this.Controls.Add(this.lblPleaseEnterPhase);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseEnterPhase;
        private System.Windows.Forms.TextBox txtEnterPhrase;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblVowelOutPut;
    }
}

