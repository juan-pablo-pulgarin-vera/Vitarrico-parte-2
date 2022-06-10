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
    public partial class FrmSellers : Form
    {

        #region CONEXIÓN BD

        ConexionSQLServer conexion = new ConexionSQLServer();

        #endregion

        #region PROPIEDADES

        private DataTable adpSellers;

        #endregion

        #region CONSTRUCTOR
        public FrmSellers()
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
            dgvSellers.Columns[0].HeaderText = "Type document";
            dgvSellers.Columns[1].HeaderText = "Identification";
            dgvSellers.Columns[2].HeaderText = "Name";
            dgvSellers.Columns[3].HeaderText = "Last name";
            dgvSellers.Columns[4].HeaderText = "Address";
            dgvSellers.Columns[5].HeaderText = "Email";
            dgvSellers.Columns[6].HeaderText = "Phone";

        }

        private void clear()
        {
            cbTypeDocument.Text = String.Empty;
            txtIdentification.Text = String.Empty;
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;
        }

        private void saveSellers()
        {
            try
            {
                SqlCommand comand;
                string sql = @"INSERT INTO tblsellers (TypeDocument, Identification, Name, LastName, Address, Email, Phone)
                                VALUES (@typeDocument, @identification, @name, @lastName, @address, @email, @phone )";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@typeDocument", cbTypeDocument.Text);
                comand.Parameters.AddWithValue("@identification", txtIdentification.Text);
                comand.Parameters.AddWithValue("@name", txtName.Text);
                comand.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comand.Parameters.AddWithValue("@address", txtAddress.Text);
                comand.Parameters.AddWithValue("@email", txtEmail.Text);
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

        private void updateSellers()
        {
            try
            {
                SqlCommand comand;
                string sql = @"UPDATE tblsellers
                    SET TypeDocument = @typeDocument,
                        Name = @name,
                        LastName = @lastName,
                        Address = @address, 
                        Email = @email, 
                        Phone = @phone
                    WHERE Identification = @identification";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@typeDocument", cbTypeDocument.Text);
                comand.Parameters.AddWithValue("@identification", txtIdentification.Text);
                comand.Parameters.AddWithValue("@name", txtName.Text);
                comand.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comand.Parameters.AddWithValue("@address", txtAddress.Text);
                comand.Parameters.AddWithValue("@email", txtEmail.Text);
                comand.Parameters.AddWithValue("@phone", txtPhone.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly edited", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteSellers()
        {
            try
            {
                SqlCommand comand;
                string sql = string.Empty;
                sql += "DELETE FROM tblUsers WHERE Identification_Sellers = @identification;";
                sql += "\n";
                sql += "DELETE FROM tblsellers WHERE Identification = @identification;";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@identification", txtIdentification.Text);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSellers();
            showDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateSellers();
            showDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteSellers();
            showDataGridView();
            clear();
        }

        private void dgvSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cbTypeDocument.SelectedIndex = cbTypeDocument.FindString(dgvSellers.CurrentRow.Cells["TypeDocument"].Value.ToString());
                txtIdentification.Text = dgvSellers.CurrentRow.Cells["Identification"].Value.ToString();
                txtName.Text = dgvSellers.CurrentRow.Cells["Name"].Value.ToString();
                txtLastName.Text = dgvSellers.CurrentRow.Cells["LastName"].Value.ToString();
                txtAddress.Text = dgvSellers.CurrentRow.Cells["Address"].Value.ToString();
                txtEmail.Text = dgvSellers.CurrentRow.Cells["Email"].Value.ToString();
                txtPhone.Text = dgvSellers.CurrentRow.Cells["Phone"].Value.ToString();
               
            }
        }
    }
}
