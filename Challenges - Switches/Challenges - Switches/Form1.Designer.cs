namespace Challenges___Switches
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
            this.btnWinter = new System.Windows.Forms.Button();
            this.btnSummer = new System.Windows.Forms.Button();
            this.btnAutumn = new System.Windows.Forms.Button();
            this.btnSpring = new System.Windows.Forms.Button();
            this.txtEnterDays = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEnterDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWinter
            // 
            this.btnWinter.Location = new System.Drawing.Point(177, 41);
            this.btnWinter.Name = "btnWinter";
            this.btnWinter.Size = new System.Drawing.Size(153, 23);
            this.btnWinter.TabIndex = 0;
            this.btnWinter.Text = "Winter";
            this.btnWinter.UseVisualStyleBackColor = true;
            this.btnWinter.Click += new System.EventHandler(this.btnWinter_Click);
            // 
            // btnSummer
            // 
            this.btnSummer.Location = new System.Drawing.Point(174, 12);
            this.btnSummer.Name = "btnSummer";
            this.btnSummer.Size = new System.Drawing.Size(156, 23);
            this.btnSummer.TabIndex = 1;
            this.btnSummer.Text = "Summer";
            this.btnSummer.UseVisualStyleBackColor = true;
            this.btnSummer.Click += new System.EventHandler(this.btnSummer_Click);
            // 
            // btnAutumn
            // 
            this.btnAutumn.Location = new System.Drawing.Point(12, 41);
            this.btnAutumn.Name = "btnAutumn";
            this.btnAutumn.Size = new System.Drawing.Size(156, 23);
            this.btnAutumn.TabIndex = 2;
            this.btnAutumn.Text = "Autumn";
            this.btnAutumn.UseVisualStyleBackColor = true;
            this.btnAutumn.Click += new System.EventHandler(this.btnAutumn_Click);
            // 
            // btnSpring
            // 
            this.btnSpring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpring.Location = new System.Drawing.Point(12, 12);
            this.btnSpring.Name = "btnSpring";
            this.btnSpring.Size = new System.Drawing.Size(156, 23);
            this.btnSpring.TabIndex = 3;
            this.btnSpring.Text = "Spring";
            this.btnSpring.UseVisualStyleBackColor = true;
            this.btnSpring.Click += new System.EventHandler(this.btnSpring_Click);
            // 
            // txtEnterDays
            // 
            this.txtEnterDays.Location = new System.Drawing.Point(12, 70);
            this.txtEnterDays.Name = "txtEnterDays";
            this.txtEnterDays.Size = new System.Drawing.Size(318, 20);
            this.txtEnterDays.TabIndex = 4;
            this.txtEnterDays.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 96);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(318, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 125);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(318, 20);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnEnterDays
            // 
            this.btnEnterDays.AutoSize = true;
            this.btnEnterDays.Location = new System.Drawing.Point(336, 73);
            this.btnEnterDays.Name = "btnEnterDays";
            this.btnEnterDays.Size = new System.Drawing.Size(59, 13);
            this.btnEnterDays.TabIndex = 7;
            this.btnEnterDays.Text = "Enter Days";
            this.btnEnterDays.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterDays);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterDays);
            this.Controls.Add(this.btnSpring);
            this.Controls.Add(this.btnAutumn);
            this.Controls.Add(this.btnSummer);
            this.Controls.Add(this.btnWinter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWinter;
        private System.Windows.Forms.Button btnSummer;
        private System.Windows.Forms.Button btnAutumn;
        private System.Windows.Forms.Button btnSpring;
        private System.Windows.Forms.TextBox txtEnterDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label btnEnterDays;
    }
}

