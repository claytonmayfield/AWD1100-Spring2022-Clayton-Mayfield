namespace CH06_Lab6
{
    partial class r
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblTotalCostOutPut = new System.Windows.Forms.Label();
            this.lblTotalAreaOutPut = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(106, 55);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(114, 22);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length (ft)";
            // 
            // lblTotalCostOutPut
            // 
            this.lblTotalCostOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalCostOutPut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostOutPut.Location = new System.Drawing.Point(644, 87);
            this.lblTotalCostOutPut.Name = "lblTotalCostOutPut";
            this.lblTotalCostOutPut.Size = new System.Drawing.Size(116, 30);
            this.lblTotalCostOutPut.TabIndex = 4;
            this.lblTotalCostOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAreaOutPut
            // 
            this.lblTotalAreaOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalAreaOutPut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAreaOutPut.Location = new System.Drawing.Point(514, 87);
            this.lblTotalAreaOutPut.Name = "lblTotalAreaOutPut";
            this.lblTotalAreaOutPut.Size = new System.Drawing.Size(116, 30);
            this.lblTotalAreaOutPut.TabIndex = 3;
            this.lblTotalAreaOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(646, 55);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(114, 22);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost ($)";
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArea.Location = new System.Drawing.Point(500, 55);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(140, 22);
            this.lblTotalArea.TabIndex = 7;
            this.lblTotalArea.Text = "Total Area (sp ft)";
            // 
            // lblWidth
            // 
            this.lblWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(265, 55);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(114, 22);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width(ft)";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(110, 87);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(259, 87);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(386, 83);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Calculate";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // r
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalAreaOutPut);
            this.Controls.Add(this.lblTotalCostOutPut);
            this.Controls.Add(this.lblLength);
            this.Name = "r";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblTotalCostOutPut;
        private System.Windows.Forms.Label lblTotalAreaOutPut;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnEnter;
    }
}

