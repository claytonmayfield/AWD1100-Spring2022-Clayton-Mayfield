namespace Ch18Lab2EmployeeManger
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
            this.lvDisplay = new System.Windows.Forms.ListView();
            this.fn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ln = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.st = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvDisplay
            // 
            this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fn,
            this.ln,
            this.ss,
            this.add,
            this.city,
            this.st,
            this.zp});
            this.lvDisplay.HideSelection = false;
            this.lvDisplay.Location = new System.Drawing.Point(12, 222);
            this.lvDisplay.Name = "lvDisplay";
            this.lvDisplay.Size = new System.Drawing.Size(776, 181);
            this.lvDisplay.TabIndex = 4;
            this.lvDisplay.UseCompatibleStateImageBehavior = false;
            this.lvDisplay.View = System.Windows.Forms.View.Details;
            // 
            // fn
            // 
            this.fn.Text = "first Name";
            this.fn.Width = 109;
            // 
            // ln
            // 
            this.ln.Text = "Last Name";
            this.ln.Width = 113;
            // 
            // ss
            // 
            this.ss.Text = "Soc Sec";
            this.ss.Width = 109;
            // 
            // add
            // 
            this.add.Text = "Address";
            this.add.Width = 122;
            // 
            // city
            // 
            this.city.Text = "city";
            this.city.Width = 109;
            // 
            // st
            // 
            this.st.Text = "State";
            this.st.Width = 113;
            // 
            // zp
            // 
            this.zp.Text = "zip code";
            this.zp.Width = 99;
            // 
            // btnSeach
            // 
            this.btnSeach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(309, 52);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(185, 54);
            this.btnSeach.TabIndex = 1;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(713, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(713, 104);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(162, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(468, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Please hit search to begin your employee search by city";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.lvDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Manger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDisplay;
        private System.Windows.Forms.ColumnHeader fn;
        private System.Windows.Forms.ColumnHeader ln;
        private System.Windows.Forms.ColumnHeader ss;
        private System.Windows.Forms.ColumnHeader add;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader st;
        private System.Windows.Forms.ColumnHeader zp;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSearch;
    }
}

