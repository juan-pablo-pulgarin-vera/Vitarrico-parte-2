using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitarrico
{
    public partial class FrmPrincipal : Form
    {
        #region Atributos y Metodos

        public static FrmPrincipal FormPrincipal;
        #endregion

        #region Constructores

        public FrmPrincipal()
        {
            InitializeComponent();
            FormPrincipal = this;
        }

        public FrmPrincipal(bool esAdministrador, string users, bool esVendedor = false){
            InitializeComponent();

            if (esAdministrador)
            {
                sellers1.Visible = false;
                winemaker1.Visible = false;
            }
            else
            {
                if (esVendedor)
                {
                    administrator1.Visible = false;
                    winemaker1.Visible=false;
                }
                else
                {
                    administrator1.Visible=false;
                    sellers1.Visible=false;
                }
            }

            lblNameUser.Text = "Bienvenido/a " + users;
            FormPrincipal = this;
        }
        #endregion

        #region Métodos

        public void receive(string value)
        {
            if (value == "PROVIDERS")
            {
                FrmProviders frm = new FrmProviders();
                frm.MdiParent = this;
                frm.Show();
            }
            if (value == "USERS")
            {
                FrmUsers frmu = new FrmUsers();
                frmu.MdiParent = this;
                frmu.Show();
            }
            if (value == "SELLERS")
            {
                FrmSellers frms = new FrmSellers();
                frms.MdiParent = this;
                frms.Show();
            }

        }

        public void receiveSellers(string option)
        {
            if (option == "ORDERS")
            {
                FrmOrders frmu = new FrmOrders();
                frmu.MdiParent = this;
                frmu.Show();
            }
            else if(option == "CUSTOMERS")
            {
                FrmCustomers frmc = new FrmCustomers();
                frmc.MdiParent = this;
                frmc.Show();
            }
        }

        public void receiveSelected(string opcionSeleccionada)
        {
            if (opcionSeleccionada == "PRODUCTS")
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FrmProviders))
                    {
                        frm.Close();
                        break;
                    }
                }

                FrmProducts frmProducts = new FrmProducts();
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
            else if (opcionSeleccionada == "PROVIDERS")
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FrmProducts))
                    {
                        frm.Close();
                        break;
                    }
                }

                FrmProviders frmProviders = new FrmProviders();
                frmProviders.MdiParent = this;
                frmProviders.Show();
            }
        }
        #endregion

        #region Eventos

        #endregion


    }
}
