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
    public partial class FrmUsers : Form
    {

        #region CONEXIÓN BD

        ConexionSQLServer conexion = new ConexionSQLServer();

        #endregion

        #region PROPIEDADES

        private DataTable adpPeople;

        #endregion

        #region CONSTRUCTOR
        public FrmUsers()
        {
            InitializeComponent();
            showDataGridView();
        }
        #endregion

        #region MÉTODOS


        private void showDataGridView()
        {
            SqlCommand comand;
            string sql = @"SELECT * FROM tblPeople";
            comand = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adpPeople = dt;
            dgvUsers.DataSource = dt;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.Columns[0].HeaderText = "Type document";
            dgvUsers.Columns[1].HeaderText = "Idetification";
            dgvUsers.Columns[2].HeaderText = "Name";
            dgvUsers.Columns[3].HeaderText = "Last name";
            dgvUsers.Columns[4].HeaderText = "Email";
            dgvUsers.Columns[5].HeaderText = "Address";
            dgvUsers.Columns[6].HeaderText = "Phone";
            dgvUsers.Columns[7].HeaderText = "Kind Of Person";

        }

        private void clear()
        {
            cbTypeDocument.Text = String.Empty;
            txtIdentification.Text = String.Empty;
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
            cbKindPerson.Text = String.Empty;

        }


        private void saveUsers()
        {
            try
            {
                SqlCommand comand;
                string sql =

                    sql = @"INSERT INTO tblPeople (TypeDocument, Identification, Name, LastName, Email, Address, Phone, KindOfPerson) 
                    VALUES (@typeDocument, @identification, @name, @lastName, @email, @address, @phone, @kindOfPerson)";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@typeDocument", cbTypeDocument.Text);
                comand.Parameters.AddWithValue("@identification", txtIdentification.Text);
                comand.Parameters.AddWithValue("@name", txtName.Text);
                comand.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comand.Parameters.AddWithValue("@email", txtEmail.Text);
                comand.Parameters.AddWithValue("@address", txtAddress.Text);
                comand.Parameters.AddWithValue("@phone", txtPhone.Text);
                comand.Parameters.AddWithValue("@kindOfPerson", cbKindPerson.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("It has been successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Try again" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateUsers()
        {
            try
            {
                SqlCommand comand;
                string sql = @"UPDATE tblPeople 
                    SET TypeDocument = @typeDocument,
                        Name = @name,
                        LastName = @lastName,
                        Email = @email, 
                        Address = @address, 
                        Phone = @phone,
                        KindOfPerson = @kindOfPerson
                    WHERE Identification = @identification";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@typeDocument", cbTypeDocument.Text);
                comand.Parameters.AddWithValue("@identification", txtIdentification.Text);
                comand.Parameters.AddWithValue("@name", txtName.Text);
                comand.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comand.Parameters.AddWithValue("@email", txtEmail.Text);
                comand.Parameters.AddWithValue("@address", txtAddress.Text);
                comand.Parameters.AddWithValue("@phone", txtPhone.Text);
                comand.Parameters.AddWithValue("@kindOfPerson", cbKindPerson.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly edited", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteUsers()
        {
            try
            {
                SqlCommand comand;
                string sql = string.Empty;
                sql  += "DELETE FROM tblUsers WHERE Identification_People = @identification;";
                sql += "\n";
                sql += "DELETE FROM tblPeople WHERE Identification = @identification;";
                conexion.ConectarBD.Open();
                comand = new SqlCommand(sql, conexion.ConectarBD);
                comand.Parameters.AddWithValue("@identification", txtIdentification.Text);
                comand.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("The information has been correctly delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                conexion.ConectarBD.Close();
                MessageBox.Show("Could not delete, error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        #endregion

        #region EVENTOS

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                cbTypeDocument.SelectedIndex = cbTypeDocument.FindString(dgvUsers.CurrentRow.Cells["TypeDocument"].Value.ToString());
                txtIdentification.Text = dgvUsers.CurrentRow.Cells["Identification"].Value.ToString();
                txtName.Text = dgvUsers.CurrentRow.Cells["Name"].Value.ToString();
                txtLastName.Text = dgvUsers.CurrentRow.Cells["LastName"].Value.ToString();
                txtEmail.Text = dgvUsers.CurrentRow.Cells["Email"].Value.ToString();
                txtAddress.Text = dgvUsers.CurrentRow.Cells["Address"].Value.ToString();
                txtPhone.Text = dgvUsers.CurrentRow.Cells["Phone"].Value.ToString();
                cbKindPerson.SelectedIndex = cbKindPerson.FindString(dgvUsers.CurrentRow.Cells["KindOfPerson"].Value.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveUsers();
            showDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateUsers();
            showDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUsers();
            showDataGridView();
            clear();
        }

        #endregion 
    }
}
