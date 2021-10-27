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
    public partial class frmCliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private string rol;
        public frmCliente(String rol)
        {
            this.rol = rol;

            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.dtCliente.DataSource= CCliente.MostrarCliente();
            Botones();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtCliente.DataSource = CCliente.BuscarCliente(this.txtBuscar.Text);
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnEstado.Enabled = false;
            }
            else
            {
                 this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnEstado.Enabled = true;
            }

            if (rol == "Vendedor")
            {
                this.btnEstado.Enabled = false;
            }

        }
        private void Habilitar(bool valor)
        {
            this.txtPrimerNombre.ReadOnly = !valor;
            this.txtSegundoNombre.ReadOnly = !valor;
            this.txtPrimerApellido.ReadOnly = !valor;
            this.txtSegundoApellido.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
         }
        private void Limpiar()
        {
            
            this.txtPrimerNombre.Text = string.Empty;
            this.txtSegundoNombre.Text = string.Empty;
            this.txtPrimerApellido.Text = string.Empty;
            this.txtSegundoApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtPrimerNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtCliente.CurrentCell = null;
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(this.dtCliente.SelectedRows.Count ==1)
            {
                this.txtPrimerNombre.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Primer Nombre"].Value);
                this.txtSegundoNombre.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Segundo Nombre"].Value);
                this.txtPrimerApellido.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Primer Apellido"].Value);
                this.txtSegundoApellido.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Segundo Apellido"].Value);
                this.txtDireccion.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Dirección"].Value);
                this.txtCorreo.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Correo"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dtCliente.CurrentRow.Cells["Teléfono"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtPrimerNombre.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                    rpta = CCliente.Insertar(this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text, this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text, txtCorreo.Text);

                }
                else
                {
                    rpta = CCliente.Editar(Convert.ToInt32(this.dtCliente.CurrentRow.Cells["Id_Cliente"].Value),
                        this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text,
                        this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text, txtCorreo.Text);
                  
                }

                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {

                        MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.dtCliente.DataSource = CCliente.MostrarCliente();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (this.dtCliente.SelectedRows.Count == 1)
            {
                try
                {
                                          
                  CCliente.CambioEstado(Convert.ToInt32(this.dtCliente.CurrentRow.Cells["Id_Cliente"].Value));
                  MessageBox.Show("El estado ha sido actualizado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.dtCliente.DataSource = CCliente.MostrarCliente();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

           }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para cambiar el estado", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
