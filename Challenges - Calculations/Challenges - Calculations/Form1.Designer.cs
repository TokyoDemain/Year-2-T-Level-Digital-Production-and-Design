namespace Challenges___Calculations
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
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.lblEnterPrice = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(12, 91);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(150, 23);
            this.btnCalculatePrice.TabIndex = 0;
            this.btnCalculatePrice.Text = "Calculate";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Location = new System.Drawing.Point(12, 26);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(150, 20);
            this.txtOriginalPrice.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(12, 65);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(150, 20);
            this.txtDiscountPercent.TabIndex = 2;
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(12, 133);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(150, 20);
            this.txtFinalPrice.TabIndex = 3;
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Location = new System.Drawing.Point(12, 172);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.Size = new System.Drawing.Size(150, 20);
            this.txtTotalDiscount.TabIndex = 4;
            // 
            // lblEnterPrice
            // 
            this.lblEnterPrice.AutoSize = true;
            this.lblEnterPrice.Location = new System.Drawing.Point(9, 10);
            this.lblEnterPrice.Name = "lblEnterPrice";
            this.lblEnterPrice.Size = new System.Drawing.Size(59, 13);
            this.lblEnterPrice.TabIndex = 5;
            this.lblEnterPrice.Text = "Enter Price";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(9, 49);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(117, 13);
            this.lblDiscountPercent.TabIndex = 6;
            this.lblDiscountPercent.Text = "Enter Discount Percent";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(9, 117);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(56, 13);
            this.lblFinalPrice.TabIndex = 7;
            this.lblFinalPrice.Text = "Final Price";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Location = new System.Drawing.Point(9, 156);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(76, 13);
            this.lblTotalDiscount.TabIndex = 8;
            this.lblTotalDiscount.Text = "Total Discount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 203);
            this.Controls.Add(this.lblTotalDiscount);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblEnterPrice);
            this.Controls.Add(this.txtTotalDiscount);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(this.btnCalculatePrice);
            this.Name = "Form1";
            this.Text = "Discount Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.TextBox txtTotalDiscount;
        private System.Windows.Forms.Label lblEnterPrice;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblTotalDiscount;
    }
}

