namespace HW8_1
{
    partial class frmScoreCalculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(361, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(361, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDisplayScores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayScores.Location = new System.Drawing.Point(195, 269);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayScores.TabIndex = 4;
            this.btnDisplayScores.Text = "Dispalay Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = false;
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(361, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(195, 88);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 0;
            this.txtScore.Tag = "txtScore";
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(195, 219);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 3;
            this.txtAvg.Tag = "txtAverage";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(195, 172);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 2;
            this.txtCount.Tag = "txtScoreCount";
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(195, 128);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.Size = new System.Drawing.Size(100, 20);
            this.txtScoreTotal.TabIndex = 1;
            this.txtScoreTotal.Tag = "txtScoreTotal";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(97, 88);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 20);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvg
            // 
            this.lblAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAvg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(97, 219);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(95, 22);
            this.lblAvg.TabIndex = 11;
            this.lblAvg.Text = "Average";
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(94, 172);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(95, 20);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "Score Count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(94, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Score Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmScoreCalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmScoreCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplayScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotal;
    }
}

