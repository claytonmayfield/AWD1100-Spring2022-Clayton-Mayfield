namespace CH10_lab2
{
    partial class frmSearchResult
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
            this.lblJob1 = new System.Windows.Forms.Label();
            this.lblJob2 = new System.Windows.Forms.Label();
            this.lblJob3 = new System.Windows.Forms.Label();
            this.lblJob4 = new System.Windows.Forms.Label();
            this.lblJob5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJob1
            // 
            this.lblJob1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblJob1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob1.Location = new System.Drawing.Point(107, 61);
            this.lblJob1.Name = "lblJob1";
            this.lblJob1.Size = new System.Drawing.Size(636, 26);
            this.lblJob1.TabIndex = 0;
            this.lblJob1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob2
            // 
            this.lblJob2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblJob2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob2.Location = new System.Drawing.Point(107, 128);
            this.lblJob2.Name = "lblJob2";
            this.lblJob2.Size = new System.Drawing.Size(636, 28);
            this.lblJob2.TabIndex = 1;
            this.lblJob2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob3
            // 
            this.lblJob3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblJob3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob3.Location = new System.Drawing.Point(107, 202);
            this.lblJob3.Name = "lblJob3";
            this.lblJob3.Size = new System.Drawing.Size(636, 28);
            this.lblJob3.TabIndex = 2;
            this.lblJob3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob4
            // 
            this.lblJob4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblJob4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob4.Location = new System.Drawing.Point(107, 271);
            this.lblJob4.Name = "lblJob4";
            this.lblJob4.Size = new System.Drawing.Size(636, 28);
            this.lblJob4.TabIndex = 3;
            this.lblJob4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob5
            // 
            this.lblJob5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblJob5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob5.Location = new System.Drawing.Point(107, 342);
            this.lblJob5.Name = "lblJob5";
            this.lblJob5.Size = new System.Drawing.Size(636, 28);
            this.lblJob5.TabIndex = 4;
            this.lblJob5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(372, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblJob5);
            this.Controls.Add(this.lblJob4);
            this.Controls.Add(this.lblJob3);
            this.Controls.Add(this.lblJob2);
            this.Controls.Add(this.lblJob1);
            this.Name = "frmSearchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Reuslt";
            this.Load += new System.EventHandler(this.frmSearchResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJob1;
        private System.Windows.Forms.Label lblJob2;
        private System.Windows.Forms.Label lblJob3;
        private System.Windows.Forms.Label lblJob4;
        private System.Windows.Forms.Label lblJob5;
        private System.Windows.Forms.Button btnExit;
    }
}