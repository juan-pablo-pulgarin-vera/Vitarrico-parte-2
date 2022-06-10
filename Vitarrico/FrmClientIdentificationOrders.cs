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
    public partial class FrmClientIdentificationOrders : Form
    {

        #region CONEXION BD

        ConexionSQLServer conexion = new ConexionSQLServer();

        #endregion

        #region PROPIEDADES

        private DataTable adpCustomers;

        public string IdentificationCustomer{get; set;}

        #endregion

        #region CONSTRUCTOR
        public FrmClientIdentificationOrders()
        {
            InitializeComponent();
            showDataGridView();
        }

        #endregion

        #region MÉTODOS

        private void showDataGridView()
        {
            SqlCommand comand;
            string sql = @"SELECT * FROM tblCustumer";
            comand = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adpCustomers = dt;
            dgvCustomers.DataSource = dt;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.Columns[0].HeaderText = "TypeDocument";
            dgvCustomers.Columns[1].HeaderText = "IdentificationOrNit";
            dgvCustomers.Columns[2].HeaderText = "NameOrBusinessName";
            dgvCustomers.Columns[3].HeaderText = "LastName";
            dgvCustomers.Columns[4].HeaderText = "Email";
            dgvCustomers.Columns[5].HeaderText = "Address";
            dgvCustomers.Columns[6].HeaderText = "Phone";
        }

        #endregion

        #region EVENTOS

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand comand;
            string sql = @"SELECT * FROM tblCustumer WHERE IdentificationOrNit= " + txtBuscar.Text + "";
            comand = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adpCustomers = dt;
            dgvCustomers.DataSource = dt;
        }

        #endregion

        private void bttnRefrescar_Click(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            IdentificationCustomer = txtClientSelected.Text;
            this.Close();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClientSelected.Text = dgvCustomers.CurrentRow.Cells["IdentificationOrNit"].Value.ToString();
        }
    }
}
