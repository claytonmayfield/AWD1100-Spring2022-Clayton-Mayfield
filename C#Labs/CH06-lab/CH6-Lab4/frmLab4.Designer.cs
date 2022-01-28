namespace CH6_Lab4
{
    partial class frmLab4
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
            this.btnAdmit = new System.Windows.Forms.Button();
            this.lblGpa = new System.Windows.Forms.Label();
            this.lblAdmissionTestScore = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.txtTestScore = new System.Windows.Forms.TextBox();
            this.lblAccept = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmit
            // 
            this.btnAdmit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmit.Location = new System.Drawing.Point(86, 148);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(107, 59);
            this.btnAdmit.TabIndex = 2;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // lblGpa
            // 
            this.lblGpa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpa.Location = new System.Drawing.Point(83, 33);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(80, 28);
            this.lblGpa.TabIndex = 4;
            this.lblGpa.Text = "GPA";
            this.lblGpa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmissionTestScore
            // 
            this.lblAdmissionTestScore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionTestScore.Location = new System.Drawing.Point(388, 33);
            this.lblAdmissionTestScore.Name = "lblAdmissionTestScore";
            this.lblAdmissionTestScore.Size = new System.Drawing.Size(164, 28);
            this.lblAdmissionTestScore.TabIndex = 5;
            this.lblAdmissionTestScore.Text = "Admission Test Score";
            this.lblAdmissionTestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(86, 64);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(156, 20);
            this.txtGpa.TabIndex = 0;
            // 
            // txtTestScore
            // 
            this.txtTestScore.Location = new System.Drawing.Point(391, 63);
            this.txtTestScore.Name = "txtTestScore";
            this.txtTestScore.Size = new System.Drawing.Size(149, 20);
            this.txtTestScore.TabIndex = 1;
            // 
            // lblAccept
            // 
            this.lblAccept.BackColor = System.Drawing.Color.SlateGray;
            this.lblAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccept.Location = new System.Drawing.Point(215, 168);
            this.lblAccept.Name = "lblAccept";
            this.lblAccept.Size = new System.Drawing.Size(143, 25);
            this.lblAccept.TabIndex = 3;
            this.lblAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLab4
            // 
            this.AcceptButton = this.btnAdmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccept);
            this.Controls.Add(this.txtTestScore);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.lblAdmissionTestScore);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.btnAdmit);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmLab4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Label lblGpa;
        private System.Windows.Forms.Label lblAdmissionTestScore;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.TextBox txtTestScore;
        private System.Windows.Forms.Label lblAccept;
    }
}

