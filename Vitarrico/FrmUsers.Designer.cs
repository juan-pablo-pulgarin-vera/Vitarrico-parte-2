namespace Vitarrico
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.gbxUsers = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbxUsersDate = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.cbKindPerson = new System.Windows.Forms.ComboBox();
            this.cbTypeDocument = new System.Windows.Forms.ComboBox();
            this.lblKindOfPerson = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTypeDocument = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIdentication = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbxUsersDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.dgvUsers);
            this.gbxUsers.Location = new System.Drawing.Point(565, 86);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(538, 457);
            this.gbxUsers.TabIndex = 36;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(15, 21);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(504, 420);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // gbxUsersDate
            // 
            this.gbxUsersDate.Controls.Add(this.txtEmail);
            this.gbxUsersDate.Controls.Add(this.txtName);
            this.gbxUsersDate.Controls.Add(this.txtPhone);
            this.gbxUsersDate.Controls.Add(this.txtAddress);
            this.gbxUsersDate.Controls.Add(this.txtLastName);
            this.gbxUsersDate.Controls.Add(this.txtIdentification);
            this.gbxUsersDate.Controls.Add(this.cbKindPerson);
            this.gbxUsersDate.Controls.Add(this.cbTypeDocument);
            this.gbxUsersDate.Controls.Add(this.lblKindOfPerson);
            this.gbxUsersDate.Controls.Add(this.lblAddress);
            this.gbxUsersDate.Controls.Add(this.lblPhone);
            this.gbxUsersDate.Controls.Add(this.lblTypeDocument);
            this.gbxUsersDate.Controls.Add(this.lblEmail);
            this.gbxUsersDate.Controls.Add(this.lblLastName);
            this.gbxUsersDate.Controls.Add(this.lblName);
            this.gbxUsersDate.Controls.Add(this.lblIdentication);
            this.gbxUsersDate.Location = new System.Drawing.Point(30, 86);
            this.gbxUsersDate.Name = "gbxUsersDate";
            this.gbxUsersDate.Size = new System.Drawing.Size(529, 457);
            this.gbxUsersDate.TabIndex = 33;
            this.gbxUsersDate.TabStop = false;
            this.gbxUsersDate.Text = "Users date";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 242);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 22);
            this.txtEmail.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(273, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 22);
            this.txtName.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(273, 333);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 22);
            this.txtPhone.TabIndex = 51;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(273, 287);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 22);
            this.txtAddress.TabIndex = 50;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(273, 198);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(226, 22);
            this.txtLastName.TabIndex = 49;
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(273, 93);
            this.txtIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(226, 22);
            this.txtIdentification.TabIndex = 38;
            // 
            // cbKindPerson
            // 
            this.cbKindPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbKindPerson.FormattingEnabled = true;
            this.cbKindPerson.ItemHeight = 16;
            this.cbKindPerson.Items.AddRange(new object[] {
            "BODEGUERO",
            "ADMINISTRADOR",
            "VENDEDOR"});
            this.cbKindPerson.Location = new System.Drawing.Point(273, 376);
            this.cbKindPerson.Margin = new System.Windows.Forms.Padding(4);
            this.cbKindPerson.Name = "cbKindPerson";
            this.cbKindPerson.Size = new System.Drawing.Size(226, 24);
            this.cbKindPerson.TabIndex = 48;
            // 
            // cbTypeDocument
            // 
            this.cbTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbTypeDocument.FormattingEnabled = true;
            this.cbTypeDocument.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.cbTypeDocument.Location = new System.Drawing.Point(274, 41);
            this.cbTypeDocument.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeDocument.Name = "cbTypeDocument";
            this.cbTypeDocument.Size = new System.Drawing.Size(225, 24);
            this.cbTypeDocument.TabIndex = 47;
            // 
            // lblKindOfPerson
            // 
            this.lblKindOfPerson.AutoSize = true;
            this.lblKindOfPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblKindOfPerson.Location = new System.Drawing.Point(11, 376);
            this.lblKindOfPerson.Name = "lblKindOfPerson";
            this.lblKindOfPerson.Size = new System.Drawing.Size(194, 25);
            this.lblKindOfPerson.TabIndex = 45;
            this.lblKindOfPerson.Text = "KIND OF PERSON";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(11, 283);
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
            this.lblEmail.Location = new System.Drawing.Point(11, 242);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 550);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 550);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 550);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 677);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbxUsers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxUsersDate);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbxUsersDate.ResumeLayout(false);
            this.gbxUsersDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbxUsersDate;
        private System.Windows.Forms.ComboBox cbKindPerson;
        private System.Windows.Forms.ComboBox cbTypeDocument;
        private System.Windows.Forms.Label lblKindOfPerson;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTypeDocument;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdentication;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}