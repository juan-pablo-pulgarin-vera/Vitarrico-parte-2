namespace Vitarrico
{
    partial class FrmSellers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellers));
            this.gbxSellers = new System.Windows.Forms.GroupBox();
            this.dgvSellers = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxSellersDate = new System.Windows.Forms.GroupBox();
            this.cbTypeDocument = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTypeDocument = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIdentication = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxSellers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).BeginInit();
            this.gbxSellersDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSellers
            // 
            this.gbxSellers.Controls.Add(this.dgvSellers);
            this.gbxSellers.Location = new System.Drawing.Point(557, 116);
            this.gbxSellers.Name = "gbxSellers";
            this.gbxSellers.Size = new System.Drawing.Size(562, 430);
            this.gbxSellers.TabIndex = 41;
            this.gbxSellers.TabStop = false;
            this.gbxSellers.Text = "Sellers";
            // 
            // dgvSellers
            // 
            this.dgvSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellers.Location = new System.Drawing.Point(15, 40);
            this.dgvSellers.Name = "dgvSellers";
            this.dgvSellers.RowHeadersWidth = 51;
            this.dgvSellers.RowTemplate.Height = 24;
            this.dgvSellers.Size = new System.Drawing.Size(545, 371);
            this.dgvSellers.TabIndex = 0;
            this.dgvSellers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellers_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(346, 553);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(454, 553);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxSellersDate
            // 
            this.gbxSellersDate.Controls.Add(this.cbTypeDocument);
            this.gbxSellersDate.Controls.Add(this.txtEmail);
            this.gbxSellersDate.Controls.Add(this.txtName);
            this.gbxSellersDate.Controls.Add(this.txtPhone);
            this.gbxSellersDate.Controls.Add(this.txtAddress);
            this.gbxSellersDate.Controls.Add(this.txtLastName);
            this.gbxSellersDate.Controls.Add(this.txtIdentification);
            this.gbxSellersDate.Controls.Add(this.lblAddress);
            this.gbxSellersDate.Controls.Add(this.lblPhone);
            this.gbxSellersDate.Controls.Add(this.lblTypeDocument);
            this.gbxSellersDate.Controls.Add(this.lblEmail);
            this.gbxSellersDate.Controls.Add(this.lblLastName);
            this.gbxSellersDate.Controls.Add(this.lblName);
            this.gbxSellersDate.Controls.Add(this.lblIdentication);
            this.gbxSellersDate.Location = new System.Drawing.Point(22, 116);
            this.gbxSellersDate.Name = "gbxSellersDate";
            this.gbxSellersDate.Size = new System.Drawing.Size(529, 430);
            this.gbxSellersDate.TabIndex = 45;
            this.gbxSellersDate.TabStop = false;
            this.gbxSellersDate.Text = "Sellers date";
            // 
            // cbTypeDocument
            // 
            this.cbTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbTypeDocument.FormattingEnabled = true;
            this.cbTypeDocument.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.cbTypeDocument.Location = new System.Drawing.Point(253, 41);
            this.cbTypeDocument.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeDocument.Name = "cbTypeDocument";
            this.cbTypeDocument.Size = new System.Drawing.Size(225, 24);
            this.cbTypeDocument.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(254, 286);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 22);
            this.txtEmail.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 148);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 22);
            this.txtName.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(253, 332);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 22);
            this.txtPhone.TabIndex = 51;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(253, 242);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 22);
            this.txtAddress.TabIndex = 50;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(253, 197);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(226, 22);
            this.txtLastName.TabIndex = 49;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(253, 92);
            this.txtIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(226, 22);
            this.txtIdentification.TabIndex = 38;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(11, 239);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 25);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "ADDRESS";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(11, 333);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 25);
            this.lblPhone.TabIndex = 41;
            this.lblPhone.Text = "PHONE";
            // 
            // lblTypeDocument
            // 
            this.lblTypeDocument.AutoSize = true;
            this.lblTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeDocument.Location = new System.Drawing.Point(11, 41);
            this.lblTypeDocument.Name = "lblTypeDocument";
            this.lblTypeDocument.Size = new System.Drawing.Size(198, 25);
            this.lblTypeDocument.TabIndex = 31;
            this.lblTypeDocument.Text = "TYPE DOCUMENT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(11, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 25);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(11, 198);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(136, 25);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "LAST NAME";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(11, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "NAME";
            // 
            // lblIdentication
            // 
            this.lblIdentication.AutoSize = true;
            this.lblIdentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdentication.Location = new System.Drawing.Point(11, 93);
            this.lblIdentication.Name = "lblIdentication";
            this.lblIdentication.Size = new System.Drawing.Size(184, 25);
            this.lblIdentication.TabIndex = 35;
            this.lblIdentication.Text = "IDENTIFICATION";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 553);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 677);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxSellersDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxSellers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSellers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbxSellers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).EndInit();
            this.gbxSellersDate.ResumeLayout(false);
            this.gbxSellersDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxSellers;
        private System.Windows.Forms.DataGridView dgvSellers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxSellersDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTypeDocument;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdentication;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbTypeDocument;
    }
}