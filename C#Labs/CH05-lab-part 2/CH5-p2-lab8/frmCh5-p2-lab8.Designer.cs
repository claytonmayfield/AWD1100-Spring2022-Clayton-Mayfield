﻿namespace CH5_p2_lab8
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
            this.lblEnterPhrase = new System.Windows.Forms.Label();
            this.txtPhraseEnter = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblVowelsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterPhrase
            // 
            this.lblEnterPhrase.AutoSize = true;
            this.lblEnterPhrase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPhrase.Location = new System.Drawing.Point(67, 41);
            this.lblEnterPhrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterPhrase.Name = "lblEnterPhrase";
            this.lblEnterPhrase.Size = new System.Drawing.Size(167, 19);
            this.lblEnterPhrase.TabIndex = 3;
            this.lblEnterPhrase.Text = "Please enter a phase";
            // 
            // txtPhraseEnter
            // 
            this.txtPhraseEnter.Location = new System.Drawing.Point(70, 75);
            this.txtPhraseEnter.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhraseEnter.Name = "txtPhraseEnter";
            this.txtPhraseEnter.Size = new System.Drawing.Size(153, 20);
            this.txtPhraseEnter.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(227, 75);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(111, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblVowelsOutput
            // 
            this.lblVowelsOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblVowelsOutput.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVowelsOutput.Location = new System.Drawing.Point(70, 118);
            this.lblVowelsOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVowelsOutput.Name = "lblVowelsOutput";
            this.lblVowelsOutput.Size = new System.Drawing.Size(268, 25);
            this.lblVowelsOutput.TabIndex = 2;
            this.lblVowelsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblVowelsOutput);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPhraseEnter);
            this.Controls.Add(this.lblEnterPhrase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterPhrase;
        private System.Windows.Forms.TextBox txtPhraseEnter;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblVowelsOutput;
    }
}

