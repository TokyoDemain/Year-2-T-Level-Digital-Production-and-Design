namespace Task2_Code
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PollenProgress = new System.Windows.Forms.ProgressBar();
            this.PollenText1 = new System.Windows.Forms.TextBox();
            this.PollenText2 = new System.Windows.Forms.TextBox();
            this.PollenText4 = new System.Windows.Forms.TextBox();
            this.PollenText3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.PollenText4);
            this.groupBox1.Controls.Add(this.PollenText3);
            this.groupBox1.Controls.Add(this.PollenText2);
            this.groupBox1.Controls.Add(this.PollenText1);
            this.groupBox1.Controls.Add(this.PollenProgress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pollen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PollenProgress
            // 
            this.PollenProgress.Location = new System.Drawing.Point(6, 39);
            this.PollenProgress.Name = "PollenProgress";
            this.PollenProgress.Size = new System.Drawing.Size(188, 23);
            this.PollenProgress.TabIndex = 1;
            // 
            // PollenText1
            // 
            this.PollenText1.Location = new System.Drawing.Point(7, 69);
            this.PollenText1.Name = "PollenText1";
            this.PollenText1.Size = new System.Drawing.Size(187, 20);
            this.PollenText1.TabIndex = 2;
            // 
            // PollenText2
            // 
            this.PollenText2.Location = new System.Drawing.Point(7, 95);
            this.PollenText2.Name = "PollenText2";
            this.PollenText2.Size = new System.Drawing.Size(187, 20);
            this.PollenText2.TabIndex = 3;
            // 
            // PollenText4
            // 
            this.PollenText4.Location = new System.Drawing.Point(7, 147);
            this.PollenText4.Name = "PollenText4";
            this.PollenText4.Size = new System.Drawing.Size(187, 20);
            this.PollenText4.TabIndex = 5;
            // 
            // PollenText3
            // 
            this.PollenText3.Location = new System.Drawing.Point(7, 121);
            this.PollenText3.Name = "PollenText3";
            this.PollenText3.Size = new System.Drawing.Size(187, 20);
            this.PollenText3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 400);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PollenProgress;
        private System.Windows.Forms.TextBox PollenText4;
        private System.Windows.Forms.TextBox PollenText3;
        private System.Windows.Forms.TextBox PollenText2;
        private System.Windows.Forms.TextBox PollenText1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

