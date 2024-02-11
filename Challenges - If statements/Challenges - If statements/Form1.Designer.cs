namespace Challenges___If_statements
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
            this.txtItemInput = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblItemInput = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtVanSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtItemInput
            // 
            this.txtItemInput.Location = new System.Drawing.Point(12, 25);
            this.txtItemInput.Name = "txtItemInput";
            this.txtItemInput.Size = new System.Drawing.Size(100, 20);
            this.txtItemInput.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(126, 25);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblItemInput
            // 
            this.lblItemInput.AutoSize = true;
            this.lblItemInput.Location = new System.Drawing.Point(9, 9);
            this.lblItemInput.Name = "lblItemInput";
            this.lblItemInput.Size = new System.Drawing.Size(111, 13);
            this.lblItemInput.TabIndex = 2;
            this.lblItemInput.Text = "Enter Amount of Items";
            this.lblItemInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(126, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(214, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtVanSize
            // 
            this.txtVanSize.Location = new System.Drawing.Point(12, 80);
            this.txtVanSize.Name = "txtVanSize";
            this.txtVanSize.Size = new System.Drawing.Size(214, 20);
            this.txtVanSize.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 111);
            this.Controls.Add(this.txtVanSize);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblItemInput);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtItemInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemInput;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblItemInput;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtVanSize;
    }
}

