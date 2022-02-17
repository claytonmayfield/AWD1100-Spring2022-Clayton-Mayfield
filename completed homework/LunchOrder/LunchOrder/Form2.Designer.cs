namespace LunchOrder
{
    partial class Form2
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
            this.lblChangeSalesTax = new System.Windows.Forms.Label();
            this.txtSaleTax = new System.Windows.Forms.TextBox();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(199, 174);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 72);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(390, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 72);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChangeSalesTax
            // 
            this.lblChangeSalesTax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChangeSalesTax.Location = new System.Drawing.Point(213, 92);
            this.lblChangeSalesTax.Name = "lblChangeSalesTax";
            this.lblChangeSalesTax.Size = new System.Drawing.Size(100, 23);
            this.lblChangeSalesTax.TabIndex = 2;
            this.lblChangeSalesTax.Text = "Sales Tax";
            this.lblChangeSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSaleTax
            // 
            this.txtSaleTax.Location = new System.Drawing.Point(367, 93);
            this.txtSaleTax.Name = "txtSaleTax";
            this.txtSaleTax.Size = new System.Drawing.Size(172, 23);
            this.txtSaleTax.TabIndex = 3;
            // 
            // lblOutPut
            // 
            this.lblOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOutPut.Location = new System.Drawing.Point(239, 266);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(274, 118);
            this.lblOutPut.TabIndex = 4;
            this.lblOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.txtSaleTax);
            this.Controls.Add(this.lblChangeSalesTax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesTax";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChangeSalesTax;
        private System.Windows.Forms.TextBox txtSaleTax;
        private System.Windows.Forms.Label lblOutPut;
    }
}