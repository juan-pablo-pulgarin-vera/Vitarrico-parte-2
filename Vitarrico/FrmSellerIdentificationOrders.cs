using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vitarrico
{
    public partial class FrmSellerIdentificationOrders : Form
    {
        #region CONEXIÓN BD

        ConexionSQLServer conexion = new ConexionSQLServer();

        #endregion

        #region PROPIEDADES

        private DataTable adpSellers;

        public string IdentificationSeller { get; set; }

        #endregion

        #region CONSTRUCTOR
        public FrmSellerIdentificationOrders()
        {
            InitializeComponent();
            showDataGridView();
        }

        #endregion

        #region MÉTODOS

        private void showDataGridView()
        {
            SqlCommand comand;
            string sql = @"SELECT * FROM tblsellers";
            comand = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adpSellers = dt;
            dgvSellers.DataSource = dt;
            dgvSellers.RowHeadersVisible = false;
            dgvSellers.Columns[0].HeaderText = "TypeDocument";
            dgvSellers.Columns[1].HeaderText = "Identification";
            dgvSellers.Columns[2].HeaderText = "Name";
            dgvSellers.Columns[3].HeaderText = "LastName";
            dgvSellers.Columns[4].HeaderText = "Address";
            dgvSellers.Columns[5].HeaderText = "Email";
            dgvSellers.Columns[6].HeaderText = "Phone";
        }

        #endregion

        #region EVENTOS
        private void pcbRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand comand;
            string sql = @"SELECT * FROM tblsellers WHERE Identification= " + txtBuscar.Text + "";
            comand = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adpSellers = dt;
            dgvSellers.DataSource = dt;
        }

        private void bttnRefrescar_Click(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void dgvSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerSelected.Text = dgvSellers.CurrentRow.Cells["Identification"].Value.ToString();

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            IdentificationSeller = txtSellerSelected.Text;
            this.Close();
        }
    }
}
