﻿namespace Vitarrico
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.winemaker1 = new Vitarrico.Winemaker();
            this.sellers1 = new Vitarrico.Sellers();
            this.administrator1 = new Vitarrico.Administrator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Controls.Add(this.winemaker1);
            this.panel1.Controls.Add(this.sellers1);
            this.panel1.Controls.Add(this.administrator1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 71);
            this.panel1.TabIndex = 0;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.BackColor = System.Drawing.Color.Firebrick;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.Transparent;
            this.lblNameUser.Location = new System.Drawing.Point(873, 18);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(57, 25);
            this.lblNameUser.TabIndex = 11;
            this.lblNameUser.Text = "User";
            // 
            // winemaker1
            // 
            this.winemaker1.Location = new System.Drawing.Point(132, 16);
            this.winemaker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winemaker1.Name = "winemaker1";
            this.winemaker1.Size = new System.Drawing.Size(344, 27);
            this.winemaker1.TabIndex = 10;
            // 
            // sellers1
            // 
            this.sellers1.Location = new System.Drawing.Point(132, 16);
            this.sellers1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellers1.Name = "sellers1";
            this.sellers1.Size = new System.Drawing.Size(315, 28);
            this.sellers1.TabIndex = 9;
            // 
            // administrator1
            // 
            this.administrator1.Location = new System.Drawing.Point(120, 14);
            this.administrator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.administrator1.Name = "administrator1";
            this.administrator1.Size = new System.Drawing.Size(372, 31);
            this.administrator1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 690);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VITARRICO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Administrator administrator1;
        private Winemaker winemaker1;
        private Sellers sellers1;
        private System.Windows.Forms.Label lblNameUser;
    }
}

