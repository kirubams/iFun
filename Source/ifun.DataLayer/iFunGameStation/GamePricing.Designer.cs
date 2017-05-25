namespace iFunGameStation
{
    partial class GamePricing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePricing));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgPricingview = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIndividualPrice = new System.Windows.Forms.TextBox();
            this.lblIndividualPrice = new System.Windows.Forms.Label();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.lblMins = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.ddlPlayerNo = new System.Windows.Forms.ComboBox();
            this.ddlsystemName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPricingview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.dgPricingview);
            this.panel2.Location = new System.Drawing.Point(29, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 404);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // dgPricingview
            // 
            this.dgPricingview.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgPricingview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPricingview.Location = new System.Drawing.Point(22, 29);
            this.dgPricingview.Name = "dgPricingview";
            this.dgPricingview.RowTemplate.Height = 24;
            this.dgPricingview.Size = new System.Drawing.Size(738, 343);
            this.dgPricingview.TabIndex = 0;
            this.dgPricingview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPricingview_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtIndividualPrice);
            this.panel1.Controls.Add(this.lblIndividualPrice);
            this.panel1.Controls.Add(this.txtMins);
            this.panel1.Controls.Add(this.lblMins);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.ddlPlayerNo);
            this.panel1.Controls.Add(this.ddlsystemName);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblSystemName);
            this.panel1.Location = new System.Drawing.Point(29, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 309);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIndividualPrice
            // 
            this.txtIndividualPrice.Location = new System.Drawing.Point(488, 189);
            this.txtIndividualPrice.Name = "txtIndividualPrice";
            this.txtIndividualPrice.Size = new System.Drawing.Size(272, 22);
            this.txtIndividualPrice.TabIndex = 13;
            this.txtIndividualPrice.TextChanged += new System.EventHandler(this.txtIndividualPrice_TextChanged);
            // 
            // lblIndividualPrice
            // 
            this.lblIndividualPrice.AutoSize = true;
            this.lblIndividualPrice.Location = new System.Drawing.Point(333, 194);
            this.lblIndividualPrice.Name = "lblIndividualPrice";
            this.lblIndividualPrice.Size = new System.Drawing.Size(107, 17);
            this.lblIndividualPrice.TabIndex = 12;
            this.lblIndividualPrice.Text = "Individual Price:";
            this.lblIndividualPrice.Click += new System.EventHandler(this.lblIndividualPrice_Click);
            // 
            // txtMins
            // 
            this.txtMins.Location = new System.Drawing.Point(488, 147);
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(272, 22);
            this.txtMins.TabIndex = 11;
            this.txtMins.TextChanged += new System.EventHandler(this.txtMins_TextChanged);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(379, 152);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(61, 17);
            this.lblMins.TabIndex = 10;
            this.lblMins.Text = "Minutes:";
            this.lblMins.Click += new System.EventHandler(this.lblMins_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(488, 105);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(272, 22);
            this.txtprice.TabIndex = 9;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(396, 111);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // ddlPlayerNo
            // 
            this.ddlPlayerNo.FormattingEnabled = true;
            this.ddlPlayerNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ddlPlayerNo.Location = new System.Drawing.Point(488, 62);
            this.ddlPlayerNo.Name = "ddlPlayerNo";
            this.ddlPlayerNo.Size = new System.Drawing.Size(272, 24);
            this.ddlPlayerNo.TabIndex = 7;
            this.ddlPlayerNo.SelectedIndexChanged += new System.EventHandler(this.ddlPlayerNo_SelectedIndexChanged);
            // 
            // ddlsystemName
            // 
            this.ddlsystemName.FormattingEnabled = true;
            this.ddlsystemName.Location = new System.Drawing.Point(488, 20);
            this.ddlsystemName.Name = "ddlsystemName";
            this.ddlsystemName.Size = new System.Drawing.Size(272, 24);
            this.ddlsystemName.TabIndex = 6;
            this.ddlsystemName.SelectedIndexChanged += new System.EventHandler(this.ddlsystemName_SelectedIndexChanged);
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
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(334, 69);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(106, 17);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Player Number:";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Location = new System.Drawing.Point(299, 29);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(141, 17);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Game System Name:";
            this.lblSystemName.Click += new System.EventHandler(this.lblSystemName_Click);
            // 
            // GamePricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GamePricing";
            this.Text = "GamePricing";
            this.Load += new System.EventHandler(this.GamePricing_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPricingview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgPricingview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.TextBox txtIndividualPrice;
        private System.Windows.Forms.Label lblIndividualPrice;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox ddlPlayerNo;
        private System.Windows.Forms.ComboBox ddlsystemName;
    }
}