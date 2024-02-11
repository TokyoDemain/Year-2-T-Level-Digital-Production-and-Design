namespace PeopleDb2024
{
    partial class DatabaseAccess
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
            this.v = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeleteRecordId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterIdUpdate = new System.Windows.Forms.TextBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnterTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnterAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnterAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(12, 168);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(100, 23);
            this.v.TabIndex = 0;
            this.v.Text = "Add Record";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Enter Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Telephone";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(12, 142);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneNumber.TabIndex = 7;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(118, 12);
            this.txtPeople.Multiline = true;
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(381, 218);
            this.txtPeople.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 236);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(381, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtDeleteRecordId
            // 
            this.txtDeleteRecordId.Location = new System.Drawing.Point(12, 210);
            this.txtDeleteRecordId.Name = "txtDeleteRecordId";
            this.txtDeleteRecordId.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteRecordId.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Enter ID";
            // 
            // txtEnterIdUpdate
            // 
            this.txtEnterIdUpdate.Location = new System.Drawing.Point(505, 25);
            this.txtEnterIdUpdate.Name = "txtEnterIdUpdate";
            this.txtEnterIdUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtEnterIdUpdate.TabIndex = 18;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(505, 207);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteRecord.TabIndex = 17;
            this.btnDeleteRecord.Text = "Update Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter Name";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(505, 64);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Enter Telephone";
            // 
            // txtEnterTelephone
            // 
            this.txtEnterTelephone.Location = new System.Drawing.Point(505, 181);
            this.txtEnterTelephone.Name = "txtEnterTelephone";
            this.txtEnterTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtEnterTelephone.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Enter Address";
            // 
            // txtEnterAddress
            // 
            this.txtEnterAddress.Location = new System.Drawing.Point(505, 142);
            this.txtEnterAddress.Name = "txtEnterAddress";
            this.txtEnterAddress.Size = new System.Drawing.Size(100, 20);
            this.txtEnterAddress.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Enter Age";
            // 
            // txtEnterAge
            // 
            this.txtEnterAge.Location = new System.Drawing.Point(505, 103);
            this.txtEnterAge.Name = "txtEnterAge";
            this.txtEnterAge.Size = new System.Drawing.Size(100, 20);
            this.txtEnterAge.TabIndex = 26;
            // 
            // DatabaseAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 276);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEnterAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnterTelephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEnterAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnterIdUpdate);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeleteRecordId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.v);
            this.Name = "DatabaseAccess";
            this.Text = "Database Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button v;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeleteRecordId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterIdUpdate;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnterTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnterAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnterAge;
    }
}

