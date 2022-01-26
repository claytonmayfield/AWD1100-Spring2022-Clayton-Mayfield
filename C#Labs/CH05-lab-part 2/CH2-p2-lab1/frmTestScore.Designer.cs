namespace CH2_p2_lab1
{
    partial class frmTestScore
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
            this.lblTestScore = new System.Windows.Forms.Label();
            this.txtEnterScore = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblNumScores = new System.Windows.Forms.Label();
            this.lblSumScores = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblLowestScore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestScore.Location = new System.Drawing.Point(85, 42);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(251, 24);
            this.lblTestScore.TabIndex = 7;
            this.lblTestScore.Text = "Please enter a test score ";
            // 
            // txtEnterScore
            // 
            this.txtEnterScore.Location = new System.Drawing.Point(84, 78);
            this.txtEnterScore.Name = "txtEnterScore";
            this.txtEnterScore.Size = new System.Drawing.Size(170, 22);
            this.txtEnterScore.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(106, 126);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 72);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblNumScores
            // 
            this.lblNumScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNumScores.Location = new System.Drawing.Point(84, 223);
            this.lblNumScores.Name = "lblNumScores";
            this.lblNumScores.Size = new System.Drawing.Size(204, 23);
            this.lblNumScores.TabIndex = 2;
            // 
            // lblSumScores
            // 
            this.lblSumScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSumScores.Location = new System.Drawing.Point(84, 264);
            this.lblSumScores.Name = "lblSumScores";
            this.lblSumScores.Size = new System.Drawing.Size(204, 24);
            this.lblSumScores.TabIndex = 3;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAverageScore.Location = new System.Drawing.Point(84, 301);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(204, 23);
            this.lblAverageScore.TabIndex = 4;
            // 
            // lblLowestScore
            // 
            this.lblLowestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLowestScore.Location = new System.Drawing.Point(84, 343);
            this.lblLowestScore.Name = "lblLowestScore";
            this.lblLowestScore.Size = new System.Drawing.Size(204, 23);
            this.lblLowestScore.TabIndex = 5;
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHighestScore.Location = new System.Drawing.Point(84, 386);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(204, 23);
            this.lblHighestScore.TabIndex = 6;
            // 
            // frmTestScore
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.lblLowestScore);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblSumScores);
            this.Controls.Add(this.lblNumScores);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnterScore);
            this.Controls.Add(this.lblTestScore);
            this.Name = "frmTestScore";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.TextBox txtEnterScore;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblNumScores;
        private System.Windows.Forms.Label lblSumScores;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblLowestScore;
        private System.Windows.Forms.Label lblHighestScore;
    }
}

