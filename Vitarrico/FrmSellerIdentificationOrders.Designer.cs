namespace Vitarrico
{
    partial class FrmSellerIdentificationOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSellerIdentificationOrders));
            this.pcbRegresar = new System.Windows.Forms.PictureBox();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.bttnRefrescar = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gpbSeleccionarSeller = new System.Windows.Forms.GroupBox();
            this.txtSellerSelected = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblVendedorIdentification = new System.Windows.Forms.Label();
            this.dgvSellers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegresar)).BeginInit();
            this.gpbBuscar.SuspendLayout();
            this.gpbSeleccionarSeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbRegresar
            // 
            this.pcbRegresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pcbRegresar.Image")));
            this.pcbRegresar.Location = new System.Drawing.Point(699, 23);
            this.pcbRegresar.Name = "pcbRegresar";
            this.pcbRegresar.Size = new System.Drawing.Size(38, 38);
            this.pcbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRegresar.TabIndex = 19;
            this.pcbRegresar.TabStop = false;
            this.pcbRegresar.Click += new System.EventHandler(this.pcbRegresar_Click);
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.bttnRefrescar);
            this.gpbBuscar.Controls.Add(this.bttnSearch);
            this.gpbBuscar.Controls.Add(this.txtBuscar);
            this.gpbBuscar.Location = new System.Drawing.Point(36, 86);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(337, 100);
            this.gpbBuscar.TabIndex = 18;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Search Seller Identification ";
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
            this.bttnRefrescar.TabIndex = 14;
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(217, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // gpbSeleccionarSeller
            // 
            this.gpbSeleccionarSeller.Controls.Add(this.txtSellerSelected);
            this.gpbSeleccionarSeller.Controls.Add(this.btnSeleccionar);
            this.gpbSeleccionarSeller.Location = new System.Drawing.Point(379, 86);
            this.gpbSeleccionarSeller.Name = "gpbSeleccionarSeller";
            this.gpbSeleccionarSeller.Size = new System.Drawing.Size(358, 71);
            this.gpbSeleccionarSeller.TabIndex = 17;
            this.gpbSeleccionarSeller.TabStop = false;
            this.gpbSeleccionarSeller.Text = "Select Seller Identification ";
            // 
            // txtSellerSelected
            // 
            this.txtSellerSelected.Location = new System.Drawing.Point(24, 28);
            this.txtSellerSelected.Name = "txtSellerSelected";
            this.txtSellerSelected.Size = new System.Drawing.Size(215, 22);
            this.txtSellerSelected.TabIndex = 12;
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
            // lblVendedorIdentification
            // 
            this.lblVendedorIdentification.AutoSize = true;
            this.lblVendedorIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVendedorIdentification.Location = new System.Drawing.Point(42, 36);
            this.lblVendedorIdentification.Name = "lblVendedorIdentification";
            this.lblVendedorIdentification.Size = new System.Drawing.Size(196, 25);
            this.lblVendedorIdentification.TabIndex = 16;
            this.lblVendedorIdentification.Text = "Seller Identification";
            // 
            // dgvSellers
            // 
            this.dgvSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellers.Location = new System.Drawing.Point(36, 192);
            this.dgvSellers.MultiSelect = false;
            this.dgvSellers.Name = "dgvSellers";
            this.dgvSellers.ReadOnly = true;
            this.dgvSellers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSellers.RowHeadersWidth = 51;
            this.dgvSellers.RowTemplate.Height = 24;
            this.dgvSellers.Size = new System.Drawing.Size(698, 284);
            this.dgvSellers.TabIndex = 15;
            this.dgvSellers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellers_CellContentClick);
            // 
            // FrmSellerIdentificationOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(772, 498);
            this.Controls.Add(this.pcbRegresar);
            this.Controls.Add(this.gpbBuscar);
            this.Controls.Add(this.gpbSeleccionarSeller);
            this.Controls.Add(this.lblVendedorIdentification);
            this.Controls.Add(this.dgvSellers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSellerIdentificationOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSellerIdentificationOrders";
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegresar)).EndInit();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            this.gpbSeleccionarSeller.ResumeLayout(false);
            this.gpbSeleccionarSeller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbRegresar;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gpbSeleccionarSeller;
        private System.Windows.Forms.TextBox txtSellerSelected;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblVendedorIdentification;
        private System.Windows.Forms.DataGridView dgvSellers;
        private System.Windows.Forms.Button bttnRefrescar;
    }
}