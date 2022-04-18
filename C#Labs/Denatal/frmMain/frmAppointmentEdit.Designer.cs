namespace frmMain
{
    partial class frmAppointmentEdit
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
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblAppointmentDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScheduledTIme = new System.Windows.Forms.Label();
            this.lblTheAppointmentID = new System.Windows.Forms.Label();
            this.txtAppointmentDesc = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtScheduledTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAppointmentID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(84, 43);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(145, 23);
            this.lblAppointmentID.TabIndex = 6;
            this.lblAppointmentID.Text = "Appointment ID:";
            this.lblAppointmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentDesc
            // 
            this.lblAppointmentDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAppointmentDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDesc.Location = new System.Drawing.Point(84, 96);
            this.lblAppointmentDesc.Name = "lblAppointmentDesc";
            this.lblAppointmentDesc.Size = new System.Drawing.Size(145, 23);
            this.lblAppointmentDesc.TabIndex = 7;
            this.lblAppointmentDesc.Text = "Appointment Desc:";
            this.lblAppointmentDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduledTIme
            // 
            this.lblScheduledTIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblScheduledTIme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledTIme.Location = new System.Drawing.Point(84, 197);
            this.lblScheduledTIme.Name = "lblScheduledTIme";
            this.lblScheduledTIme.Size = new System.Drawing.Size(145, 23);
            this.lblScheduledTIme.TabIndex = 9;
            this.lblScheduledTIme.Text = "Scheduled Time:";
            this.lblScheduledTIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTheAppointmentID
            // 
            this.lblTheAppointmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTheAppointmentID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheAppointmentID.Location = new System.Drawing.Point(307, 43);
            this.lblTheAppointmentID.Name = "lblTheAppointmentID";
            this.lblTheAppointmentID.Size = new System.Drawing.Size(145, 23);
            this.lblTheAppointmentID.TabIndex = 5;
            this.lblTheAppointmentID.Text = "Appointment ID:";
            this.lblTheAppointmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAppointmentDesc
            // 
            this.txtAppointmentDesc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentDesc.Location = new System.Drawing.Point(310, 98);
            this.txtAppointmentDesc.Multiline = true;
            this.txtAppointmentDesc.Name = "txtAppointmentDesc";
            this.txtAppointmentDesc.Size = new System.Drawing.Size(142, 21);
            this.txtAppointmentDesc.TabIndex = 0;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(310, 147);
            this.txtPatientID.Multiline = true;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(142, 21);
            this.txtPatientID.TabIndex = 1;
            // 
            // txtScheduledTime
            // 
            this.txtScheduledTime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScheduledTime.Location = new System.Drawing.Point(310, 199);
            this.txtScheduledTime.Multiline = true;
            this.txtScheduledTime.Name = "txtScheduledTime";
            this.txtScheduledTime.Size = new System.Drawing.Size(142, 21);
            this.txtScheduledTime.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(87, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 59);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(347, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 59);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmAppointmentEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtScheduledTime);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtAppointmentDesc);
            this.Controls.Add(this.lblTheAppointmentID);
            this.Controls.Add(this.lblScheduledTIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAppointmentDesc);
            this.Controls.Add(this.lblAppointmentID);
            this.Name = "frmAppointmentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Existing Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblAppointmentDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScheduledTIme;
        private System.Windows.Forms.Label lblTheAppointmentID;
        private System.Windows.Forms.TextBox txtAppointmentDesc;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtScheduledTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}