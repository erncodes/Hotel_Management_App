namespace Hotel_App
{
    partial class Booking
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
            this.booking_dashboard = new System.Windows.Forms.Panel();
            this.guest_numeric = new System.Windows.Forms.NumericUpDown();
            this.Price_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Spar_checkBox = new System.Windows.Forms.CheckBox();
            this.Chauffer_checkBox = new System.Windows.Forms.CheckBox();
            this.Cheff_checkBox = new System.Windows.Forms.CheckBox();
            this.Vip_CheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.total_estimate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Single_radio = new System.Windows.Forms.RadioButton();
            this.Two_radio = new System.Windows.Forms.RadioButton();
            this.family_radio = new System.Windows.Forms.RadioButton();
            this.Book_Submit = new System.Windows.Forms.Button();
            this.calendor_textBox = new System.Windows.Forms.TextBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.panel_book = new System.Windows.Forms.Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booking_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest_numeric)).BeginInit();
            this.panel_book.SuspendLayout();
            this.SuspendLayout();
            // 
            // booking_dashboard
            // 
            this.booking_dashboard.BackColor = System.Drawing.Color.White;
            this.booking_dashboard.Controls.Add(this.label1);
            this.booking_dashboard.Controls.Add(this.guest_numeric);
            this.booking_dashboard.Controls.Add(this.Price_label);
            this.booking_dashboard.Controls.Add(this.label10);
            this.booking_dashboard.Controls.Add(this.label9);
            this.booking_dashboard.Controls.Add(this.label8);
            this.booking_dashboard.Controls.Add(this.Spar_checkBox);
            this.booking_dashboard.Controls.Add(this.Chauffer_checkBox);
            this.booking_dashboard.Controls.Add(this.Cheff_checkBox);
            this.booking_dashboard.Controls.Add(this.Vip_CheckBox);
            this.booking_dashboard.Controls.Add(this.label7);
            this.booking_dashboard.Controls.Add(this.total_estimate);
            this.booking_dashboard.Controls.Add(this.label5);
            this.booking_dashboard.Controls.Add(this.label4);
            this.booking_dashboard.Controls.Add(this.label3);
            this.booking_dashboard.Controls.Add(this.Single_radio);
            this.booking_dashboard.Controls.Add(this.Two_radio);
            this.booking_dashboard.Controls.Add(this.family_radio);
            this.booking_dashboard.Controls.Add(this.Book_Submit);
            this.booking_dashboard.Controls.Add(this.calendor_textBox);
            this.booking_dashboard.Controls.Add(this.Calendar);
            this.booking_dashboard.Controls.Add(this.panel_book);
            this.booking_dashboard.Location = new System.Drawing.Point(0, 0);
            this.booking_dashboard.Name = "booking_dashboard";
            this.booking_dashboard.Size = new System.Drawing.Size(766, 443);
            this.booking_dashboard.TabIndex = 1;
            // 
            // guest_numeric
            // 
            this.guest_numeric.Location = new System.Drawing.Point(126, 384);
            this.guest_numeric.Name = "guest_numeric";
            this.guest_numeric.Size = new System.Drawing.Size(43, 20);
            this.guest_numeric.TabIndex = 23;
            this.guest_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guest_numeric.ValueChanged += new System.EventHandler(this.guest_numeric_ValueChanged);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Price_label.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(441, 225);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(104, 20);
            this.Price_label.TabIndex = 22;
            this.Price_label.Text = "information on pricing.";
            this.Price_label.Click += new System.EventHandler(this.Price_label_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(379, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Click here for ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Location = new System.Drawing.Point(376, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "* Please note VIP experience includes all above services";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Number Of Guests:";
            // 
            // Spar_checkBox
            // 
            this.Spar_checkBox.AutoSize = true;
            this.Spar_checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spar_checkBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spar_checkBox.Location = new System.Drawing.Point(554, 185);
            this.Spar_checkBox.Name = "Spar_checkBox";
            this.Spar_checkBox.Size = new System.Drawing.Size(81, 24);
            this.Spar_checkBox.TabIndex = 16;
            this.Spar_checkBox.Text = "Spar Deluxe";
            this.Spar_checkBox.UseVisualStyleBackColor = true;
            this.Spar_checkBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Chauffer_checkBox
            // 
            this.Chauffer_checkBox.AutoSize = true;
            this.Chauffer_checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chauffer_checkBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chauffer_checkBox.Location = new System.Drawing.Point(553, 125);
            this.Chauffer_checkBox.Name = "Chauffer_checkBox";
            this.Chauffer_checkBox.Size = new System.Drawing.Size(104, 24);
            this.Chauffer_checkBox.TabIndex = 15;
            this.Chauffer_checkBox.Text = "Personal Chauffer";
            this.Chauffer_checkBox.UseVisualStyleBackColor = true;
            this.Chauffer_checkBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Cheff_checkBox
            // 
            this.Cheff_checkBox.AutoSize = true;
            this.Cheff_checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheff_checkBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheff_checkBox.Location = new System.Drawing.Point(553, 155);
            this.Cheff_checkBox.Name = "Cheff_checkBox";
            this.Cheff_checkBox.Size = new System.Drawing.Size(89, 24);
            this.Cheff_checkBox.TabIndex = 14;
            this.Cheff_checkBox.Text = "Personal Cheff";
            this.Cheff_checkBox.UseVisualStyleBackColor = true;
            this.Cheff_checkBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Vip_CheckBox
            // 
            this.Vip_CheckBox.AutoSize = true;
            this.Vip_CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vip_CheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vip_CheckBox.Location = new System.Drawing.Point(553, 95);
            this.Vip_CheckBox.Name = "Vip_CheckBox";
            this.Vip_CheckBox.Size = new System.Drawing.Size(93, 24);
            this.Vip_CheckBox.TabIndex = 13;
            this.Vip_CheckBox.Text = "VIP Experience";
            this.Vip_CheckBox.UseVisualStyleBackColor = true;
            this.Vip_CheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Services";
            // 
            // total_estimate
            // 
            this.total_estimate.AutoSize = true;
            this.total_estimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.total_estimate.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_estimate.ForeColor = System.Drawing.Color.DarkGreen;
            this.total_estimate.Location = new System.Drawing.Point(538, 312);
            this.total_estimate.Name = "total_estimate";
            this.total_estimate.Size = new System.Drawing.Size(47, 25);
            this.total_estimate.TabIndex = 11;
            this.total_estimate.Text = " 0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(418, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "View Estimate:";
            this.label5.EnabledChanged += new System.EventHandler(this.guest_numeric_ValueChanged);
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose A Date:";
            // 
            // Single_radio
            // 
            this.Single_radio.AutoSize = true;
            this.Single_radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Single_radio.Location = new System.Drawing.Point(319, 99);
            this.Single_radio.Name = "Single_radio";
            this.Single_radio.Size = new System.Drawing.Size(85, 17);
            this.Single_radio.TabIndex = 6;
            this.Single_radio.Text = "Single Room";
            this.Single_radio.UseVisualStyleBackColor = true;
            this.Single_radio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Two_radio
            // 
            this.Two_radio.AutoSize = true;
            this.Two_radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Two_radio.Location = new System.Drawing.Point(319, 122);
            this.Two_radio.Name = "Two_radio";
            this.Two_radio.Size = new System.Drawing.Size(91, 17);
            this.Two_radio.TabIndex = 5;
            this.Two_radio.Text = "Two Bedroom";
            this.Two_radio.UseVisualStyleBackColor = true;
            this.Two_radio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // family_radio
            // 
            this.family_radio.AutoSize = true;
            this.family_radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.family_radio.Location = new System.Drawing.Point(319, 145);
            this.family_radio.Name = "family_radio";
            this.family_radio.Size = new System.Drawing.Size(148, 17);
            this.family_radio.TabIndex = 4;
            this.family_radio.Text = "Family Unit(Four Bedroom)";
            this.family_radio.UseVisualStyleBackColor = true;
            this.family_radio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Book_Submit
            // 
            this.Book_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book_Submit.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Submit.Location = new System.Drawing.Point(363, 366);
            this.Book_Submit.Name = "Book_Submit";
            this.Book_Submit.Size = new System.Drawing.Size(260, 59);
            this.Book_Submit.TabIndex = 3;
            this.Book_Submit.Text = "Book";
            this.Book_Submit.UseVisualStyleBackColor = true;
            this.Book_Submit.Click += new System.EventHandler(this.Book_Submit_Click);
            // 
            // calendor_textBox
            // 
            this.calendor_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendor_textBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendor_textBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendor_textBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.calendor_textBox.Location = new System.Drawing.Point(9, 270);
            this.calendor_textBox.Multiline = true;
            this.calendor_textBox.Name = "calendor_textBox";
            this.calendor_textBox.Size = new System.Drawing.Size(227, 70);
            this.calendor_textBox.TabIndex = 2;
            // 
            // Calendar
            // 
            this.Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendar.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Location = new System.Drawing.Point(9, 95);
            this.Calendar.MaxSelectionCount = 14;
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.TabIndex = 1;
            this.Calendar.TitleBackColor = System.Drawing.Color.Teal;
            this.Calendar.TrailingForeColor = System.Drawing.Color.Teal;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // panel_book
            // 
            this.panel_book.BackColor = System.Drawing.Color.Teal;
            this.panel_book.Controls.Add(this.label62);
            this.panel_book.Controls.Add(this.label2);
            this.panel_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_book.Location = new System.Drawing.Point(0, 0);
            this.panel_book.Name = "panel_book";
            this.panel_book.Size = new System.Drawing.Size(766, 51);
            this.panel_book.TabIndex = 0;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(716, 14);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(25, 24);
            this.label62.TabIndex = 27;
            this.label62.Text = "X";
            this.label62.Click += new System.EventHandler(this.label62_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Fill In The Details Below To Make A Booking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(517, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "R ";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(766, 455);
            this.Controls.Add(this.booking_dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(114, 100);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.booking_dashboard.ResumeLayout(false);
            this.booking_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest_numeric)).EndInit();
            this.panel_book.ResumeLayout(false);
            this.panel_book.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel booking_dashboard;
        private System.Windows.Forms.NumericUpDown guest_numeric;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Spar_checkBox;
        private System.Windows.Forms.CheckBox Chauffer_checkBox;
        private System.Windows.Forms.CheckBox Cheff_checkBox;
        private System.Windows.Forms.CheckBox Vip_CheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label total_estimate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Single_radio;
        private System.Windows.Forms.RadioButton Two_radio;
        private System.Windows.Forms.RadioButton family_radio;
        private System.Windows.Forms.Button Book_Submit;
        private System.Windows.Forms.TextBox calendor_textBox;
        private System.Windows.Forms.Panel panel_book;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
    }
}