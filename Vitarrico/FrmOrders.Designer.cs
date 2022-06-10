namespace Vitarrico
{
    partial class FrmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxOrdersDate = new System.Windows.Forms.GroupBox();
            this.pbIdentificationSeller = new System.Windows.Forms.PictureBox();
            this.pbIdentificationCustomer = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpDateAndHour = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtClientIdentification = new System.Windows.Forms.TextBox();
            this.txtUnitValue = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSellerIdentification = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitValue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblClientIdentification = new System.Windows.Forms.Label();
            this.lblDateAndHour = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.gbxOrdersDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentificationSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentificationCustomer)).BeginInit();
            this.gbxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(348, 543);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(456, 543);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxOrdersDate
            // 
            this.gbxOrdersDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOrdersDate.Controls.Add(this.pbIdentificationSeller);
            this.gbxOrdersDate.Controls.Add(this.pbIdentificationCustomer);
            this.gbxOrdersDate.Controls.Add(this.txtTotal);
            this.gbxOrdersDate.Controls.Add(this.lblTotal);
            this.gbxOrdersDate.Controls.Add(this.dtpDateAndHour);
            this.gbxOrdersDate.Controls.Add(this.txtAmount);
            this.gbxOrdersDate.Controls.Add(this.txtClientIdentification);
            this.gbxOrdersDate.Controls.Add(this.txtUnitValue);
            this.gbxOrdersDate.Controls.Add(this.txtProductName);
            this.gbxOrdersDate.Controls.Add(this.txtSellerIdentification);
            this.gbxOrdersDate.Controls.Add(this.lblProductName);
            this.gbxOrdersDate.Controls.Add(this.lblUnitValue);
            this.gbxOrdersDate.Controls.Add(this.lblAmount);
            this.gbxOrdersDate.Controls.Add(this.lblLastName);
            this.gbxOrdersDate.Controls.Add(this.lblClientIdentification);
            this.gbxOrdersDate.Controls.Add(this.lblDateAndHour);
            this.gbxOrdersDate.Location = new System.Drawing.Point(24, 106);
            this.gbxOrdersDate.Name = "gbxOrdersDate";
            this.gbxOrdersDate.Size = new System.Drawing.Size(529, 430);
            this.gbxOrdersDate.TabIndex = 50;
            this.gbxOrdersDate.TabStop = false;
            this.gbxOrdersDate.Text = "Orders date";
            // 
            // pbIdentificationSeller
            // 
            this.pbIdentificationSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIdentificationSeller.Image = ((System.Drawing.Image)(resources.GetObject("pbIdentificationSeller.Image")));
            this.pbIdentificationSeller.Location = new System.Drawing.Point(477, 161);
            this.pbIdentificationSeller.Name = "pbIdentificationSeller";
            this.pbIdentificationSeller.Size = new System.Drawing.Size(35, 26);
            this.pbIdentificationSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIdentificationSeller.TabIndex = 57;
            this.pbIdentificationSeller.TabStop = false;
            this.pbIdentificationSeller.Click += new System.EventHandler(this.pbIdentificationSeller_Click);
            // 
            // pbIdentificationCustomer
            // 
            this.pbIdentificationCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIdentificationCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbIdentificationCustomer.Image")));
            this.pbIdentificationCustomer.Location = new System.Drawing.Point(477, 112);
            this.pbIdentificationCustomer.Name = "pbIdentificationCustomer";
            this.pbIdentificationCustomer.Size = new System.Drawing.Size(35, 26);
            this.pbIdentificationCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIdentificationCustomer.TabIndex = 56;
            this.pbIdentificationCustomer.TabStop = false;
            this.pbIdentificationCustomer.Click += new System.EventHandler(this.pbIdentificationCustomer_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(315, 336);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(198, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(6, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 25);
            this.lblTotal.TabIndex = 55;
            this.lblTotal.Text = "TOTAL";
            // 
            // dtpDateAndHour
            // 
            this.dtpDateAndHour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAndHour.Location = new System.Drawing.Point(315, 71);
            this.dtpDateAndHour.Name = "dtpDateAndHour";
            this.dtpDateAndHour.Size = new System.Drawing.Size(197, 22);
            this.dtpDateAndHour.TabIndex = 0;
            this.dtpDateAndHour.Value = new System.DateTime(2022, 5, 9, 9, 22, 47, 0);
            this.dtpDateAndHour.ValueChanged += new System.EventHandler(this.dtpDateAndHour_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(317, 250);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(198, 22);
            this.txtAmount.TabIndex = 4;
            // 
            // txtClientIdentification
            // 
            this.txtClientIdentification.Location = new System.Drawing.Point(316, 112);
            this.txtClientIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientIdentification.Name = "txtClientIdentification";
            this.txtClientIdentification.Size = new System.Drawing.Size(155, 22);
            this.txtClientIdentification.TabIndex = 1;
            // 
            // txtUnitValue
            // 
            this.txtUnitValue.Location = new System.Drawing.Point(316, 293);
            this.txtUnitValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitValue.Name = "txtUnitValue";
            this.txtUnitValue.Size = new System.Drawing.Size(198, 22);
            this.txtUnitValue.TabIndex = 5;
            this.txtUnitValue.Leave += new System.EventHandler(this.txtUnitValue_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(316, 206);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(198, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // txtSellerIdentification
            // 
            this.txtSellerIdentification.Location = new System.Drawing.Point(316, 161);
            this.txtSellerIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellerIdentification.Name = "txtSellerIdentification";
            this.txtSellerIdentification.Size = new System.Drawing.Size(155, 22);
            this.txtSellerIdentification.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(7, 203);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(185, 25);
            this.lblProductName.TabIndex = 43;
            this.lblProductName.Text = "PRODUCT NAME";
            // 
            // lblUnitValue
            // 
            this.lblUnitValue.AutoSize = true;
            this.lblUnitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnitValue.Location = new System.Drawing.Point(7, 294);
            this.lblUnitValue.Name = "lblUnitValue";
            this.lblUnitValue.Size = new System.Drawing.Size(139, 25);
            this.lblUnitValue.TabIndex = 41;
            this.lblUnitValue.Text = "UNIT VALUE";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(7, 248);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(106, 25);
            this.lblAmount.TabIndex = 32;
            this.lblAmount.Text = "AMOUNT";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(7, 162);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(271, 25);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "SELLER IDENTIFICATION";
            // 
            // lblClientIdentification
            // 
            this.lblClientIdentification.AutoSize = true;
            this.lblClientIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientIdentification.Location = new System.Drawing.Point(7, 113);
            this.lblClientIdentification.Name = "lblClientIdentification";
            this.lblClientIdentification.Size = new System.Drawing.Size(267, 25);
            this.lblClientIdentification.TabIndex = 34;
            this.lblClientIdentification.Text = "CLIENT IDENTIFICATION";
            // 
            // lblDateAndHour
            // 
            this.lblDateAndHour.AutoSize = true;
            this.lblDateAndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateAndHour.Location = new System.Drawing.Point(6, 71);
            this.lblDateAndHour.Name = "lblDateAndHour";
            this.lblDateAndHour.Size = new System.Drawing.Size(70, 25);
            this.lblDateAndHour.TabIndex = 35;
            this.lblDateAndHour.Text = "DATE";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(240, 543);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxOrders
            // 
            this.gbxOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOrders.Controls.Add(this.dgvOrders);
            this.gbxOrders.Location = new System.Drawing.Point(559, 106);
            this.gbxOrders.Name = "gbxOrders";
            this.gbxOrders.Size = new System.Drawing.Size(562, 430);
            this.gbxOrders.TabIndex = 46;
            this.gbxOrders.TabStop = false;
            this.gbxOrders.Text = "Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(15, 40);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(527, 371);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1145, 677);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxOrdersDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrders";
            this.gbxOrdersDate.ResumeLayout(false);
            this.gbxOrdersDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentificationSeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdentificationCustomer)).EndInit();
            this.gbxOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxOrdersDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtClientIdentification;
        private System.Windows.Forms.TextBox txtUnitValue;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSellerIdentification;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitValue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblClientIdentification;
        private System.Windows.Forms.Label lblDateAndHour;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DateTimePicker dtpDateAndHour;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pbIdentificationSeller;
        private System.Windows.Forms.PictureBox pbIdentificationCustomer;
    }
}