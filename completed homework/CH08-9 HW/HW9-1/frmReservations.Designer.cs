namespace HW9_1
{
    partial class frmReservations
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtArivalDate = new System.Windows.Forms.TextBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNumberNights = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblNumberNights = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(165, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(277, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtArivalDate
            // 
            this.txtArivalDate.Location = new System.Drawing.Point(197, 54);
            this.txtArivalDate.Name = "txtArivalDate";
            this.txtArivalDate.Size = new System.Drawing.Size(100, 20);
            this.txtArivalDate.TabIndex = 0;
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(197, 228);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAvgPrice.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(197, 182);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // txtNumberNights
            // 
            this.txtNumberNights.Location = new System.Drawing.Point(197, 140);
            this.txtNumberNights.Name = "txtNumberNights";
            this.txtNumberNights.Size = new System.Drawing.Size(100, 20);
            this.txtNumberNights.TabIndex = 2;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(197, 97);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(100, 20);
            this.txtDeparture.TabIndex = 1;
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblArrivalDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(91, 54);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(100, 20);
            this.lblArrivalDate.TabIndex = 7;
            this.lblArrivalDate.Text = "Arrival Date";
            this.lblArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDepartureDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(91, 97);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.lblDepartureDate.TabIndex = 8;
            this.lblDepartureDate.Text = "DepartureDate";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberNights
            // 
            this.lblNumberNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNumberNights.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberNights.Location = new System.Drawing.Point(62, 140);
            this.lblNumberNights.Name = "lblNumberNights";
            this.lblNumberNights.Size = new System.Drawing.Size(129, 20);
            this.lblNumberNights.TabIndex = 9;
            this.lblNumberNights.Text = "Number of Nights";
            this.lblNumberNights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(91, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Price";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvg
            // 
            this.lblAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAvg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(81, 227);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(110, 20);
            this.lblAvg.TabIndex = 11;
            this.lblAvg.Text = "Avg. Price per night";
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReservations
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumberNights);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.txtNumberNights);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAvgPrice);
            this.Controls.Add(this.txtArivalDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmReservations";
            this.Text = "e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtArivalDate;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNumberNights;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblNumberNights;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAvg;
    }
}

