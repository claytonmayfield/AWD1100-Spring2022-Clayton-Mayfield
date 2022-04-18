namespace frmMain
{
    partial class frmAppointmentNew
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
            this.lblAppoinntmentDesc = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblScheduledTime = new System.Windows.Forms.Label();
            this.txtAppointmentDesc = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtScheduledTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppoinntmentDesc
            // 
            this.lblAppoinntmentDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAppoinntmentDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppoinntmentDesc.Location = new System.Drawing.Point(110, 65);
            this.lblAppoinntmentDesc.Name = "lblAppoinntmentDesc";
            this.lblAppoinntmentDesc.Size = new System.Drawing.Size(170, 28);
            this.lblAppoinntmentDesc.TabIndex = 5;
            this.lblAppoinntmentDesc.Text = "Apppointment Desc:";
            this.lblAppoinntmentDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientID
            // 
            this.lblPatientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPatientID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(110, 128);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(170, 28);
            this.lblPatientID.TabIndex = 6;
            this.lblPatientID.Text = "Patient ID:";
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduledTime
            // 
            this.lblScheduledTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblScheduledTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledTime.Location = new System.Drawing.Point(110, 193);
            this.lblScheduledTime.Name = "lblScheduledTime";
            this.lblScheduledTime.Size = new System.Drawing.Size(170, 28);
            this.lblScheduledTime.TabIndex = 7;
            this.lblScheduledTime.Text = "Scheduled Time:";
            this.lblScheduledTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAppointmentDesc
            // 
            this.txtAppointmentDesc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentDesc.Location = new System.Drawing.Point(344, 68);
            this.txtAppointmentDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppointmentDesc.Name = "txtAppointmentDesc";
            this.txtAppointmentDesc.Size = new System.Drawing.Size(156, 22);
            this.txtAppointmentDesc.TabIndex = 0;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(344, 132);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(156, 22);
            this.txtPatientID.TabIndex = 1;
            // 
            // txtScheduledTime
            // 
            this.txtScheduledTime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScheduledTime.Location = new System.Drawing.Point(344, 197);
            this.txtScheduledTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScheduledTime.Name = "txtScheduledTime";
            this.txtScheduledTime.Size = new System.Drawing.Size(156, 22);
            this.txtScheduledTime.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(113, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmAppointmentNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtScheduledTime);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtAppointmentDesc);
            this.Controls.Add(this.lblScheduledTime);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblAppoinntmentDesc);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAppointmentNew";
            this.Text = "Create New Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppoinntmentDesc;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblScheduledTime;
        private System.Windows.Forms.TextBox txtAppointmentDesc;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtScheduledTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}