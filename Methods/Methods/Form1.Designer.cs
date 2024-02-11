namespace Methods
{
    partial class MethodCalc
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
            this.lblPythaoras = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTaxiCalc = new System.Windows.Forms.Label();
            this.txtInputTaxi = new System.Windows.Forms.TextBox();
            this.btnCalcTaxi = new System.Windows.Forms.Button();
            this.txtOutputTaxi = new System.Windows.Forms.TextBox();
            this.lblWeighConv = new System.Windows.Forms.Label();
            this.btnCalcWeight = new System.Windows.Forms.Button();
            this.txtWeightIn = new System.Windows.Forms.TextBox();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPythaoras
            // 
            this.lblPythaoras.AutoSize = true;
            this.lblPythaoras.Location = new System.Drawing.Point(9, 9);
            this.lblPythaoras.Name = "lblPythaoras";
            this.lblPythaoras.Size = new System.Drawing.Size(60, 13);
            this.lblPythaoras.TabIndex = 0;
            this.lblPythaoras.Text = "Pythagoras";
            this.lblPythaoras.Click += new System.EventHandler(this.lblPythaoras_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(113, 28);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(113, 54);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 77);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 21);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lblTaxiCalc
            // 
            this.lblTaxiCalc.AutoSize = true;
            this.lblTaxiCalc.Location = new System.Drawing.Point(134, 9);
            this.lblTaxiCalc.Name = "lblTaxiCalc";
            this.lblTaxiCalc.Size = new System.Drawing.Size(77, 13);
            this.lblTaxiCalc.TabIndex = 7;
            this.lblTaxiCalc.Text = "Taxi Calculator";
            // 
            // txtInputTaxi
            // 
            this.txtInputTaxi.Location = new System.Drawing.Point(137, 25);
            this.txtInputTaxi.Name = "txtInputTaxi";
            this.txtInputTaxi.Size = new System.Drawing.Size(74, 20);
            this.txtInputTaxi.TabIndex = 8;
            // 
            // btnCalcTaxi
            // 
            this.btnCalcTaxi.Location = new System.Drawing.Point(137, 51);
            this.btnCalcTaxi.Name = "btnCalcTaxi";
            this.btnCalcTaxi.Size = new System.Drawing.Size(74, 21);
            this.btnCalcTaxi.TabIndex = 9;
            this.btnCalcTaxi.Text = "Calculate";
            this.btnCalcTaxi.UseVisualStyleBackColor = true;
            this.btnCalcTaxi.Click += new System.EventHandler(this.btnCalcTaxi_Click);
            // 
            // txtOutputTaxi
            // 
            this.txtOutputTaxi.Location = new System.Drawing.Point(137, 77);
            this.txtOutputTaxi.Name = "txtOutputTaxi";
            this.txtOutputTaxi.Size = new System.Drawing.Size(74, 20);
            this.txtOutputTaxi.TabIndex = 10;
            // 
            // lblWeighConv
            // 
            this.lblWeighConv.AutoSize = true;
            this.lblWeighConv.Location = new System.Drawing.Point(214, 9);
            this.lblWeighConv.Name = "lblWeighConv";
            this.lblWeighConv.Size = new System.Drawing.Size(97, 13);
            this.lblWeighConv.TabIndex = 11;
            this.lblWeighConv.Text = "Weight Conversion";
            // 
            // btnCalcWeight
            // 
            this.btnCalcWeight.Location = new System.Drawing.Point(217, 51);
            this.btnCalcWeight.Name = "btnCalcWeight";
            this.btnCalcWeight.Size = new System.Drawing.Size(94, 20);
            this.btnCalcWeight.TabIndex = 12;
            this.btnCalcWeight.Text = "Calculate";
            this.btnCalcWeight.UseVisualStyleBackColor = true;
            this.btnCalcWeight.Click += new System.EventHandler(this.btnCalcWeight_Click);
            // 
            // txtWeightIn
            // 
            this.txtWeightIn.Location = new System.Drawing.Point(217, 25);
            this.txtWeightIn.Name = "txtWeightIn";
            this.txtWeightIn.Size = new System.Drawing.Size(94, 20);
            this.txtWeightIn.TabIndex = 13;
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(218, 77);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(93, 20);
            this.txtPounds.TabIndex = 14;
            // 
            // txtGrams
            // 
            this.txtGrams.Location = new System.Drawing.Point(218, 104);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(93, 20);
            this.txtGrams.TabIndex = 15;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(218, 131);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(93, 20);
            this.txtKilos.TabIndex = 16;
            // 
            // MethodCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 157);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.txtGrams);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.txtWeightIn);
            this.Controls.Add(this.btnCalcWeight);
            this.Controls.Add(this.lblWeighConv);
            this.Controls.Add(this.txtOutputTaxi);
            this.Controls.Add(this.btnCalcTaxi);
            this.Controls.Add(this.txtInputTaxi);
            this.Controls.Add(this.lblTaxiCalc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPythaoras);
            this.Name = "MethodCalc";
            this.Text = "Method Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPythaoras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTaxiCalc;
        private System.Windows.Forms.TextBox txtInputTaxi;
        private System.Windows.Forms.Button btnCalcTaxi;
        private System.Windows.Forms.TextBox txtOutputTaxi;
        private System.Windows.Forms.Label lblWeighConv;
        private System.Windows.Forms.Button btnCalcWeight;
        private System.Windows.Forms.TextBox txtWeightIn;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.TextBox txtKilos;
    }
}

