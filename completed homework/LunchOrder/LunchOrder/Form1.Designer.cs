namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAddOns = new System.Windows.Forms.GroupBox();
            this.cbFrenchFries = new System.Windows.Forms.CheckBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbLettuce = new System.Windows.Forms.CheckBox();
            this.btnSaletax = new System.Windows.Forms.Button();
            this.gbxMainCourse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAddOns.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rbSalad);
            this.gbxMainCourse.Controls.Add(this.rbPizza);
            this.gbxMainCourse.Controls.Add(this.rbHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(34, 17);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMainCourse.Size = new System.Drawing.Size(159, 98);
            this.gbxMainCourse.TabIndex = 0;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main Course";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(20, 65);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(53, 19);
            this.rbSalad.TabIndex = 2;
            this.rbSalad.Text = "Salad";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.CheckedChanged += new System.EventHandler(this.rbSalad_CheckedChanged);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(20, 40);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(51, 19);
            this.rbPizza.TabIndex = 1;
            this.rbPizza.Text = "Pizza";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.rbPizza_CheckedChanged);
            // 
            // rbHamburger
            // 
            this.rbHamburger.AutoSize = true;
            this.rbHamburger.Checked = true;
            this.rbHamburger.Location = new System.Drawing.Point(20, 19);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(86, 19);
            this.rbHamburger.TabIndex = 0;
            this.rbHamburger.TabStop = true;
            this.rbHamburger.Text = "Hamburger";
            this.rbHamburger.UseVisualStyleBackColor = true;
            this.rbHamburger.CheckedChanged += new System.EventHandler(this.rbHamburger_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSalesTax);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(260, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(112, 76);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(106, 23);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(112, 50);
            this.txtSalesTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(106, 23);
            this.txtSalesTax.TabIndex = 3;
            this.txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(112, 23);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(106, 23);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(299, 149);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(122, 25);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(299, 212);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbAddOns
            // 
            this.gbAddOns.Controls.Add(this.cbFrenchFries);
            this.gbAddOns.Controls.Add(this.cbKetchup);
            this.gbAddOns.Controls.Add(this.cbLettuce);
            this.gbAddOns.Location = new System.Drawing.Point(207, 17);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.Size = new System.Drawing.Size(200, 100);
            this.gbAddOns.TabIndex = 4;
            this.gbAddOns.TabStop = false;
            this.gbAddOns.Text = "Add-on items ($.75/each)";
            // 
            // cbFrenchFries
            // 
            this.cbFrenchFries.AutoSize = true;
            this.cbFrenchFries.Location = new System.Drawing.Point(15, 71);
            this.cbFrenchFries.Name = "cbFrenchFries";
            this.cbFrenchFries.Size = new System.Drawing.Size(89, 19);
            this.cbFrenchFries.TabIndex = 2;
            this.cbFrenchFries.Text = "French Fries";
            this.cbFrenchFries.UseVisualStyleBackColor = true;
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(15, 46);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(179, 19);
            this.cbKetchup.TabIndex = 1;
            this.cbKetchup.Text = "Ketchup, mustard, and mayo";
            this.cbKetchup.UseVisualStyleBackColor = true;
            // 
            // cbLettuce
            // 
            this.cbLettuce.AutoSize = true;
            this.cbLettuce.Location = new System.Drawing.Point(15, 21);
            this.cbLettuce.Name = "cbLettuce";
            this.cbLettuce.Size = new System.Drawing.Size(173, 19);
            this.cbLettuce.TabIndex = 0;
            this.cbLettuce.Text = "lettuce,tomator, and onions";
            this.cbLettuce.UseVisualStyleBackColor = true;
            // 
            // btnSaletax
            // 
            this.btnSaletax.Location = new System.Drawing.Point(299, 179);
            this.btnSaletax.Name = "btnSaletax";
            this.btnSaletax.Size = new System.Drawing.Size(122, 25);
            this.btnSaletax.TabIndex = 5;
            this.btnSaletax.Text = "Change Sales tax";
            this.btnSaletax.UseVisualStyleBackColor = true;
            this.btnSaletax.Click += new System.EventHandler(this.btnSaletax_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.btnSaletax);
            this.Controls.Add(this.gbAddOns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxMainCourse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAddOns.ResumeLayout(false);
            this.gbAddOns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.GroupBox gbAddOns;
        private System.Windows.Forms.CheckBox cbLettuce;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.CheckBox cbFrenchFries;
        private System.Windows.Forms.Button btnSaletax;
    }
}

