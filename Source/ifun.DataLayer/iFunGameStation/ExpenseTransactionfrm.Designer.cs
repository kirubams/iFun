namespace iFunGameStation
{
    partial class ExpenseTransactionfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseTransactionfrm));
            this.ddlExpenseName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgExpenseTransactionView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseTransactionView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlExpenseName
            // 
            this.ddlExpenseName.FormattingEnabled = true;
            this.ddlExpenseName.Location = new System.Drawing.Point(334, 13);
            this.ddlExpenseName.Name = "ddlExpenseName";
            this.ddlExpenseName.Size = new System.Drawing.Size(272, 24);
            this.ddlExpenseName.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(512, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(281, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(117, 20);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(103, 17);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "Expense Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(779, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(779, 141);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 40);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgExpenseTransactionView
            // 
            this.dgExpenseTransactionView.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgExpenseTransactionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExpenseTransactionView.Location = new System.Drawing.Point(22, 29);
            this.dgExpenseTransactionView.Name = "dgExpenseTransactionView";
            this.dgExpenseTransactionView.RowTemplate.Height = 24;
            this.dgExpenseTransactionView.Size = new System.Drawing.Size(738, 343);
            this.dgExpenseTransactionView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.dgExpenseTransactionView);
            this.panel2.Location = new System.Drawing.Point(29, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 404);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtComments);
            this.panel1.Controls.Add(this.lblComments);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.ddlExpenseName);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblExpenseName);
            this.panel1.Location = new System.Drawing.Point(29, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 309);
            this.panel1.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(164, 58);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(334, 53);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(272, 22);
            this.txtAmount.TabIndex = 8;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(146, 105);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(74, 17);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(334, 105);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(513, 111);
            this.txtComments.TabIndex = 10;
            // 
            // ExpenseTransactionfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ExpenseTransactionfrm";
            this.Text = "ExpenseTransactionfrm";
            this.Load += new System.EventHandler(this.ExpenseTransactionfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseTransactionView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ddlExpenseName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgExpenseTransactionView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtComments;
    }
}