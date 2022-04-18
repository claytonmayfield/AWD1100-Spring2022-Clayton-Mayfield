namespace frmMain
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPatientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAppointmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllAppointmentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsMenu,
            this.appointmentsMenu,
            this.helpMenu,
            this.exitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsMenu
            // 
            this.patientsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientMenu,
            this.showAllPatientsMenu});
            this.patientsMenu.Name = "patientsMenu";
            this.patientsMenu.Size = new System.Drawing.Size(61, 20);
            this.patientsMenu.Text = "Patients";
            // 
            // appointmentsMenu
            // 
            this.appointmentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAppointmentMenu,
            this.showAllAppointmentsMenu});
            this.appointmentsMenu.Name = "appointmentsMenu";
            this.appointmentsMenu.Size = new System.Drawing.Size(95, 20);
            this.appointmentsMenu.Text = "Appointments";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(38, 20);
            this.exitMenu.Text = "Exit";
            // 
            // addNewPatientMenu
            // 
            this.addNewPatientMenu.Name = "addNewPatientMenu";
            this.addNewPatientMenu.Size = new System.Drawing.Size(180, 22);
            this.addNewPatientMenu.Text = "Patients Menu";
            this.addNewPatientMenu.Click += new System.EventHandler(this.addNewPatientMenu_Click);
            // 
            // showAllPatientsMenu
            // 
            this.showAllPatientsMenu.Name = "showAllPatientsMenu";
            this.showAllPatientsMenu.Size = new System.Drawing.Size(180, 22);
            this.showAllPatientsMenu.Text = "Show all patients ";
            this.showAllPatientsMenu.Click += new System.EventHandler(this.showAllPatientsMenu_Click);
            // 
            // addNewAppointmentMenu
            // 
            this.addNewAppointmentMenu.Name = "addNewAppointmentMenu";
            this.addNewAppointmentMenu.Size = new System.Drawing.Size(232, 22);
            this.addNewAppointmentMenu.Text = "add New Appointment  menu";
            this.addNewAppointmentMenu.Click += new System.EventHandler(this.addNewAppointmentMenu_Click);
            // 
            // showAllAppointmentsMenu
            // 
            this.showAllAppointmentsMenu.Name = "showAllAppointmentsMenu";
            this.showAllAppointmentsMenu.Size = new System.Drawing.Size(232, 22);
            this.showAllAppointmentsMenu.Text = "All appointments";
            this.showAllAppointmentsMenu.Click += new System.EventHandler(this.showAllAppointmentsMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(121, 55);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(552, 360);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientMenu;
        private System.Windows.Forms.ToolStripMenuItem showAllPatientsMenu;
        private System.Windows.Forms.ToolStripMenuItem appointmentsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewAppointmentMenu;
        private System.Windows.Forms.ToolStripMenuItem showAllAppointmentsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

