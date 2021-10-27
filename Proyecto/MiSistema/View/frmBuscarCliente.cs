using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiSistema.Controller;

namespace MiSistema.View
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            this.dtCliente.DataSource = CCliente.MostrarCliente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtCliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
