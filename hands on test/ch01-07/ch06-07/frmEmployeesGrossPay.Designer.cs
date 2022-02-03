namespace ch06_07
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
            this.lblFristName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblGrosspay = new System.Windows.Forms.Label();
            this.lblLowestGross = new System.Windows.Forms.Label();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.lblAverageGross = new System.Windows.Forms.Label();
            this.lblHighestGross = new System.Windows.Forms.Label();
            this.lblTotalGross = new System.Windows.Forms.Label();
            this.txtFristName = new System.Windows.Forms.TextBox();
            this.txtTotalEmployees = new System.Windows.Forms.TextBox();
            this.txtLowestGross = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtHoursworked = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTotalGrossPay = new System.Windows.Forms.TextBox();
            this.txtAverageGross = new System.Windows.Forms.TextBox();
            this.txtHighestGross = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFristName
            // 
            this.lblFristName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFristName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFristName.Location = new System.Drawing.Point(12, 61);
            this.lblFristName.Name = "lblFristName";
            this.lblFristName.Size = new System.Drawing.Size(182, 26);
            this.lblFristName.TabIndex = 14;
            this.lblFristName.Text = "First Name";
            this.lblFristName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 98);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(182, 26);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDepartment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(12, 138);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(182, 26);
            this.lblDepartment.TabIndex = 16;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHoursWorked.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(12, 175);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(182, 26);
            this.lblHoursWorked.TabIndex = 17;
            this.lblHoursWorked.Text = "Hours worked";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHourlyRate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(12, 209);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(182, 26);
            this.lblHourlyRate.TabIndex = 18;
            this.lblHourlyRate.Text = "Hourly rate";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrosspay
            // 
            this.lblGrosspay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGrosspay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosspay.Location = new System.Drawing.Point(12, 244);
            this.lblGrosspay.Name = "lblGrosspay";
            this.lblGrosspay.Size = new System.Drawing.Size(182, 26);
            this.lblGrosspay.TabIndex = 19;
            this.lblGrosspay.Text = "Gross Pay";
            this.lblGrosspay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestGross
            // 
            this.lblLowestGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLowestGross.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestGross.Location = new System.Drawing.Point(396, 98);
            this.lblLowestGross.Name = "lblLowestGross";
            this.lblLowestGross.Size = new System.Drawing.Size(182, 26);
            this.lblLowestGross.TabIndex = 21;
            this.lblLowestGross.Text = "Lowest Gross";
            this.lblLowestGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalEmployees.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.Location = new System.Drawing.Point(396, 61);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(182, 26);
            this.lblTotalEmployees.TabIndex = 20;
            this.lblTotalEmployees.Text = "Total Employees";
            this.lblTotalEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageGross
            // 
            this.lblAverageGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAverageGross.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageGross.Location = new System.Drawing.Point(396, 175);
            this.lblAverageGross.Name = "lblAverageGross";
            this.lblAverageGross.Size = new System.Drawing.Size(182, 26);
            this.lblAverageGross.TabIndex = 23;
            this.lblAverageGross.Text = "Average Gross";
            this.lblAverageGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestGross
            // 
            this.lblHighestGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHighestGross.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestGross.Location = new System.Drawing.Point(396, 138);
            this.lblHighestGross.Name = "lblHighestGross";
            this.lblHighestGross.Size = new System.Drawing.Size(182, 26);
            this.lblHighestGross.TabIndex = 22;
            this.lblHighestGross.Text = "Highest Gross";
            this.lblHighestGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGross
            // 
            this.lblTotalGross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalGross.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGross.Location = new System.Drawing.Point(396, 209);
            this.lblTotalGross.Name = "lblTotalGross";
            this.lblTotalGross.Size = new System.Drawing.Size(182, 26);
            this.lblTotalGross.TabIndex = 24;
            this.lblTotalGross.Text = "Total Gross Pay";
            this.lblTotalGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFristName
            // 
            this.txtFristName.Location = new System.Drawing.Point(245, 66);
            this.txtFristName.Name = "txtFristName";
            this.txtFristName.Size = new System.Drawing.Size(100, 20);
            this.txtFristName.TabIndex = 0;
            this.txtFristName.Tag = "firstName";
            // 
            // txtTotalEmployees
            // 
            this.txtTotalEmployees.Location = new System.Drawing.Point(607, 61);
            this.txtTotalEmployees.Name = "txtTotalEmployees";
            this.txtTotalEmployees.Size = new System.Drawing.Size(100, 20);
            this.txtTotalEmployees.TabIndex = 6;
            // 
            // txtLowestGross
            // 
            this.txtLowestGross.Location = new System.Drawing.Point(607, 104);
            this.txtLowestGross.Name = "txtLowestGross";
            this.txtLowestGross.Size = new System.Drawing.Size(100, 20);
            this.txtLowestGross.TabIndex = 7;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(245, 250);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(100, 20);
            this.txtGrossPay.TabIndex = 5;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(245, 215);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyRate.TabIndex = 4;
            this.txtHourlyRate.Tag = "hourlyRate";
            // 
            // txtHoursworked
            // 
            this.txtHoursworked.Location = new System.Drawing.Point(245, 179);
            this.txtHoursworked.Name = "txtHoursworked";
            this.txtHoursworked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursworked.TabIndex = 3;
            this.txtHoursworked.Tag = "hoursWorked";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(245, 142);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 2;
            this.txtDepartment.Tag = "Department";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(245, 104);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtTotalGrossPay
            // 
            this.txtTotalGrossPay.Location = new System.Drawing.Point(607, 215);
            this.txtTotalGrossPay.Name = "txtTotalGrossPay";
            this.txtTotalGrossPay.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGrossPay.TabIndex = 10;
            // 
            // txtAverageGross
            // 
            this.txtAverageGross.Location = new System.Drawing.Point(607, 181);
            this.txtAverageGross.Name = "txtAverageGross";
            this.txtAverageGross.Size = new System.Drawing.Size(100, 20);
            this.txtAverageGross.TabIndex = 9;
            // 
            // txtHighestGross
            // 
            this.txtHighestGross.Location = new System.Drawing.Point(607, 144);
            this.txtHighestGross.Name = "txtHighestGross";
            this.txtHighestGross.Size = new System.Drawing.Size(100, 20);
            this.txtHighestGross.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(100, 345);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 64);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(323, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 64);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 64);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHighestGross);
            this.Controls.Add(this.txtAverageGross);
            this.Controls.Add(this.txtTotalGrossPay);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtHoursworked);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtLowestGross);
            this.Controls.Add(this.txtTotalEmployees);
            this.Controls.Add(this.txtFristName);
            this.Controls.Add(this.lblTotalGross);
            this.Controls.Add(this.lblHighestGross);
            this.Controls.Add(this.lblAverageGross);
            this.Controls.Add(this.lblTotalEmployees);
            this.Controls.Add(this.lblLowestGross);
            this.Controls.Add(this.lblGrosspay);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFristName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLayton Mayfield AWD1100-Hands On Test #3 Problem #1 Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFristName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblGrosspay;
        private System.Windows.Forms.Label lblLowestGross;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label lblAverageGross;
        private System.Windows.Forms.Label lblHighestGross;
        private System.Windows.Forms.Label lblTotalGross;
        private System.Windows.Forms.TextBox txtFristName;
        private System.Windows.Forms.TextBox txtTotalEmployees;
        private System.Windows.Forms.TextBox txtLowestGross;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtHoursworked;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTotalGrossPay;
        private System.Windows.Forms.TextBox txtAverageGross;
        private System.Windows.Forms.TextBox txtHighestGross;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

