namespace _8_2HW
{
    partial class frmListScoreCalculator
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(382, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(382, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(382, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDisplayScores.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayScores.Location = new System.Drawing.Point(252, 273);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayScores.TabIndex = 5;
            this.btnDisplayScores.Text = "Displays Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = false;
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(252, 82);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 0;
            this.txtScore.Tag = "txtScore";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(252, 233);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 3;
            this.txtAverage.Tag = "txtAverage";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(252, 183);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 2;
            this.txtCount.Tag = "txtCount";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(252, 131);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Tag = "txtTotal";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(108, 82);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(96, 19);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScoreTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTotal.Location = new System.Drawing.Point(113, 132);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(91, 20);
            this.lblScoreTotal.TabIndex = 9;
            this.lblScoreTotal.Text = "Score Total";
            this.lblScoreTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblScoreCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.Location = new System.Drawing.Point(113, 184);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(91, 19);
            this.lblScoreCount.TabIndex = 10;
            this.lblScoreCount.Text = "Score Count";
            this.lblScoreCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAverage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(113, 233);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(91, 19);
            this.lblAverage.TabIndex = 11;
            this.lblAverage.Text = "Average";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmListScoreCalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListScoreCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score calculator list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayScores;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
    }
}

