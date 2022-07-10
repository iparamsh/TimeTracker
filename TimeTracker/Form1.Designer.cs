namespace TimeTracker
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
            this.timeInTB = new System.Windows.Forms.TextBox();
            this.timeOutTB = new System.Windows.Forms.TextBox();
            this.breakTimeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackHoursBTN = new System.Windows.Forms.Button();
            this.changeMoneyPerHourBTN = new System.Windows.Forms.Button();
            this.MoneyPerHourLB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timePerHourLBL = new System.Windows.Forms.Label();
            this.expectedPaycheckLBL = new System.Windows.Forms.Label();
            this.totalHoursLBL = new System.Windows.Forms.Label();
            this.FlashHoursBTN = new System.Windows.Forms.Button();
            this.dateLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeInTB
            // 
            this.timeInTB.Location = new System.Drawing.Point(12, 52);
            this.timeInTB.Name = "timeInTB";
            this.timeInTB.Size = new System.Drawing.Size(125, 27);
            this.timeInTB.TabIndex = 0;
            // 
            // timeOutTB
            // 
            this.timeOutTB.Location = new System.Drawing.Point(12, 105);
            this.timeOutTB.Name = "timeOutTB";
            this.timeOutTB.Size = new System.Drawing.Size(125, 27);
            this.timeOutTB.TabIndex = 1;
            // 
            // breakTimeTB
            // 
            this.breakTimeTB.Location = new System.Drawing.Point(12, 158);
            this.breakTimeTB.Name = "breakTimeTB";
            this.breakTimeTB.Size = new System.Drawing.Size(125, 27);
            this.breakTimeTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time in ( hr : min am/pm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time out ( hr : min am/pm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "break time (minutes)";
            // 
            // trackHoursBTN
            // 
            this.trackHoursBTN.Location = new System.Drawing.Point(12, 201);
            this.trackHoursBTN.Name = "trackHoursBTN";
            this.trackHoursBTN.Size = new System.Drawing.Size(94, 29);
            this.trackHoursBTN.TabIndex = 6;
            this.trackHoursBTN.Text = "Track";
            this.trackHoursBTN.UseVisualStyleBackColor = true;
            this.trackHoursBTN.Click += new System.EventHandler(this.trackTimeBtn);
            // 
            // changeMoneyPerHourBTN
            // 
            this.changeMoneyPerHourBTN.Location = new System.Drawing.Point(276, 82);
            this.changeMoneyPerHourBTN.Name = "changeMoneyPerHourBTN";
            this.changeMoneyPerHourBTN.Size = new System.Drawing.Size(94, 29);
            this.changeMoneyPerHourBTN.TabIndex = 7;
            this.changeMoneyPerHourBTN.Text = "change";
            this.changeMoneyPerHourBTN.UseVisualStyleBackColor = true;
            this.changeMoneyPerHourBTN.Click += new System.EventHandler(this.changeMoneyPerHourBTN_Click);
            // 
            // MoneyPerHourLB
            // 
            this.MoneyPerHourLB.Location = new System.Drawing.Point(276, 43);
            this.MoneyPerHourLB.Name = "MoneyPerHourLB";
            this.MoneyPerHourLB.Size = new System.Drawing.Size(94, 27);
            this.MoneyPerHourLB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time per hour";
            // 
            // timePerHourLBL
            // 
            this.timePerHourLBL.AutoSize = true;
            this.timePerHourLBL.Location = new System.Drawing.Point(276, 114);
            this.timePerHourLBL.Name = "timePerHourLBL";
            this.timePerHourLBL.Size = new System.Drawing.Size(64, 20);
            this.timePerHourLBL.TabIndex = 10;
            this.timePerHourLBL.Text = "Current: ";
            // 
            // expectedPaycheckLBL
            // 
            this.expectedPaycheckLBL.AutoSize = true;
            this.expectedPaycheckLBL.Location = new System.Drawing.Point(178, 210);
            this.expectedPaycheckLBL.Name = "expectedPaycheckLBL";
            this.expectedPaycheckLBL.Size = new System.Drawing.Size(142, 20);
            this.expectedPaycheckLBL.TabIndex = 11;
            this.expectedPaycheckLBL.Text = "Expected paycheck: ";
            // 
            // totalHoursLBL
            // 
            this.totalHoursLBL.AutoSize = true;
            this.totalHoursLBL.Location = new System.Drawing.Point(178, 177);
            this.totalHoursLBL.Name = "totalHoursLBL";
            this.totalHoursLBL.Size = new System.Drawing.Size(108, 20);
            this.totalHoursLBL.TabIndex = 12;
            this.totalHoursLBL.Text = "Hours worked: ";
            // 
            // FlashHoursBTN
            // 
            this.FlashHoursBTN.Location = new System.Drawing.Point(276, 145);
            this.FlashHoursBTN.Name = "FlashHoursBTN";
            this.FlashHoursBTN.Size = new System.Drawing.Size(94, 29);
            this.FlashHoursBTN.TabIndex = 13;
            this.FlashHoursBTN.Text = "Flash hours";
            this.FlashHoursBTN.UseVisualStyleBackColor = true;
            this.FlashHoursBTN.Click += new System.EventHandler(this.FlashHoursBTN_Click);
            // 
            // dateLBL
            // 
            this.dateLBL.AutoSize = true;
            this.dateLBL.Location = new System.Drawing.Point(14, 6);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(96, 20);
            this.dateLBL.TabIndex = 14;
            this.dateLBL.Text = "Todays date: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 252);
            this.Controls.Add(this.dateLBL);
            this.Controls.Add(this.FlashHoursBTN);
            this.Controls.Add(this.totalHoursLBL);
            this.Controls.Add(this.expectedPaycheckLBL);
            this.Controls.Add(this.timePerHourLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MoneyPerHourLB);
            this.Controls.Add(this.changeMoneyPerHourBTN);
            this.Controls.Add(this.trackHoursBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breakTimeTB);
            this.Controls.Add(this.timeOutTB);
            this.Controls.Add(this.timeInTB);
            this.Name = "Form1";
            this.Text = "TimeTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox timeInTB;
        private TextBox timeOutTB;
        private TextBox breakTimeTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button trackHoursBTN;
        private Button changeMoneyPerHourBTN;
        private TextBox MoneyPerHourLB;
        private Label label4;
        private Label timePerHourLBL;
        private Label expectedPaycheckLBL;
        private Label totalHoursLBL;
        private Button FlashHoursBTN;
        private Label dateLBL;
    }
}