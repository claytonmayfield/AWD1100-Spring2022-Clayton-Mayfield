namespace LB1_FoodOrder
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
            this.lblWhatName = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblSundae = new System.Windows.Forms.Label();
            this.lblSoda = new System.Windows.Forms.Label();
            this.lblSundaeToppings = new System.Windows.Forms.Label();
            this.lblDrinkMix = new System.Windows.Forms.Label();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cbSundae = new System.Windows.Forms.CheckBox();
            this.cbLime = new System.Windows.Forms.CheckBox();
            this.cbMango = new System.Windows.Forms.CheckBox();
            this.cbPeach = new System.Windows.Forms.CheckBox();
            this.cbSprinkles = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.lblDrinkError = new System.Windows.Forms.Label();
            this.lblErrorSundae = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblorder = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWhatName
            // 
            this.lblWhatName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatName.Location = new System.Drawing.Point(54, 21);
            this.lblWhatName.Name = "lblWhatName";
            this.lblWhatName.Size = new System.Drawing.Size(256, 23);
            this.lblWhatName.TabIndex = 10;
            this.lblWhatName.Text = "What name do you want on the order?";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(57, 47);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(245, 20);
            this.txtOrderName.TabIndex = 0;
            // 
            // lblErrorName
            // 
            this.lblErrorName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(57, 70);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(245, 23);
            this.lblErrorName.TabIndex = 11;
            this.lblErrorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSundae
            // 
            this.lblSundae.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSundae.Location = new System.Drawing.Point(12, 131);
            this.lblSundae.Name = "lblSundae";
            this.lblSundae.Size = new System.Drawing.Size(171, 23);
            this.lblSundae.TabIndex = 12;
            this.lblSundae.Text = "Do you want a sundae?";
            // 
            // lblSoda
            // 
            this.lblSoda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoda.Location = new System.Drawing.Point(201, 131);
            this.lblSoda.Name = "lblSoda";
            this.lblSoda.Size = new System.Drawing.Size(161, 23);
            this.lblSoda.TabIndex = 13;
            this.lblSoda.Text = "Do you want a soda?";
            // 
            // lblSundaeToppings
            // 
            this.lblSundaeToppings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSundaeToppings.Location = new System.Drawing.Point(12, 242);
            this.lblSundaeToppings.Name = "lblSundaeToppings";
            this.lblSundaeToppings.Size = new System.Drawing.Size(126, 23);
            this.lblSundaeToppings.TabIndex = 14;
            this.lblSundaeToppings.Text = "Sundae toppings";
            // 
            // lblDrinkMix
            // 
            this.lblDrinkMix.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkMix.Location = new System.Drawing.Point(226, 242);
            this.lblDrinkMix.Name = "lblDrinkMix";
            this.lblDrinkMix.Size = new System.Drawing.Size(100, 23);
            this.lblDrinkMix.TabIndex = 16;
            this.lblDrinkMix.Text = "Drink Mixin";
            // 
            // cbSoda
            // 
            this.cbSoda.AutoSize = true;
            this.cbSoda.Location = new System.Drawing.Point(229, 158);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(42, 17);
            this.cbSoda.TabIndex = 2;
            this.cbSoda.Text = "yes";
            this.cbSoda.UseVisualStyleBackColor = true;
            this.cbSoda.CheckedChanged += new System.EventHandler(this.cbSoda_CheckedChanged);
            // 
            // cbSundae
            // 
            this.cbSundae.AutoSize = true;
            this.cbSundae.Location = new System.Drawing.Point(26, 158);
            this.cbSundae.Name = "cbSundae";
            this.cbSundae.Size = new System.Drawing.Size(44, 17);
            this.cbSundae.TabIndex = 1;
            this.cbSundae.Text = "Yes";
            this.cbSundae.UseVisualStyleBackColor = true;
            this.cbSundae.CheckedChanged += new System.EventHandler(this.cbSundae_CheckedChanged);
            // 
            // cbLime
            // 
            this.cbLime.AutoSize = true;
            this.cbLime.Location = new System.Drawing.Point(230, 268);
            this.cbLime.Name = "cbLime";
            this.cbLime.Size = new System.Drawing.Size(80, 17);
            this.cbLime.TabIndex = 6;
            this.cbLime.Text = "Lime Flavor";
            this.cbLime.UseVisualStyleBackColor = true;
            this.cbLime.CheckedChanged += new System.EventHandler(this.cbLime_CheckedChanged);
            // 
            // cbMango
            // 
            this.cbMango.AutoSize = true;
            this.cbMango.Location = new System.Drawing.Point(229, 336);
            this.cbMango.Name = "cbMango";
            this.cbMango.Size = new System.Drawing.Size(91, 17);
            this.cbMango.TabIndex = 8;
            this.cbMango.Text = "Mango Flavor";
            this.cbMango.UseVisualStyleBackColor = true;
            // 
            // cbPeach
            // 
            this.cbPeach.AutoSize = true;
            this.cbPeach.Location = new System.Drawing.Point(229, 302);
            this.cbPeach.Name = "cbPeach";
            this.cbPeach.Size = new System.Drawing.Size(89, 17);
            this.cbPeach.TabIndex = 7;
            this.cbPeach.Text = "Peach Flavor";
            this.cbPeach.UseVisualStyleBackColor = true;
            // 
            // cbSprinkles
            // 
            this.cbSprinkles.AutoSize = true;
            this.cbSprinkles.Location = new System.Drawing.Point(15, 269);
            this.cbSprinkles.Name = "cbSprinkles";
            this.cbSprinkles.Size = new System.Drawing.Size(69, 17);
            this.cbSprinkles.TabIndex = 3;
            this.cbSprinkles.Text = "Sprinkles";
            this.cbSprinkles.UseVisualStyleBackColor = true;
            this.cbSprinkles.CheckedChanged += new System.EventHandler(this.cbSprinkles_CheckedChanged);
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(15, 302);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(48, 17);
            this.cbNuts.TabIndex = 4;
            this.cbNuts.Text = "Nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(15, 336);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(103, 17);
            this.cbChocolate.TabIndex = 5;
            this.cbChocolate.Text = "Choclates Syrup";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblDrinkError
            // 
            this.lblDrinkError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkError.ForeColor = System.Drawing.Color.Red;
            this.lblDrinkError.Location = new System.Drawing.Point(220, 363);
            this.lblDrinkError.Name = "lblDrinkError";
            this.lblDrinkError.Size = new System.Drawing.Size(100, 23);
            this.lblDrinkError.TabIndex = 17;
            this.lblDrinkError.Text = "label1";
            this.lblDrinkError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorSundae
            // 
            this.lblErrorSundae.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSundae.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSundae.Location = new System.Drawing.Point(12, 356);
            this.lblErrorSundae.Name = "lblErrorSundae";
            this.lblErrorSundae.Size = new System.Drawing.Size(106, 30);
            this.lblErrorSundae.TabIndex = 15;
            this.lblErrorSundae.Text = "label2";
            this.lblErrorSundae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(12, 415);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(145, 23);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item to order";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblorder
            // 
            this.lblorder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorder.Location = new System.Drawing.Point(688, 44);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(100, 23);
            this.lblorder.TabIndex = 18;
            this.lblorder.Text = "Order";
            this.lblorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Location = new System.Drawing.Point(508, 375);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(108, 47);
            this.lblOrderTotal.TabIndex = 20;
            this.lblOrderTotal.Text = "Total:";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(586, 387);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "label1";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(356, 70);
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(432, 312);
            this.txtTicket.TabIndex = 22;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lblorder);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblErrorSundae);
            this.Controls.Add(this.lblDrinkError);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.cbSprinkles);
            this.Controls.Add(this.cbPeach);
            this.Controls.Add(this.cbMango);
            this.Controls.Add(this.cbLime);
            this.Controls.Add(this.cbSundae);
            this.Controls.Add(this.cbSoda);
            this.Controls.Add(this.lblDrinkMix);
            this.Controls.Add(this.lblSundaeToppings);
            this.Controls.Add(this.lblSoda);
            this.Controls.Add(this.lblSundae);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.txtOrderName);
            this.Controls.Add(this.lblWhatName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhatName;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblSundae;
        private System.Windows.Forms.Label lblSoda;
        private System.Windows.Forms.Label lblSundaeToppings;
        private System.Windows.Forms.Label lblDrinkMix;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cbSundae;
        private System.Windows.Forms.CheckBox cbLime;
        private System.Windows.Forms.CheckBox cbMango;
        private System.Windows.Forms.CheckBox cbPeach;
        private System.Windows.Forms.CheckBox cbSprinkles;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.Label lblDrinkError;
        private System.Windows.Forms.Label lblErrorSundae;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTicket;
    }
}

