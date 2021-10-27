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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }
        public void MostrarEmpleado()
        {
            this.dataEmpleado.DataSource = CEmpleado.MostrarEmpleado();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dataEmpleado.DataSource = CEmpleado.BuscarEmpleado(this.txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dataEmpleado.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CEmpleado.EstadoEmpleado(Convert.ToInt32(this.dataEmpleado.CurrentRow.Cells["Id_Empleado"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarEmpleado();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}