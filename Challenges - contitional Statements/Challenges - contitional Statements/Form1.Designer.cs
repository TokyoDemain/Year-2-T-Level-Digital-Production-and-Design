namespace Challenges___contitional_Statements
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
            button1 = new Button();
            txtOutput = new TextBox();
            txtEnter = new TextBox();
            lblEnter = new Label();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(163, 23);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 70);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(163, 23);
            txtOutput.TabIndex = 1;
            txtOutput.TextChanged += textBox1_TextChanged;
            // 
            // txtEnter
            // 
            txtEnter.Location = new Point(12, 12);
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(163, 23);
            txtEnter.TabIndex = 2;
            txtEnter.TextChanged += textBox2_TextChanged;
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.Location = new Point(181, 15);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(109, 15);
            lblEnter.TabIndex = 3;
            lblEnter.Text = "Enter Number Here";
            lblEnter.Click += label1_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(187, 76);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(82, 15);
            lblOutput.TabIndex = 4;
            lblOutput.Text = "Output is here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(lblEnter);
            Controls.Add(txtEnter);
            Controls.Add(txtOutput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtOutput;
        private TextBox txtEnter;
        private Label lblEnter;
        private Label lblOutput;
    }
}