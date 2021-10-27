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
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            this.dtProducto.DataSource = CServicio.MostrarServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.dtProducto.Rows.Count ==0)
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
