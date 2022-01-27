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
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblNumScores = new System.Windows.Forms.Label();
            this.lblSumScores = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblLowestScore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestScore.Location = new System.Drawing.Point(52, 9);
            this.lblTestScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(199, 19);
            this.lblTestScore.TabIndex = 9;
            this.lblTestScore.Text = "Please enter a test score ";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(66, 37);
            this.txtScore1.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(128, 20);
            this.txtScore1.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(66, 109);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 58);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblNumScores
            // 
            this.lblNumScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNumScores.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumScores.Location = new System.Drawing.Point(63, 181);
            this.lblNumScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumScores.Name = "lblNumScores";
            this.lblNumScores.Size = new System.Drawing.Size(337, 19);
            this.lblNumScores.TabIndex = 4;
            this.lblNumScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumScores
            // 
            this.lblSumScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSumScores.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumScores.Location = new System.Drawing.Point(63, 214);
            this.lblSumScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumScores.Name = "lblSumScores";
            this.lblSumScores.Size = new System.Drawing.Size(337, 20);
            this.lblSumScores.TabIndex = 5;
            this.lblSumScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAverageScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageScore.Location = new System.Drawing.Point(63, 245);
            this.lblAverageScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(337, 19);
            this.lblAverageScore.TabIndex = 6;
            this.lblAverageScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestScore
            // 
            this.lblLowestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLowestScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestScore.Location = new System.Drawing.Point(63, 279);
            this.lblLowestScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowestScore.Name = "lblLowestScore";
            this.lblLowestScore.Size = new System.Drawing.Size(337, 19);
            this.lblLowestScore.TabIndex = 7;
            this.lblLowestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHighestScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestScore.Location = new System.Drawing.Point(63, 314);
            this.lblHighestScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(337, 19);
            this.lblHighestScore.TabIndex = 8;
            this.lblHighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(66, 85);
            this.txtScore3.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(128, 20);
            this.txtScore3.TabIndex = 2;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(66, 61);
            this.txtScore2.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(128, 20);
            this.txtScore2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(216, 109);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 58);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(365, 109);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 58);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTestScore
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.lblLowestScore);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblSumScores);
            this.Controls.Add(this.lblNumScores);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblTestScore);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTestScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblNumScores;
        private System.Windows.Forms.Label lblSumScores;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblLowestScore;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

