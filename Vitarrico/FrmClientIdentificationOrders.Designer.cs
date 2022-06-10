namespace Vitarrico
{
    partial class FrmClientIdentificationOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientIdentificationOrders));
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblClienteIdentification = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gpbSeleccionarClient = new System.Windows.Forms.GroupBox();
            this.txtClientSelected = new System.Windows.Forms.TextBox();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.bttnRefrescar = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.pcbRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gpbSeleccionarClient.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(33, 195);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(698, 270);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // lblClienteIdentification
            // 
            this.lblClienteIdentification.AutoSize = true;
            this.lblClienteIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClienteIdentification.Location = new System.Drawing.Point(39, 25);
            this.lblClienteIdentification.Name = "lblClienteIdentification";
            this.lblClienteIdentification.Size = new System.Drawing.Size(196, 25);
            this.lblClienteIdentification.TabIndex = 1;
            this.lblClienteIdentification.Text = "Client Identification";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(217, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(246, 25);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 28);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "SELECT";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gpbSeleccionarClient
            // 
            this.gpbSeleccionarClient.Controls.Add(this.txtClientSelected);
            this.gpbSeleccionarClient.Controls.Add(this.btnSeleccionar);
            this.gpbSeleccionarClient.Location = new System.Drawing.Point(376, 75);
            this.gpbSeleccionarClient.Name = "gpbSeleccionarClient";
            this.gpbSeleccionarClient.Size = new System.Drawing.Size(358, 71);
            this.gpbSeleccionarClient.TabIndex = 11;
            this.gpbSeleccionarClient.TabStop = false;
            this.gpbSeleccionarClient.Text = "Select Client Identification ";
            // 
            // txtClientSelected
            // 
            this.txtClientSelected.Location = new System.Drawing.Point(24, 28);
            this.txtClientSelected.Name = "txtClientSelected";
            this.txtClientSelected.Size = new System.Drawing.Size(215, 22);
            this.txtClientSelected.TabIndex = 12;
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.bttnRefrescar);
            this.gpbBuscar.Controls.Add(this.bttnSearch);
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Location = new System.Drawing.Point(33, 75);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(337, 103);
            this.gpbBuscar.TabIndex = 13;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Search Client Identification ";
            // 
            // bttnRefrescar
            // 
            this.bttnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnRefrescar.Location = new System.Drawing.Point(208, 60);
            this.bttnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnRefrescar.Name = "bttnRefrescar";
            this.bttnRefrescar.Size = new System.Drawing.Size(122, 25);
            this.bttnRefrescar.TabIndex = 15;
            this.bttnRefrescar.Text = "REFRESH";
            this.bttnRefrescar.UseVisualStyleBackColor = true;
            this.bttnRefrescar.Click += new System.EventHandler(this.bttnRefrescar_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSearch.Location = new System.Drawing.Point(235, 27);
            this.bttnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(95, 25);
            this.bttnSearch.TabIndex = 13;
            this.bttnSearch.Text = "SEARCH";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // pcbRegresar
            // 
            this.pcbRegresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pcbRegresar.Image")));
            this.pcbRegresar.Location = new System.Drawing.Point(696, 12);
            this.pcbRegresar.Name = "pcbRegresar";
            this.pcbRegresar.Size = new System.Drawing.Size(38, 38);
            this.pcbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRegresar.TabIndex = 14;
            this.pcbRegresar.TabStop = false;
            this.pcbRegresar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmClientIdentificationOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(772, 498);
            this.Controls.Add(this.pcbRegresar);
            this.Controls.Add(this.gpbBuscar);
            this.Controls.Add(this.gpbSeleccionarClient);
            this.Controls.Add(this.lblClienteIdentification);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientIdentificationOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientIdentificationOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gpbSeleccionarClient.ResumeLayout(false);
            this.gpbSeleccionarClient.PerformLayout();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblClienteIdentification;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox gpbSeleccionarClient;
        private System.Windows.Forms.TextBox txtClientSelected;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.PictureBox pcbRegresar;
        private System.Windows.Forms.Button bttnRefrescar;
    }
}