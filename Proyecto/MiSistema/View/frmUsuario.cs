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
    public partial class frmUsuario : Form
    {

        Boolean IsNuevo = true;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.dtUsuario.DataSource = CUsuario.Mostrar_Usuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (this.txtContraseña.Text != this.txtRepetirContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no son iguales", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {


                try
                {

                    string rpta = "";

                    if (this.IsNuevo)
                    {
                        rpta = CUsuario.Insertar(this.txtUsuario.Text, this.txtContraseña.Text, this.cmbRol.Text);

                    }
                    else
                    {
                        //rpta = CCliente.Editar(Convert.ToInt32(this.dtCliente.CurrentRow.Cells["Id_Cliente"].Value),
                        //    this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text,
                        //    this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text, txtCorreo.Text);

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

                    //  this.IsNuevo = false;
                    //  this.IsEditar = false;
                    //  this.Botones();
                    //   this.Limpiar();
                    // this.dtCliente.DataSource = CCliente.MostrarCliente();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

        }




    }
}

