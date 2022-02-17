namespace CH10_lab2
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
            this.lblInterested = new System.Windows.Forms.Label();
            this.lblAllApply = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listIndustries = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInterested
            // 
            this.lblInterested.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblInterested.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterested.Location = new System.Drawing.Point(110, 56);
            this.lblInterested.Name = "lblInterested";
            this.lblInterested.Size = new System.Drawing.Size(313, 23);
            this.lblInterested.TabIndex = 2;
            this.lblInterested.Text = "What industries are you interested in?";
            this.lblInterested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllApply
            // 
            this.lblAllApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAllApply.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllApply.Location = new System.Drawing.Point(166, 79);
            this.lblAllApply.Name = "lblAllApply";
            this.lblAllApply.Size = new System.Drawing.Size(190, 23);
            this.lblAllApply.TabIndex = 3;
            this.lblAllApply.Text = "(Select all that apply)";
            this.lblAllApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(220, 255);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listIndustries
            // 
            this.listIndustries.FormattingEnabled = true;
            this.listIndustries.Location = new System.Drawing.Point(201, 121);
            this.listIndustries.Name = "listIndustries";
            this.listIndustries.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listIndustries.Size = new System.Drawing.Size(120, 95);
            this.listIndustries.TabIndex = 0;
            this.listIndustries.SelectedIndexChanged += new System.EventHandler(this.listIndustries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIndustries);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAllApply);
            this.Controls.Add(this.lblInterested);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterested;
        private System.Windows.Forms.Label lblAllApply;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listIndustries;
        private System.Windows.Forms.Label label1;
    }
}

