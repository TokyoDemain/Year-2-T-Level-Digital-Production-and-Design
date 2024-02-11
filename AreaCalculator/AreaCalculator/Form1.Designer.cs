namespace AreaCalculator
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
            this.txtRoomLengthInput = new System.Windows.Forms.TextBox();
            this.txtRoomWidthInput = new System.Windows.Forms.TextBox();
            this.btnCalculateRoomArea = new System.Windows.Forms.Button();
            this.lblRoomLength = new System.Windows.Forms.Label();
            this.lblRoomWidth = new System.Windows.Forms.Label();
            this.txtRoomAreaOutput = new System.Windows.Forms.TextBox();
            this.lblRoomArea = new System.Windows.Forms.Label();
            this.txtRoomHeightInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateRoomVolume = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomVolumeOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRoomLengthInput
            // 
            this.txtRoomLengthInput.Location = new System.Drawing.Point(12, 21);
            this.txtRoomLengthInput.Name = "txtRoomLengthInput";
            this.txtRoomLengthInput.Size = new System.Drawing.Size(344, 20);
            this.txtRoomLengthInput.TabIndex = 0;
            this.txtRoomLengthInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRoomWidthInput
            // 
            this.txtRoomWidthInput.Location = new System.Drawing.Point(12, 61);
            this.txtRoomWidthInput.Name = "txtRoomWidthInput";
            this.txtRoomWidthInput.Size = new System.Drawing.Size(344, 20);
            this.txtRoomWidthInput.TabIndex = 1;
            // 
            // btnCalculateRoomArea
            // 
            this.btnCalculateRoomArea.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRoomArea.Location = new System.Drawing.Point(12, 126);
            this.btnCalculateRoomArea.Name = "btnCalculateRoomArea";
            this.btnCalculateRoomArea.Size = new System.Drawing.Size(344, 23);
            this.btnCalculateRoomArea.TabIndex = 2;
            this.btnCalculateRoomArea.Text = "Calculate Room Area";
            this.btnCalculateRoomArea.UseVisualStyleBackColor = true;
            this.btnCalculateRoomArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRoomLength
            // 
            this.lblRoomLength.AutoSize = true;
            this.lblRoomLength.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomLength.Location = new System.Drawing.Point(9, 3);
            this.lblRoomLength.Name = "lblRoomLength";
            this.lblRoomLength.Size = new System.Drawing.Size(71, 15);
            this.lblRoomLength.TabIndex = 3;
            this.lblRoomLength.Text = "Room Length";
            this.lblRoomLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRoomWidth
            // 
            this.lblRoomWidth.AutoSize = true;
            this.lblRoomWidth.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomWidth.Location = new System.Drawing.Point(9, 44);
            this.lblRoomWidth.Name = "lblRoomWidth";
            this.lblRoomWidth.Size = new System.Drawing.Size(69, 15);
            this.lblRoomWidth.TabIndex = 4;
            this.lblRoomWidth.Text = "Room Width";
            this.lblRoomWidth.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRoomAreaOutput
            // 
            this.txtRoomAreaOutput.Location = new System.Drawing.Point(12, 170);
            this.txtRoomAreaOutput.Name = "txtRoomAreaOutput";
            this.txtRoomAreaOutput.Size = new System.Drawing.Size(344, 20);
            this.txtRoomAreaOutput.TabIndex = 5;
            this.txtRoomAreaOutput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblRoomArea
            // 
            this.lblRoomArea.AutoSize = true;
            this.lblRoomArea.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomArea.Location = new System.Drawing.Point(9, 152);
            this.lblRoomArea.Name = "lblRoomArea";
            this.lblRoomArea.Size = new System.Drawing.Size(62, 15);
            this.lblRoomArea.TabIndex = 6;
            this.lblRoomArea.Text = "Room Area";
            // 
            // txtRoomHeightInput
            // 
            this.txtRoomHeightInput.Location = new System.Drawing.Point(12, 100);
            this.txtRoomHeightInput.Name = "txtRoomHeightInput";
            this.txtRoomHeightInput.Size = new System.Drawing.Size(344, 20);
            this.txtRoomHeightInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Height";
            // 
            // btnCalculateRoomVolume
            // 
            this.btnCalculateRoomVolume.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRoomVolume.Location = new System.Drawing.Point(12, 196);
            this.btnCalculateRoomVolume.Name = "btnCalculateRoomVolume";
            this.btnCalculateRoomVolume.Size = new System.Drawing.Size(344, 23);
            this.btnCalculateRoomVolume.TabIndex = 9;
            this.btnCalculateRoomVolume.Text = "Calculate Room Volume";
            this.btnCalculateRoomVolume.UseVisualStyleBackColor = true;
            this.btnCalculateRoomVolume.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Room Volume";
            // 
            // txtRoomVolumeOutput
            // 
            this.txtRoomVolumeOutput.Location = new System.Drawing.Point(12, 239);
            this.txtRoomVolumeOutput.Name = "txtRoomVolumeOutput";
            this.txtRoomVolumeOutput.Size = new System.Drawing.Size(344, 20);
            this.txtRoomVolumeOutput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 267);
            this.Controls.Add(this.txtRoomVolumeOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculateRoomVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomHeightInput);
            this.Controls.Add(this.lblRoomArea);
            this.Controls.Add(this.txtRoomAreaOutput);
            this.Controls.Add(this.lblRoomWidth);
            this.Controls.Add(this.lblRoomLength);
            this.Controls.Add(this.btnCalculateRoomArea);
            this.Controls.Add(this.txtRoomWidthInput);
            this.Controls.Add(this.txtRoomLengthInput);
            this.Name = "Form1";
            this.Text = "Room Area Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomLengthInput;
        private System.Windows.Forms.TextBox txtRoomWidthInput;
        private System.Windows.Forms.Button btnCalculateRoomArea;
        private System.Windows.Forms.Label lblRoomLength;
        private System.Windows.Forms.Label lblRoomWidth;
        private System.Windows.Forms.TextBox txtRoomAreaOutput;
        private System.Windows.Forms.Label lblRoomArea;
        private System.Windows.Forms.TextBox txtRoomHeightInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateRoomVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomVolumeOutput;
    }
}

