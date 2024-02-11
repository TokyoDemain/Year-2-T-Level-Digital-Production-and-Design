namespace VendingMachine2
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
            this.btnWater = new System.Windows.Forms.Button();
            this.btnCrisps = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChocolate
            // 
            this.btnChocolate.Location = new System.Drawing.Point(12, 12);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(96, 23);
            this.btnChocolate.TabIndex = 0;
            this.btnChocolate.Text = "Buy Chocolate";
            this.btnChocolate.UseVisualStyleBackColor = true;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click);
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(12, 41);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(96, 23);
            this.btnWater.TabIndex = 1;
            this.btnWater.Text = "Buy Water";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnCrisps
            // 
            this.btnCrisps.Location = new System.Drawing.Point(12, 70);
            this.btnCrisps.Name = "btnCrisps";
            this.btnCrisps.Size = new System.Drawing.Size(96, 23);
            this.btnCrisps.TabIndex = 2;
            this.btnCrisps.Text = "Buy Crisps";
            this.btnCrisps.UseVisualStyleBackColor = true;
            this.btnCrisps.Click += new System.EventHandler(this.btnCrisps_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 128);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(227, 20);
            this.txt.TabIndex = 3;
            this.txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(12, 99);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(96, 23);
            this.btnCheckStock.TabIndex = 4;
            this.btnCheckStock.Text = "CheckStock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 159);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnCrisps);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnChocolate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnCrisps;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnCheckStock;
    }
}

