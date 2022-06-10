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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Vitarrico
{
    public partial class FrmProviders : Form
    {
        ConexionSQLServer conexion = new ConexionSQLServer();

        #region atributos y propiedades

        private int idProviders;
        private DataTable dataProviders;

        #endregion

        #region constructor 

        public FrmProviders()
        {
            InitializeComponent();
            fillDataGridView();
        }

        #endregion

        #region metodos

        private void savedProviders()
        {
            try
            {
                SqlCommand comando;
                string sql;

                sql = @"INSERT INTO tblProviders (Nit,CompanyName,ProductCode,Email,Address,Phone)
                    VALUES (@nit, @companyName,@productCode, @email, @address, @phone)";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@nit", txtNit.Text);
                comando.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                comando.Parameters.AddWithValue("@productCode", txtProductCode.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@address", txtAddress.Text);
                comando.Parameters.AddWithValue("@phone", txtPhone.Text);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateProviders()
        {
            try
            {
                SqlCommand comando;
                string sql = @"UPDATE tblProviders
                           SET Nit = @nit
                              ,CompanyName = @companyName
                              ,ProductCode = @productCode
                              ,Email = @email
                              ,Address = @address
                              ,Phone = @phone
                         WHERE Id = @id";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@id", idProviders);
                comando.Parameters.AddWithValue("@nit", txtNit.Text);
                comando.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                comando.Parameters.AddWithValue("@productCode", txtProductCode.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@address", txtAddress.Text);
                comando.Parameters.AddWithValue("@phone", txtPhone.Text);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully update", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteProviders()
        {
            try
            {
                SqlCommand comando;
                string sql = @"DELETE FROM tblProviders
                            WHERE Id = @id";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@id", idProviders);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillDataGridView()
        {
            SqlCommand comando;
            string sql = @"SELECT *
                           FROM tblProviders";
            comando = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataProviders = dt;

            dgvProviders.DataSource = dt;
            dgvProviders.RowHeadersVisible = false;
            dgvProviders.Columns[0].Visible = false;
            dgvProviders.Columns[1].HeaderText = "Nit";
            dgvProviders.Columns[2].HeaderText = "Company name";
            dgvProviders.Columns[3].HeaderText = "Product code";
            dgvProviders.Columns[4].HeaderText = "Email";
            dgvProviders.Columns[5].HeaderText = "Address";
            dgvProviders.Columns[6].HeaderText = "Phone";
        }

        private void clear()
        {
            txtNit.Text = String.Empty;
            txtCompanyName.Text = String.Empty;
            txtProductCode.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
        }

        #endregion

        #region Eventos 

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedProviders();
            fillDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProviders();
            fillDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProviders();
            fillDataGridView();
            clear();
        }

        private void dgvProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idProviders = Convert.ToInt32(dgvProviders.CurrentRow.Cells["Id"].Value.ToString());
                txtNit.Text = dgvProviders.CurrentRow.Cells["Nit"].Value.ToString();
                txtCompanyName.Text = dgvProviders.CurrentRow.Cells["CompanyName"].Value.ToString();
                txtProductCode.Text = dgvProviders.CurrentRow.Cells["ProductCode"].Value.ToString();
                txtEmail.Text = dgvProviders.CurrentRow.Cells["Email"].Value.ToString();
                txtAddress.Text = dgvProviders.CurrentRow.Cells["Address"].Value.ToString();
                txtPhone.Text = dgvProviders.CurrentRow.Cells["Phone"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dateProviders ="";

            Document doc = new Document(PageSize.LETTER);
            PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\JUAN\OneDrive\UNAC\Proyecto_Integrador\Pdf\Providers.pdf", FileMode.Create));
            doc.AddTitle("Providers");
            doc.AddCreator("Vitarrico");
            doc.Open();
            doc.Add(new Paragraph("Providers vitarrico"));
            doc.Add(Chunk.NEWLINE);
            for (int fil = 0; fil< dataProviders.Rows.Count; fil++)
            {
                for (int col =1; col< dataProviders.Columns.Count; col++)
                {
                    dateProviders += " - " + dataProviders.Rows[fil][col].ToString();
                }
                doc.Add(new Paragraph(dateProviders));
                dateProviders = "";
                doc.Add(Chunk.NEWLINE);
            }
           
            doc.Add(Chunk.NEWLINE);

            doc.Close();
            MessageBox.Show("File downloaded successfully");
        }

        #endregion

    }
}
