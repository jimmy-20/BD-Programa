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
    public partial class frmMostrarFactura : Form
    {
        public frmMostrarFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            DataTable dato;
            dato = CFactura.MostrarFactura(int.Parse(this.txtIdFactura.Text));
            if (dato.Rows.Count > 0)
            {

                this.txtNombreCliente.Text = dato.Rows[0][1].ToString();
                this.txtNombreEmpleado.Text = dato.Rows[0][2].ToString();
                this.txtSubTotal.Text = dato.Rows[0][8].ToString();
                this.txtTotal.Text = dato.Rows[0][9].ToString();

                this.dtFactura.DataSource = CFactura.MostrarFactura(int.Parse(this.txtIdFactura.Text));
                this.dtFactura.Columns[1].Visible = false;
                this.dtFactura.Columns[2].Visible = false;
                this.dtFactura.Columns[8].Visible = false;
                this.dtFactura.Columns[9].Visible = false;

            }
            else
                MessageBox.Show("El NoFactura ingresado no existe", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmMostrarFactura_Load(object sender, EventArgs e)
        {
            this.txtNombreCliente.Enabled = false;
            this.txtNombreEmpleado.Enabled = false;
            this.txtSubTotal.Enabled = false;
            this.txtTotal.Enabled = false;
        }
    }
}
