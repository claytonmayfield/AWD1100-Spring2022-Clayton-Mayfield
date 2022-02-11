namespace CH08_LB5
{
    partial class frmNightsStayed
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
            this.txtNightsStayed = new System.Windows.Forms.TextBox();
            this.lblNightsStayed = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNightly = new System.Windows.Forms.Label();
            this.lblStayOfCost = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNightsStayed
            // 
            this.txtNightsStayed.Location = new System.Drawing.Point(45, 134);
            this.txtNightsStayed.Name = "txtNightsStayed";
            this.txtNightsStayed.Size = new System.Drawing.Size(109, 20);
            this.txtNightsStayed.TabIndex = 0;
            // 
            // lblNightsStayed
            // 
            this.lblNightsStayed.BackColor = System.Drawing.Color.Yellow;
            this.lblNightsStayed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightsStayed.Location = new System.Drawing.Point(45, 92);
            this.lblNightsStayed.Name = "lblNightsStayed";
            this.lblNightsStayed.Size = new System.Drawing.Size(109, 30);
            this.lblNightsStayed.TabIndex = 4;
            this.lblNightsStayed.Text = "Nights Stayed";
            this.lblNightsStayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(216, 131);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNightly
            // 
            this.lblNightly.BackColor = System.Drawing.Color.Yellow;
            this.lblNightly.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightly.Location = new System.Drawing.Point(393, 97);
            this.lblNightly.Name = "lblNightly";
            this.lblNightly.Size = new System.Drawing.Size(109, 25);
            this.lblNightly.TabIndex = 5;
            this.lblNightly.Text = "Nightly Cost";
            this.lblNightly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStayOfCost
            // 
            this.lblStayOfCost.BackColor = System.Drawing.Color.Yellow;
            this.lblStayOfCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStayOfCost.Location = new System.Drawing.Point(530, 98);
            this.lblStayOfCost.Name = "lblStayOfCost";
            this.lblStayOfCost.Size = new System.Drawing.Size(124, 24);
            this.lblStayOfCost.TabIndex = 6;
            this.lblStayOfCost.Text = "Total cost of stay";
            this.lblStayOfCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.Color.Yellow;
            this.lblCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(393, 134);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(109, 24);
            this.lblCost.TabIndex = 2;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(530, 134);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(124, 24);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNightsStayed
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStayOfCost);
            this.Controls.Add(this.lblNightly);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNightsStayed);
            this.Controls.Add(this.txtNightsStayed);
            this.Name = "frmNightsStayed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Carefree resort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNightsStayed;
        private System.Windows.Forms.Label lblNightsStayed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNightly;
        private System.Windows.Forms.Label lblStayOfCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

