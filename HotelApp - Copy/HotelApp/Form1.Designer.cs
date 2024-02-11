namespace HotelApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnVacateRoom = new System.Windows.Forms.Button();
            this.btnCountCustomers = new System.Windows.Forms.Button();
            this.btnShowIncome = new System.Windows.Forms.Button();
            this.btnReportOnRoom = new System.Windows.Forms.Button();
            this.gbVacateRoom = new System.Windows.Forms.GroupBox();
            this.btnVacate = new System.Windows.Forms.Button();
            this.txtCustomerNameVacate = new System.Windows.Forms.TextBox();
            this.GbBookRoom = new System.Windows.Forms.GroupBox();
            this.txtCustomerNameBook = new System.Windows.Forms.TextBox();
            this.btnBookRoomBook = new System.Windows.Forms.Button();
            this.txtRoomNumberBook = new System.Windows.Forms.TextBox();
            this.GbCountCustomers = new System.Windows.Forms.GroupBox();
            this.txtCountCustomers = new System.Windows.Forms.TextBox();
            this.gbShowIncome = new System.Windows.Forms.GroupBox();
            this.txtShowIncome = new System.Windows.Forms.TextBox();
            this.GbReportOnCustomer = new System.Windows.Forms.GroupBox();
            this.txtReportOnName = new System.Windows.Forms.TextBox();
            this.txtCustomerNameReport = new System.Windows.Forms.TextBox();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnRoomAvailablility = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbVacateRoom.SuspendLayout();
            this.GbBookRoom.SuspendLayout();
            this.GbCountCustomers.SuspendLayout();
            this.gbShowIncome.SuspendLayout();
            this.GbReportOnCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(12, 12);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(111, 23);
            this.btnBookRoom.TabIndex = 0;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnVacateRoom
            // 
            this.btnVacateRoom.Location = new System.Drawing.Point(12, 41);
            this.btnVacateRoom.Name = "btnVacateRoom";
            this.btnVacateRoom.Size = new System.Drawing.Size(111, 23);
            this.btnVacateRoom.TabIndex = 1;
            this.btnVacateRoom.Text = "Vacate Room";
            this.btnVacateRoom.UseVisualStyleBackColor = true;
            this.btnVacateRoom.Click += new System.EventHandler(this.btnVacateRoom_Click);
            // 
            // btnCountCustomers
            // 
            this.btnCountCustomers.Location = new System.Drawing.Point(12, 70);
            this.btnCountCustomers.Name = "btnCountCustomers";
            this.btnCountCustomers.Size = new System.Drawing.Size(111, 23);
            this.btnCountCustomers.TabIndex = 2;
            this.btnCountCustomers.Text = "Count Customers";
            this.btnCountCustomers.UseVisualStyleBackColor = true;
            this.btnCountCustomers.Click += new System.EventHandler(this.btnCountCustomers_Click);
            // 
            // btnShowIncome
            // 
            this.btnShowIncome.Location = new System.Drawing.Point(12, 99);
            this.btnShowIncome.Name = "btnShowIncome";
            this.btnShowIncome.Size = new System.Drawing.Size(111, 23);
            this.btnShowIncome.TabIndex = 3;
            this.btnShowIncome.Text = "Show Income";
            this.btnShowIncome.UseVisualStyleBackColor = true;
            this.btnShowIncome.Click += new System.EventHandler(this.btnShowIncome_Click);
            // 
            // btnReportOnRoom
            // 
            this.btnReportOnRoom.Location = new System.Drawing.Point(12, 128);
            this.btnReportOnRoom.Name = "btnReportOnRoom";
            this.btnReportOnRoom.Size = new System.Drawing.Size(111, 23);
            this.btnReportOnRoom.TabIndex = 4;
            this.btnReportOnRoom.Text = "Report on Customer";
            this.btnReportOnRoom.UseVisualStyleBackColor = true;
            this.btnReportOnRoom.Click += new System.EventHandler(this.btnReportOnRoom_Click);
            // 
            // gbVacateRoom
            // 
            this.gbVacateRoom.Controls.Add(this.btnVacate);
            this.gbVacateRoom.Controls.Add(this.txtCustomerNameVacate);
            this.gbVacateRoom.Location = new System.Drawing.Point(129, 12);
            this.gbVacateRoom.Name = "gbVacateRoom";
            this.gbVacateRoom.Size = new System.Drawing.Size(116, 81);
            this.gbVacateRoom.TabIndex = 5;
            this.gbVacateRoom.TabStop = false;
            this.gbVacateRoom.Text = "Vacate Room";
            this.gbVacateRoom.Enter += new System.EventHandler(this.gbVacateRoom_Enter);
            // 
            // btnVacate
            // 
            this.btnVacate.Location = new System.Drawing.Point(7, 46);
            this.btnVacate.Name = "btnVacate";
            this.btnVacate.Size = new System.Drawing.Size(103, 23);
            this.btnVacate.TabIndex = 1;
            this.btnVacate.Text = "Vacate";
            this.btnVacate.UseVisualStyleBackColor = true;
            this.btnVacate.Click += new System.EventHandler(this.btnVacate_Click);
            // 
            // txtCustomerNameVacate
            // 
            this.txtCustomerNameVacate.Location = new System.Drawing.Point(6, 19);
            this.txtCustomerNameVacate.Name = "txtCustomerNameVacate";
            this.txtCustomerNameVacate.Size = new System.Drawing.Size(104, 20);
            this.txtCustomerNameVacate.TabIndex = 0;
            // 
            // GbBookRoom
            // 
            this.GbBookRoom.Controls.Add(this.txtCustomerNameBook);
            this.GbBookRoom.Controls.Add(this.btnBookRoomBook);
            this.GbBookRoom.Controls.Add(this.txtRoomNumberBook);
            this.GbBookRoom.Location = new System.Drawing.Point(129, 99);
            this.GbBookRoom.Name = "GbBookRoom";
            this.GbBookRoom.Size = new System.Drawing.Size(116, 104);
            this.GbBookRoom.TabIndex = 6;
            this.GbBookRoom.TabStop = false;
            this.GbBookRoom.Text = "Book Room";
            this.GbBookRoom.Enter += new System.EventHandler(this.GbBookRoom_Enter);
            // 
            // txtCustomerNameBook
            // 
            this.txtCustomerNameBook.Location = new System.Drawing.Point(6, 45);
            this.txtCustomerNameBook.Name = "txtCustomerNameBook";
            this.txtCustomerNameBook.Size = new System.Drawing.Size(104, 20);
            this.txtCustomerNameBook.TabIndex = 2;
            // 
            // btnBookRoomBook
            // 
            this.btnBookRoomBook.Location = new System.Drawing.Point(6, 71);
            this.btnBookRoomBook.Name = "btnBookRoomBook";
            this.btnBookRoomBook.Size = new System.Drawing.Size(104, 23);
            this.btnBookRoomBook.TabIndex = 1;
            this.btnBookRoomBook.Text = "Book";
            this.btnBookRoomBook.UseVisualStyleBackColor = true;
            this.btnBookRoomBook.Click += new System.EventHandler(this.btnBookRoomBook_Click);
            // 
            // txtRoomNumberBook
            // 
            this.txtRoomNumberBook.Location = new System.Drawing.Point(6, 19);
            this.txtRoomNumberBook.Name = "txtRoomNumberBook";
            this.txtRoomNumberBook.Size = new System.Drawing.Size(104, 20);
            this.txtRoomNumberBook.TabIndex = 0;
            // 
            // GbCountCustomers
            // 
            this.GbCountCustomers.Controls.Add(this.txtCountCustomers);
            this.GbCountCustomers.Location = new System.Drawing.Point(129, 209);
            this.GbCountCustomers.Name = "GbCountCustomers";
            this.GbCountCustomers.Size = new System.Drawing.Size(116, 49);
            this.GbCountCustomers.TabIndex = 8;
            this.GbCountCustomers.TabStop = false;
            this.GbCountCustomers.Text = "Count Customers";
            // 
            // txtCountCustomers
            // 
            this.txtCountCustomers.Location = new System.Drawing.Point(7, 19);
            this.txtCountCustomers.Name = "txtCountCustomers";
            this.txtCountCustomers.Size = new System.Drawing.Size(103, 20);
            this.txtCountCustomers.TabIndex = 9;
            // 
            // gbShowIncome
            // 
            this.gbShowIncome.Controls.Add(this.txtShowIncome);
            this.gbShowIncome.Location = new System.Drawing.Point(129, 264);
            this.gbShowIncome.Name = "gbShowIncome";
            this.gbShowIncome.Size = new System.Drawing.Size(116, 49);
            this.gbShowIncome.TabIndex = 10;
            this.gbShowIncome.TabStop = false;
            this.gbShowIncome.Text = "Show Income";
            // 
            // txtShowIncome
            // 
            this.txtShowIncome.Location = new System.Drawing.Point(7, 19);
            this.txtShowIncome.Name = "txtShowIncome";
            this.txtShowIncome.Size = new System.Drawing.Size(103, 20);
            this.txtShowIncome.TabIndex = 9;
            // 
            // GbReportOnCustomer
            // 
            this.GbReportOnCustomer.Controls.Add(this.txtReportOnName);
            this.GbReportOnCustomer.Controls.Add(this.txtCustomerNameReport);
            this.GbReportOnCustomer.Controls.Add(this.btnGetReport);
            this.GbReportOnCustomer.Location = new System.Drawing.Point(7, 186);
            this.GbReportOnCustomer.Name = "GbReportOnCustomer";
            this.GbReportOnCustomer.Size = new System.Drawing.Size(116, 102);
            this.GbReportOnCustomer.TabIndex = 7;
            this.GbReportOnCustomer.TabStop = false;
            this.GbReportOnCustomer.Text = "Report on Customer";
            // 
            // txtReportOnName
            // 
            this.txtReportOnName.Location = new System.Drawing.Point(6, 74);
            this.txtReportOnName.Name = "txtReportOnName";
            this.txtReportOnName.Size = new System.Drawing.Size(104, 20);
            this.txtReportOnName.TabIndex = 2;
            // 
            // txtCustomerNameReport
            // 
            this.txtCustomerNameReport.Location = new System.Drawing.Point(6, 19);
            this.txtCustomerNameReport.Name = "txtCustomerNameReport";
            this.txtCustomerNameReport.Size = new System.Drawing.Size(104, 20);
            this.txtCustomerNameReport.TabIndex = 0;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(6, 45);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(104, 23);
            this.btnGetReport.TabIndex = 1;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRoomAvailablility
            // 
            this.btnRoomAvailablility.Location = new System.Drawing.Point(12, 157);
            this.btnRoomAvailablility.Name = "btnRoomAvailablility";
            this.btnRoomAvailablility.Size = new System.Drawing.Size(111, 23);
            this.btnRoomAvailablility.TabIndex = 11;
            this.btnRoomAvailablility.Text = "Availablility";
            this.btnRoomAvailablility.UseVisualStyleBackColor = true;
            this.btnRoomAvailablility.Click += new System.EventHandler(this.btnRoomAvailablility_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image-removebg-preview.png");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(262, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 301);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 325);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRoomAvailablility);
            this.Controls.Add(this.GbReportOnCustomer);
            this.Controls.Add(this.gbShowIncome);
            this.Controls.Add(this.GbCountCustomers);
            this.Controls.Add(this.GbBookRoom);
            this.Controls.Add(this.gbVacateRoom);
            this.Controls.Add(this.btnReportOnRoom);
            this.Controls.Add(this.btnShowIncome);
            this.Controls.Add(this.btnCountCustomers);
            this.Controls.Add(this.btnVacateRoom);
            this.Controls.Add(this.btnBookRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eagle Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVacateRoom.ResumeLayout(false);
            this.gbVacateRoom.PerformLayout();
            this.GbBookRoom.ResumeLayout(false);
            this.GbBookRoom.PerformLayout();
            this.GbCountCustomers.ResumeLayout(false);
            this.GbCountCustomers.PerformLayout();
            this.gbShowIncome.ResumeLayout(false);
            this.gbShowIncome.PerformLayout();
            this.GbReportOnCustomer.ResumeLayout(false);
            this.GbReportOnCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnVacateRoom;
        private System.Windows.Forms.Button btnCountCustomers;
        private System.Windows.Forms.Button btnShowIncome;
        private System.Windows.Forms.Button btnReportOnRoom;
        private System.Windows.Forms.GroupBox gbVacateRoom;
        private System.Windows.Forms.Button btnVacate;
        private System.Windows.Forms.TextBox txtCustomerNameVacate;
        private System.Windows.Forms.GroupBox GbBookRoom;
        private System.Windows.Forms.Button btnBookRoomBook;
        private System.Windows.Forms.TextBox txtRoomNumberBook;
        private System.Windows.Forms.TextBox txtCustomerNameBook;
        private System.Windows.Forms.GroupBox GbCountCustomers;
        private System.Windows.Forms.TextBox txtCountCustomers;
        private System.Windows.Forms.GroupBox gbShowIncome;
        private System.Windows.Forms.TextBox txtShowIncome;
        private System.Windows.Forms.GroupBox GbReportOnCustomer;
        private System.Windows.Forms.TextBox txtReportOnName;
        private System.Windows.Forms.TextBox txtCustomerNameReport;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Button btnRoomAvailablility;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

