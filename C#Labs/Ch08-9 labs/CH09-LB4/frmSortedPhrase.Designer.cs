namespace CH09_LB4
{
    partial class frmSortedPhrase
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
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSort
            // 
            this.lblSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(109, 282);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(350, 23);
            this.lblSort.TabIndex = 2;
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(112, 219);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 49);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(112, 174);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(347, 20);
            this.txtPhrase.TabIndex = 0;
            // 
            // frmSortedPhrase
            // 
            this.AcceptButton = this.btnSort;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblSort);
            this.Name = "frmSortedPhrase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorted phrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtPhrase;
    }
}

