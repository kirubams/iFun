namespace iFunGameStation
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.btnGetDailyIncome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDailyIncome = new System.Windows.Forms.Label();
            this.lblDailyExpense = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnDownloadDaily = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datePickerMonthly = new System.Windows.Forms.DateTimePicker();
            this.btnReportMonthly = new System.Windows.Forms.Button();
            this.btnGetMonthlyIncome = new System.Windows.Forms.Button();
            this.btnDownloadMonthly = new System.Windows.Forms.Button();
            this.lblIncomeMonthly = new System.Windows.Forms.Label();
            this.lblExpenseMonthly = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datePickerYearly = new System.Windows.Forms.DateTimePicker();
            this.btnReportYearly = new System.Windows.Forms.Button();
            this.btnGetYearlyIncome = new System.Windows.Forms.Button();
            this.btnDownloadYearly = new System.Windows.Forms.Button();
            this.lblIncomeYearly = new System.Windows.Forms.Label();
            this.lblExpenseYearly = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDailyIncome
            // 
            this.btnGetDailyIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetDailyIncome.BackgroundImage")));
            this.btnGetDailyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDailyIncome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetDailyIncome.Location = new System.Drawing.Point(13, 17);
            this.btnGetDailyIncome.Name = "btnGetDailyIncome";
            this.btnGetDailyIncome.Size = new System.Drawing.Size(315, 79);
            this.btnGetDailyIncome.TabIndex = 0;
            this.btnGetDailyIncome.Text = "GetDailyIncome";
            this.btnGetDailyIncome.UseVisualStyleBackColor = true;
            this.btnGetDailyIncome.Click += new System.EventHandler(this.btnGetDailyIncome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(402, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income For Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(402, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "ExpenseForToday:";
            // 
            // lblDailyIncome
            // 
            this.lblDailyIncome.AutoSize = true;
            this.lblDailyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyIncome.Image = ((System.Drawing.Image)(resources.GetObject("lblDailyIncome.Image")));
            this.lblDailyIncome.Location = new System.Drawing.Point(713, 79);
            this.lblDailyIncome.Name = "lblDailyIncome";
            this.lblDailyIncome.Size = new System.Drawing.Size(42, 46);
            this.lblDailyIncome.TabIndex = 3;
            this.lblDailyIncome.Text = "0";
            // 
            // lblDailyExpense
            // 
            this.lblDailyExpense.AutoSize = true;
            this.lblDailyExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyExpense.Image = ((System.Drawing.Image)(resources.GetObject("lblDailyExpense.Image")));
            this.lblDailyExpense.Location = new System.Drawing.Point(713, 147);
            this.lblDailyExpense.Name = "lblDailyExpense";
            this.lblDailyExpense.Size = new System.Drawing.Size(42, 46);
            this.lblDailyExpense.TabIndex = 4;
            this.lblDailyExpense.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.btnGetDailyIncome);
            this.panel1.Controls.Add(this.btnDownloadDaily);
            this.panel1.Controls.Add(this.lblDailyIncome);
            this.panel1.Controls.Add(this.lblDailyExpense);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 344);
            this.panel1.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(408, 17);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 8;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.BackgroundImage")));
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSendEmail.Location = new System.Drawing.Point(13, 235);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(315, 79);
            this.btnSendEmail.TabIndex = 7;
            this.btnSendEmail.Text = "Send Report";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnDownloadDaily
            // 
            this.btnDownloadDaily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownloadDaily.BackgroundImage")));
            this.btnDownloadDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadDaily.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDownloadDaily.Location = new System.Drawing.Point(13, 128);
            this.btnDownloadDaily.Name = "btnDownloadDaily";
            this.btnDownloadDaily.Size = new System.Drawing.Size(315, 79);
            this.btnDownloadDaily.TabIndex = 6;
            this.btnDownloadDaily.Text = "Download Daily";
            this.btnDownloadDaily.UseVisualStyleBackColor = true;
            this.btnDownloadDaily.Click += new System.EventHandler(this.btnDownloadDaily_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.datePickerMonthly);
            this.panel2.Controls.Add(this.btnReportMonthly);
            this.panel2.Controls.Add(this.btnGetMonthlyIncome);
            this.panel2.Controls.Add(this.btnDownloadMonthly);
            this.panel2.Controls.Add(this.lblIncomeMonthly);
            this.panel2.Controls.Add(this.lblExpenseMonthly);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(25, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 344);
            this.panel2.TabIndex = 6;
            // 
            // datePickerMonthly
            // 
            this.datePickerMonthly.Location = new System.Drawing.Point(408, 26);
            this.datePickerMonthly.Name = "datePickerMonthly";
            this.datePickerMonthly.Size = new System.Drawing.Size(200, 22);
            this.datePickerMonthly.TabIndex = 8;
            // 
            // btnReportMonthly
            // 
            this.btnReportMonthly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportMonthly.BackgroundImage")));
            this.btnReportMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMonthly.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReportMonthly.Location = new System.Drawing.Point(13, 235);
            this.btnReportMonthly.Name = "btnReportMonthly";
            this.btnReportMonthly.Size = new System.Drawing.Size(315, 79);
            this.btnReportMonthly.TabIndex = 7;
            this.btnReportMonthly.Text = "Send Report";
            this.btnReportMonthly.UseVisualStyleBackColor = true;
            this.btnReportMonthly.Click += new System.EventHandler(this.btnReportMonthly_Click);
            // 
            // btnGetMonthlyIncome
            // 
            this.btnGetMonthlyIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetMonthlyIncome.BackgroundImage")));
            this.btnGetMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMonthlyIncome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetMonthlyIncome.Location = new System.Drawing.Point(13, 17);
            this.btnGetMonthlyIncome.Name = "btnGetMonthlyIncome";
            this.btnGetMonthlyIncome.Size = new System.Drawing.Size(315, 79);
            this.btnGetMonthlyIncome.TabIndex = 0;
            this.btnGetMonthlyIncome.Text = "GetMonthlyIncome";
            this.btnGetMonthlyIncome.UseVisualStyleBackColor = true;
            this.btnGetMonthlyIncome.Click += new System.EventHandler(this.btnGetMonthlyIncome_Click);
            // 
            // btnDownloadMonthly
            // 
            this.btnDownloadMonthly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownloadMonthly.BackgroundImage")));
            this.btnDownloadMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadMonthly.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDownloadMonthly.Location = new System.Drawing.Point(13, 128);
            this.btnDownloadMonthly.Name = "btnDownloadMonthly";
            this.btnDownloadMonthly.Size = new System.Drawing.Size(315, 79);
            this.btnDownloadMonthly.TabIndex = 6;
            this.btnDownloadMonthly.Text = "Download Monthly ";
            this.btnDownloadMonthly.UseVisualStyleBackColor = true;
            this.btnDownloadMonthly.Click += new System.EventHandler(this.btnDownloadMonthly_Click);
            // 
            // lblIncomeMonthly
            // 
            this.lblIncomeMonthly.AutoSize = true;
            this.lblIncomeMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeMonthly.Image = ((System.Drawing.Image)(resources.GetObject("lblIncomeMonthly.Image")));
            this.lblIncomeMonthly.Location = new System.Drawing.Point(713, 88);
            this.lblIncomeMonthly.Name = "lblIncomeMonthly";
            this.lblIncomeMonthly.Size = new System.Drawing.Size(42, 46);
            this.lblIncomeMonthly.TabIndex = 3;
            this.lblIncomeMonthly.Text = "0";
            // 
            // lblExpenseMonthly
            // 
            this.lblExpenseMonthly.AutoSize = true;
            this.lblExpenseMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseMonthly.Image = ((System.Drawing.Image)(resources.GetObject("lblExpenseMonthly.Image")));
            this.lblExpenseMonthly.Location = new System.Drawing.Point(713, 156);
            this.lblExpenseMonthly.Name = "lblExpenseMonthly";
            this.lblExpenseMonthly.Size = new System.Drawing.Size(42, 46);
            this.lblExpenseMonthly.TabIndex = 4;
            this.lblExpenseMonthly.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(402, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Income Monthly:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(402, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Expense Monthly:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.datePickerYearly);
            this.panel3.Controls.Add(this.btnReportYearly);
            this.panel3.Controls.Add(this.btnGetYearlyIncome);
            this.panel3.Controls.Add(this.btnDownloadYearly);
            this.panel3.Controls.Add(this.lblIncomeYearly);
            this.panel3.Controls.Add(this.lblExpenseYearly);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(25, 819);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 344);
            this.panel3.TabIndex = 9;
            // 
            // datePickerYearly
            // 
            this.datePickerYearly.Location = new System.Drawing.Point(408, 26);
            this.datePickerYearly.Name = "datePickerYearly";
            this.datePickerYearly.Size = new System.Drawing.Size(200, 22);
            this.datePickerYearly.TabIndex = 8;
            // 
            // btnReportYearly
            // 
            this.btnReportYearly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportYearly.BackgroundImage")));
            this.btnReportYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportYearly.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReportYearly.Location = new System.Drawing.Point(13, 235);
            this.btnReportYearly.Name = "btnReportYearly";
            this.btnReportYearly.Size = new System.Drawing.Size(315, 79);
            this.btnReportYearly.TabIndex = 7;
            this.btnReportYearly.Text = "Send Report";
            this.btnReportYearly.UseVisualStyleBackColor = true;
            this.btnReportYearly.Click += new System.EventHandler(this.btnReportYearly_Click);
            // 
            // btnGetYearlyIncome
            // 
            this.btnGetYearlyIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetYearlyIncome.BackgroundImage")));
            this.btnGetYearlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetYearlyIncome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetYearlyIncome.Location = new System.Drawing.Point(13, 17);
            this.btnGetYearlyIncome.Name = "btnGetYearlyIncome";
            this.btnGetYearlyIncome.Size = new System.Drawing.Size(315, 79);
            this.btnGetYearlyIncome.TabIndex = 0;
            this.btnGetYearlyIncome.Text = "GetYearlyIncome";
            this.btnGetYearlyIncome.UseVisualStyleBackColor = true;
            this.btnGetYearlyIncome.Click += new System.EventHandler(this.btnGetYearlyIncome_Click);
            // 
            // btnDownloadYearly
            // 
            this.btnDownloadYearly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownloadYearly.BackgroundImage")));
            this.btnDownloadYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadYearly.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDownloadYearly.Location = new System.Drawing.Point(13, 128);
            this.btnDownloadYearly.Name = "btnDownloadYearly";
            this.btnDownloadYearly.Size = new System.Drawing.Size(315, 79);
            this.btnDownloadYearly.TabIndex = 6;
            this.btnDownloadYearly.Text = "Download Yearly";
            this.btnDownloadYearly.UseVisualStyleBackColor = true;
            this.btnDownloadYearly.Click += new System.EventHandler(this.btnDownloadYearly_Click);
            // 
            // lblIncomeYearly
            // 
            this.lblIncomeYearly.AutoSize = true;
            this.lblIncomeYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeYearly.Image = ((System.Drawing.Image)(resources.GetObject("lblIncomeYearly.Image")));
            this.lblIncomeYearly.Location = new System.Drawing.Point(713, 88);
            this.lblIncomeYearly.Name = "lblIncomeYearly";
            this.lblIncomeYearly.Size = new System.Drawing.Size(42, 46);
            this.lblIncomeYearly.TabIndex = 3;
            this.lblIncomeYearly.Text = "0";
            // 
            // lblExpenseYearly
            // 
            this.lblExpenseYearly.AutoSize = true;
            this.lblExpenseYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseYearly.Image = ((System.Drawing.Image)(resources.GetObject("lblExpenseYearly.Image")));
            this.lblExpenseYearly.Location = new System.Drawing.Point(713, 156);
            this.lblExpenseYearly.Name = "lblExpenseYearly";
            this.lblExpenseYearly.Size = new System.Drawing.Size(42, 46);
            this.lblExpenseYearly.TabIndex = 4;
            this.lblExpenseYearly.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(402, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Income Yearly:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(402, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Expense Yearly:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 1221);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDailyIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDailyIncome;
        private System.Windows.Forms.Label lblDailyExpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDownloadDaily;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker datePickerMonthly;
        private System.Windows.Forms.Button btnReportMonthly;
        private System.Windows.Forms.Button btnGetMonthlyIncome;
        private System.Windows.Forms.Button btnDownloadMonthly;
        private System.Windows.Forms.Label lblIncomeMonthly;
        private System.Windows.Forms.Label lblExpenseMonthly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker datePickerYearly;
        private System.Windows.Forms.Button btnReportYearly;
        private System.Windows.Forms.Button btnGetYearlyIncome;
        private System.Windows.Forms.Button btnDownloadYearly;
        private System.Windows.Forms.Label lblIncomeYearly;
        private System.Windows.Forms.Label lblExpenseYearly;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}