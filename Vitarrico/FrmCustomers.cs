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
    public partial class FrmCustomers : Form
    {

        #region CONEXION BD

        ConexionSQLServer conexion = new ConexionSQLServer();

        #endregion

        #region PROPIEDADES

        private DataTable adpCustomers;

        #endregion

        #region CONSTRUCTOR
        public FrmCustomers()
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
            dgvCustomers.Columns[0].HeaderText = "Type document";
            dgvCustomers.Columns[1].HeaderText = "Identification or nit";
            dgvCustomers.Columns[2].HeaderText = "Name or business name";
            dgvCustomers.Columns[3].HeaderText = "Last name";
            dgvCustomers.Columns[4].HeaderText = "Email";
            dgvCustomers.Columns[5].HeaderText = "Address";
            dgvCustomers.Columns[6].HeaderText = "Phone";

        }

        private void clear()
        {
            cbTypeDocument.Text = String.Empty;
            txtIdentificationOrNit.Text = String.Empty;
            txtNameOrBusinessName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;

        }

        private void saveCustomers()
        {
            try
            {
                SqlCommand comand;
                string sql = @"INSERT INTO tblCustumer (TypeDocument, IdentificationOrNit, NameOrBusinessName, LastName, Email, Address, Phone)
                                VALUES (@typeDocument, @identificationOrNit, @nameOrBusinessName, @lastName, @email, @address, @phone)";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@typeDocument", cbTypeDocument.Text);
                comand.Parameters.AddWithValue("@identificationOrNit", txtIdentificationOrNit.Text);
                comand.Parameters.AddWithValue("@nameOrBusinessName", txtNameOrBusinessName.Text);
                comand.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comand.Parameters.AddWithValue("@email", txtEmail.Text);
                comand.Parameters.AddWithValue("@address", txtAddress.Text);
                comand.Parameters.AddWithValue("@phone", txtPhone.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("It has been successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Try again" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateCustomers()
        {
            try
            {
                SqlCommand comand;
                string sql = @"UPDATE tblCustumer
                             SET TypeDocument = @typeDocument,
                                 NameOrBusinessName = @nameOrBusinessName,
                                 LastName = @lastName,
                                 Email = @email,
                                 Address = @address,
                                 Phone = @phone
                             WHERE   IdentificationOrNit = @identificationOrNit";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@typeDocument", cbTypeDocument.Text);
                comand.Parameters.AddWithValue("@identificationOrNit", txtIdentificationOrNit.Text);
                comand.Parameters.AddWithValue("@nameOrBusinessName", txtNameOrBusinessName.Text);
                comand.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comand.Parameters.AddWithValue("@email", txtEmail.Text);
                comand.Parameters.AddWithValue("@address", txtAddress.Text);
                comand.Parameters.AddWithValue("@phone", txtPhone.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly edited", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteCustomers()
        {
            try
            {
                SqlCommand comand;
                string sql = string.Empty;
                sql = "DELETE FROM tblCustumer WHERE IdentificationOrNit = @identificationOrNit;";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@identificationOrNit", txtIdentificationOrNit.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete, error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion

        #region EVENTOS
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cbTypeDocument.SelectedIndex = cbTypeDocument.FindString(dgvCustomers.CurrentRow.Cells["TypeDocument"].Value.ToString());
                txtIdentificationOrNit.Text = dgvCustomers.CurrentRow.Cells["IdentificationOrNit"].Value.ToString();
                txtNameOrBusinessName.Text = dgvCustomers.CurrentRow.Cells["NameOrBusinessName"].Value.ToString();
                txtLastName.Text = dgvCustomers.CurrentRow.Cells["LastName"].Value.ToString();
                txtEmail.Text = dgvCustomers.CurrentRow.Cells["Email"].Value.ToString();
                txtAddress.Text = dgvCustomers.CurrentRow.Cells["Address"].Value.ToString();
                txtPhone.Text = dgvCustomers.CurrentRow.Cells["Phone"].Value.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveCustomers();
            showDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateCustomers();
            showDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCustomers();
            showDataGridView();
            clear();
        }

        #endregion
    }
}
