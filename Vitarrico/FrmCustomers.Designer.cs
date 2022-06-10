namespace Vitarrico
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxCustomersDate = new System.Windows.Forms.GroupBox();
            this.cbTypeDocument = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNameOrBusinessName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdentificationOrNit = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTypeDocument = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNameOrBusinessName = new System.Windows.Forms.Label();
            this.lblIdenticationOrNit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.gbxCustomersDate.SuspendLayout();
            this.gbxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 543);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(456, 543);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxCustomersDate
            // 
            this.gbxCustomersDate.Controls.Add(this.cbTypeDocument);
            this.gbxCustomersDate.Controls.Add(this.txtEmail);
            this.gbxCustomersDate.Controls.Add(this.txtNameOrBusinessName);
            this.gbxCustomersDate.Controls.Add(this.txtPhone);
            this.gbxCustomersDate.Controls.Add(this.txtAddress);
            this.gbxCustomersDate.Controls.Add(this.txtLastName);
            this.gbxCustomersDate.Controls.Add(this.txtIdentificationOrNit);
            this.gbxCustomersDate.Controls.Add(this.lblAddress);
            this.gbxCustomersDate.Controls.Add(this.lblPhone);
            this.gbxCustomersDate.Controls.Add(this.lblTypeDocument);
            this.gbxCustomersDate.Controls.Add(this.lblEmail);
            this.gbxCustomersDate.Controls.Add(this.lblLastName);
            this.gbxCustomersDate.Controls.Add(this.lblNameOrBusinessName);
            this.gbxCustomersDate.Controls.Add(this.lblIdenticationOrNit);
            this.gbxCustomersDate.Location = new System.Drawing.Point(12, 106);
            this.gbxCustomersDate.Name = "gbxCustomersDate";
            this.gbxCustomersDate.Size = new System.Drawing.Size(541, 430);
            this.gbxCustomersDate.TabIndex = 50;
            this.gbxCustomersDate.TabStop = false;
            this.gbxCustomersDate.Text = "Custormers date";
            // 
            // cbTypeDocument
            // 
            this.cbTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbTypeDocument.FormattingEnabled = true;
            this.cbTypeDocument.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.cbTypeDocument.Location = new System.Drawing.Point(336, 62);
            this.cbTypeDocument.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeDocument.Name = "cbTypeDocument";
            this.cbTypeDocument.Size = new System.Drawing.Size(198, 24);
            this.cbTypeDocument.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(336, 262);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 22);
            this.txtEmail.TabIndex = 53;
            // 
            // txtNameOrBusinessName
            // 
            this.txtNameOrBusinessName.Location = new System.Drawing.Point(336, 169);
            this.txtNameOrBusinessName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameOrBusinessName.Name = "txtNameOrBusinessName";
            this.txtNameOrBusinessName.Size = new System.Drawing.Size(199, 22);
            this.txtNameOrBusinessName.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(336, 347);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 22);
            this.txtPhone.TabIndex = 51;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(335, 305);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 22);
            this.txtAddress.TabIndex = 50;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(336, 218);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 22);
            this.txtLastName.TabIndex = 49;
            // 
            // txtIdentificationOrNit
            // 
            this.txtIdentificationOrNit.Location = new System.Drawing.Point(336, 113);
            this.txtIdentificationOrNit.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificationOrNit.Name = "txtIdentificationOrNit";
            this.txtIdentificationOrNit.Size = new System.Drawing.Size(199, 22);
            this.txtIdentificationOrNit.TabIndex = 38;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(5, 301);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 25);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "ADDRESS";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(6, 347);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 25);
            this.lblPhone.TabIndex = 41;
            this.lblPhone.Text = "PHONE";
            // 
            // lblTypeDocument
            // 
            this.lblTypeDocument.AutoSize = true;
            this.lblTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeDocument.Location = new System.Drawing.Point(6, 61);
            this.lblTypeDocument.Name = "lblTypeDocument";
            this.lblTypeDocument.Size = new System.Drawing.Size(198, 25);
            this.lblTypeDocument.TabIndex = 31;
            this.lblTypeDocument.Text = "TYPE DOCUMENT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(5, 259);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 25);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(6, 218);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(136, 25);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "LAST NAME";
            // 
            // lblNameOrBusinessName
            // 
            this.lblNameOrBusinessName.AutoSize = true;
            this.lblNameOrBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNameOrBusinessName.Location = new System.Drawing.Point(6, 169);
            this.lblNameOrBusinessName.Name = "lblNameOrBusinessName";
            this.lblNameOrBusinessName.Size = new System.Drawing.Size(294, 25);
            this.lblNameOrBusinessName.TabIndex = 34;
            this.lblNameOrBusinessName.Text = "NAME OR BUSINESS NAME";
            // 
            // lblIdenticationOrNit
            // 
            this.lblIdenticationOrNit.AutoSize = true;
            this.lblIdenticationOrNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdenticationOrNit.Location = new System.Drawing.Point(6, 113);
            this.lblIdenticationOrNit.Name = "lblIdenticationOrNit";
            this.lblIdenticationOrNit.Size = new System.Drawing.Size(262, 25);
            this.lblIdenticationOrNit.TabIndex = 35;
            this.lblIdenticationOrNit.Text = "IDENTIFICATION OR NIT";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 543);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.dgvCustomers);
            this.gbxCustomers.Location = new System.Drawing.Point(559, 106);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Size = new System.Drawing.Size(562, 430);
            this.gbxCustomers.TabIndex = 46;
            this.gbxCustomers.TabStop = false;
            this.gbxCustomers.Text = "Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(15, 35);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(545, 376);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 677);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxCustomersDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomers";
            this.gbxCustomersDate.ResumeLayout(false);
            this.gbxCustomersDate.PerformLayout();
            this.gbxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxCustomersDate;
        private System.Windows.Forms.ComboBox cbTypeDocument;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNameOrBusinessName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdentificationOrNit;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTypeDocument;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNameOrBusinessName;
        private System.Windows.Forms.Label lblIdenticationOrNit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}