namespace Challenges___For_loops
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
            txtEnterName = new TextBox();
            lblEnterName = new Label();
            btnRunCode = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtEnterName
            // 
            txtEnterName.Location = new Point(12, 12);
            txtEnterName.Name = "txtEnterName";
            txtEnterName.Size = new Size(100, 23);
            txtEnterName.TabIndex = 0;
            // 
            // lblEnterName
            // 
            lblEnterName.AutoSize = true;
            lblEnterName.Location = new Point(118, 15);
            lblEnterName.Name = "lblEnterName";
            lblEnterName.Size = new Size(96, 15);
            lblEnterName.TabIndex = 1;
            lblEnterName.Text = "Enter Your Name";
            // 
            // btnRunCode
            // 
            btnRunCode.Location = new Point(12, 41);
            btnRunCode.Name = "btnRunCode";
            btnRunCode.Size = new Size(202, 23);
            btnRunCode.TabIndex = 2;
            btnRunCode.Text = "Run";
            btnRunCode.UseVisualStyleBackColor = true;
            btnRunCode.Click += btnRunCode_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 368);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 450);
            Controls.Add(textBox1);
            Controls.Add(btnRunCode);
            Controls.Add(lblEnterName);
            Controls.Add(txtEnterName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEnterName;
        private Label lblEnterName;
        private Button btnRunCode;
        private TextBox textBox1;
    }
}