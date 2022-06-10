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
    
    public partial class Administrator : UserControl
    {
        public delegate void Enviar(string valor);

        public Administrator()
        {
            InitializeComponent();
        }

        private void menuStripAdministrator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Enviar delegado = new Enviar(FrmPrincipal.FormPrincipal.receive);
            delegado(e.ClickedItem.ToString());
        }
    }
}
