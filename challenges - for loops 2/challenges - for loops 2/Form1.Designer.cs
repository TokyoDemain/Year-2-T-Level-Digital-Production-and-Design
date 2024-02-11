namespace challenges___for_loops_2
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
            txtEnter = new TextBox();
            btnRun = new Button();
            txtOut = new TextBox();
            lblEnterName = new Label();
            SuspendLayout();
            // 
            // txtEnter
            // 
            txtEnter.Location = new Point(12, 27);
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(196, 23);
            txtEnter.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(12, 56);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(196, 23);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 85);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(196, 353);
            txtOut.TabIndex = 2;
            txtOut.TextChanged += txtOut_TextChanged;
            // 
            // lblEnterName
            // 
            lblEnterName.AutoSize = true;
            lblEnterName.Location = new Point(12, 9);
            lblEnterName.Name = "lblEnterName";
            lblEnterName.Size = new Size(69, 15);
            lblEnterName.TabIndex = 3;
            lblEnterName.Text = "Enter Name";
            lblEnterName.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 450);
            Controls.Add(lblEnterName);
            Controls.Add(txtOut);
            Controls.Add(btnRun);
            Controls.Add(txtEnter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEnter;
        private Button btnRun;
        private TextBox txtOut;
        private Label lblEnterName;
    }
}