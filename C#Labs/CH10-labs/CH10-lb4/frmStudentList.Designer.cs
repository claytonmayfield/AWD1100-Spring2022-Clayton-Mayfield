namespace CH10_lb4
{
    partial class frmStudentList
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
            this.lblFristName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnFirstName = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFristName
            // 
            this.lblFristName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFristName.Location = new System.Drawing.Point(159, 93);
            this.lblFristName.Name = "lblFristName";
            this.lblFristName.Size = new System.Drawing.Size(100, 23);
            this.lblFristName.TabIndex = 5;
            this.lblFristName.Text = "Frist Name";
            this.lblFristName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(397, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 35);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(162, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(189, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(400, 128);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(187, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // btnFirstName
            // 
            this.btnFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstName.Location = new System.Drawing.Point(162, 172);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(189, 23);
            this.btnFirstName.TabIndex = 2;
            this.btnFirstName.Text = "Search By First Name";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.btnFirstName_Click);
            // 
            // btnLastName
            // 
            this.btnLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastName.Location = new System.Drawing.Point(400, 172);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(187, 23);
            this.btnLastName.TabIndex = 3;
            this.btnLastName.Text = "Search By Last Name";
            this.btnLastName.UseVisualStyleBackColor = true;
            this.btnLastName.Click += new System.EventHandler(this.btnLastName_Click);
            // 
            // lblOutPut
            // 
            this.lblOutPut.BackColor = System.Drawing.Color.Silver;
            this.lblOutPut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.Location = new System.Drawing.Point(239, 207);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(265, 216);
            this.lblOutPut.TabIndex = 4;
            this.lblOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFristName);
            this.Name = "frmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFristName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnFirstName;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.Label lblOutPut;
    }
}

