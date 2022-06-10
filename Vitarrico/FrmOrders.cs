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
    public partial class FrmOrders : Form
    {
        #region CONEXION BD

        ConexionSQLServer conexion = new ConexionSQLServer();

        #endregion

        #region PROPIEDADES

        private DataTable adpOrders;

        private DateTime fechaHora { get; set; }

        #endregion

        #region CONSTRUCTOR
        public FrmOrders()
        {
            InitializeComponent();
            showDataGridView();
            dtpDateAndHour.Value = DateTime.Now;
        }

        #endregion

        #region MÉTODOS
        private void showDataGridView()
        {
            SqlCommand comand;
            string sql = @"SELECT * FROM tblOrders";
            comand = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adpOrders = dt;
            dgvOrders.DataSource = dt;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.Columns[0].HeaderText = "Id";
            dgvOrders.Columns[1].HeaderText = "DateAndHour";
            dgvOrders.Columns[2].HeaderText = "ClientIdentification";
            dgvOrders.Columns[3].HeaderText = "SellerIdentification";
            dgvOrders.Columns[4].HeaderText = "ProductName";
            dgvOrders.Columns[5].HeaderText = "Amount";
            dgvOrders.Columns[6].HeaderText = "UnitValue";
            dgvOrders.Columns[7].HeaderText = "Total";
        }

        private void saveOrders()
        {
            try
            {
                SqlCommand comand;
                string sql = @"INSERT INTO tblOrders (DateAndHour, ClientIdentification, SellerIdentification, ProductName, Amount, UnitValue, Total) 
                                      VALUES (@dateAndHour, @clientIdentification, @sellerIdentification, @productName, @amount, @unitValue, @total)";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@dateAndHour", fechaHora);
                comand.Parameters.AddWithValue("@clientIdentification", txtClientIdentification.Text);
                comand.Parameters.AddWithValue("@sellerIdentification", txtSellerIdentification.Text);
                comand.Parameters.AddWithValue("@productName", txtProductName.Text);
                comand.Parameters.AddWithValue("@amount", txtAmount.Text);
                comand.Parameters.AddWithValue("@unitValue", txtUnitValue.Text);
                comand.Parameters.AddWithValue("@total", txtTotal.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("It has been successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                conexion.ConectarBD.Close();
                MessageBox.Show("An error has occurred. Try again" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateOrders()
        {
            try
            {
                SqlCommand comand;
                string sql = @"UPDATE tblOrders 
                            SET DateAndHour = @dateAndHour,
                                 SellerIdentification = @sellerIdentification, 
                                 ProductName = @productName, 
                                 Amount = @amount, 
                                 UnitValue = @unitValue, 
                                 Total = @total
                            WHERE ClientIdentification = @clientIdentification";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@dateAndHour", fechaHora);
                comand.Parameters.AddWithValue("@clientIdentification", txtClientIdentification.Text);
                comand.Parameters.AddWithValue("@sellerIdentification", txtSellerIdentification.Text);
                comand.Parameters.AddWithValue("@productName", txtProductName.Text);
                comand.Parameters.AddWithValue("@amount", txtAmount.Text);
                comand.Parameters.AddWithValue("@unitValue", txtUnitValue.Text);
                comand.Parameters.AddWithValue("@total", txtTotal.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly edited", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Try again" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteOrders()
        {
            try
            {
                SqlCommand comand;
                string sql = string.Empty;
                sql = "DELETE FROM tblOrders WHERE ClientIdentification = @clientIdentification;";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@clientIdentification", txtClientIdentification.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete, error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear()
        {
            dtpDateAndHour.Value = DateTime.Now;
            txtClientIdentification.Text = String.Empty;
            txtSellerIdentification.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtAmount.Text = String.Empty;
            txtUnitValue.Text = String.Empty;
            txtTotal.Text = String.Empty;
        }

        #endregion

        #region EVENTOS

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDateAndHour.Text = dgvOrders.CurrentRow.Cells["DateAndHour"].Value.ToString();
            txtClientIdentification.Text = dgvOrders.CurrentRow.Cells["ClientIdentification"].Value.ToString();
            txtSellerIdentification.Text = dgvOrders.CurrentRow.Cells["SellerIdentification"].Value.ToString();
            txtProductName.Text = dgvOrders.CurrentRow.Cells["ProductName"].Value.ToString();
            txtAmount.Text = dgvOrders.CurrentRow.Cells["Amount"].Value.ToString();
            txtUnitValue.Text = dgvOrders.CurrentRow.Cells["UnitValue"].Value.ToString();
            txtTotal.Text = dgvOrders.CurrentRow.Cells["Total"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveOrders();
            showDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateOrders();
            showDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteOrders();
            showDataGridView();
            clear();
        }

        private void dtpDateAndHour_ValueChanged(object sender, EventArgs e)
        {
            fechaHora = Convert.ToDateTime(dtpDateAndHour.Value.ToString("g"));
        }

        private void txtUnitValue_Leave(object sender, EventArgs e)
        { 
            txtTotal.Text = (double.Parse(txtUnitValue.Text)*double.Parse(txtAmount.Text)).ToString();
        }

        private void pbIdentificationCustomer_Click(object sender, EventArgs e)
        {
            FrmClientIdentificationOrders frm = new FrmClientIdentificationOrders();
            frm.ShowDialog();
            txtClientIdentification.Text = frm.IdentificationCustomer;
            this.Visible = true;
        }

        private void pbIdentificationSeller_Click(object sender, EventArgs e)
        {
            FrmSellerIdentificationOrders frm = new FrmSellerIdentificationOrders();
            frm.ShowDialog();
            txtSellerIdentification.Text = frm.IdentificationSeller;
            this.Visible = true;
        }

        #endregion
    }
}
