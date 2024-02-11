namespace VendingMachine
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
            this.btnChocolate = new System.Windows.Forms.Button();
            this.btnBuyWater = new System.Windows.Forms.Button();
            this.btnBuuyCrisps = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.lblStockChocolate = new System.Windows.Forms.Label();
            this.lblStockWater = new System.Windows.Forms.Label();
            this.lblStockCrisps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChocolate
            // 
            this.btnChocolate.Location = new System.Drawing.Point(12, 12);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(86, 23);
            this.btnChocolate.TabIndex = 0;
            this.btnChocolate.Text = "Buy Chocolate";
            this.btnChocolate.UseVisualStyleBackColor = true;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click);
            // 
            // btnBuyWater
            // 
            this.btnBuyWater.Location = new System.Drawing.Point(12, 41);
            this.btnBuyWater.Name = "btnBuyWater";
            this.btnBuyWater.Size = new System.Drawing.Size(86, 23);
            this.btnBuyWater.TabIndex = 1;
            this.btnBuyWater.Text = "Buy Water";
            this.btnBuyWater.UseVisualStyleBackColor = true;
            this.btnBuyWater.Click += new System.EventHandler(this.btnBuyWater_Click);
            // 
            // btnBuuyCrisps
            // 
            this.btnBuuyCrisps.Location = new System.Drawing.Point(12, 70);
            this.btnBuuyCrisps.Name = "btnBuuyCrisps";
            this.btnBuuyCrisps.Size = new System.Drawing.Size(86, 23);
            this.btnBuuyCrisps.TabIndex = 2;
            this.btnBuuyCrisps.Text = "Buy Crisps";
            this.btnBuuyCrisps.UseVisualStyleBackColor = true;
            this.btnBuuyCrisps.Click += new System.EventHandler(this.btnBuuyCrisps_Click);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(12, 99);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(86, 23);
            this.btnCheckStock.TabIndex = 3;
            this.btnCheckStock.Text = "Check Stock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // lblStockChocolate
            // 
            this.lblStockChocolate.AutoSize = true;
            this.lblStockChocolate.Location = new System.Drawing.Point(104, 17);
            this.lblStockChocolate.Name = "lblStockChocolate";
            this.lblStockChocolate.Size = new System.Drawing.Size(56, 13);
            this.lblStockChocolate.TabIndex = 4;
            this.lblStockChocolate.Text = "Stock:  10";
            // 
            // lblStockWater
            // 
            this.lblStockWater.AutoSize = true;
            this.lblStockWater.Location = new System.Drawing.Point(104, 46);
            this.lblStockWater.Name = "lblStockWater";
            this.lblStockWater.Size = new System.Drawing.Size(56, 13);
            this.lblStockWater.TabIndex = 5;
            this.lblStockWater.Text = "Stock:  10";
            // 
            // lblStockCrisps
            // 
            this.lblStockCrisps.AutoSize = true;
            this.lblStockCrisps.Location = new System.Drawing.Point(104, 75);
            this.lblStockCrisps.Name = "lblStockCrisps";
            this.lblStockCrisps.Size = new System.Drawing.Size(56, 13);
            this.lblStockCrisps.TabIndex = 6;
            this.lblStockCrisps.Text = "Stock:  10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStockCrisps);
            this.Controls.Add(this.lblStockWater);
            this.Controls.Add(this.lblStockChocolate);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnBuuyCrisps);
            this.Controls.Add(this.btnBuyWater);
            this.Controls.Add(this.btnChocolate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnBuyWater;
        private System.Windows.Forms.Button btnBuuyCrisps;
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.Label lblStockChocolate;
        private System.Windows.Forms.Label lblStockWater;
        private System.Windows.Forms.Label lblStockCrisps;
    }
}

