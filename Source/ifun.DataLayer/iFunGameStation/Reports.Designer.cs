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
            this.btnGetDailyIncome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDailyIncome = new System.Windows.Forms.Label();
            this.lblDailyExpense = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDownloadDaily = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDailyIncome
            // 
            this.btnGetDailyIncome.Location = new System.Drawing.Point(76, 88);
            this.btnGetDailyIncome.Name = "btnGetDailyIncome";
            this.btnGetDailyIncome.Size = new System.Drawing.Size(259, 79);
            this.btnGetDailyIncome.TabIndex = 0;
            this.btnGetDailyIncome.Text = "GetDailyIncome";
            this.btnGetDailyIncome.UseVisualStyleBackColor = true;
            this.btnGetDailyIncome.Click += new System.EventHandler(this.btnGetDailyIncome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income For Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ExpenseForToday:";
            // 
            // lblDailyIncome
            // 
            this.lblDailyIncome.AutoSize = true;
            this.lblDailyIncome.Location = new System.Drawing.Point(531, 54);
            this.lblDailyIncome.Name = "lblDailyIncome";
            this.lblDailyIncome.Size = new System.Drawing.Size(16, 17);
            this.lblDailyIncome.TabIndex = 3;
            this.lblDailyIncome.Text = "0";
            // 
            // lblDailyExpense
            // 
            this.lblDailyExpense.AutoSize = true;
            this.lblDailyExpense.Location = new System.Drawing.Point(531, 116);
            this.lblDailyExpense.Name = "lblDailyExpense";
            this.lblDailyExpense.Size = new System.Drawing.Size(16, 17);
            this.lblDailyExpense.TabIndex = 4;
            this.lblDailyExpense.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDownloadDaily);
            this.panel1.Controls.Add(this.lblDailyIncome);
            this.panel1.Controls.Add(this.lblDailyExpense);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 210);
            this.panel1.TabIndex = 5;
            // 
            // btnDownloadDaily
            // 
            this.btnDownloadDaily.Location = new System.Drawing.Point(602, 54);
            this.btnDownloadDaily.Name = "btnDownloadDaily";
            this.btnDownloadDaily.Size = new System.Drawing.Size(259, 79);
            this.btnDownloadDaily.TabIndex = 6;
            this.btnDownloadDaily.Text = "Download";
            this.btnDownloadDaily.UseVisualStyleBackColor = true;
            this.btnDownloadDaily.Click += new System.EventHandler(this.btnDownloadDaily_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 683);
            this.Controls.Add(this.btnGetDailyIncome);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}