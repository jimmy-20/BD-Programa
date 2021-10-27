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
    public partial class frmInicio : Form
    {
        public static string idUsuario;
        public static string nombre;
        public static string Rol;

        public static string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
       
        public static string CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }

        private static string codigoUsuario;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dato;
            dato = CUsuario.Validar_acceso(this.txtUsuario.Text, this.txtContraseña.Text);
           if(dato ==null)
            {
                MessageBox.Show("No hay Conexión al Servidor", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            if (dato.Rows.Count > 0)
            {
                                            
                if (dato.Rows[0][0].ToString() == "Acceso Exitoso")
                {

                     Rol = dato.Rows[0][1].ToString();
                     nombre = dato.Rows[0][3].ToString();
                     codigoUsuario = dato.Rows[0][2].ToString();

                    //  Rol = "Administrador";
                 
                    MessageBox.Show("Bienvenido al Sistema", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 fc = new Form1(Nombre,Rol);
                    fc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Text = string.Empty;
                    this.txtContraseña.Text = string.Empty;
                    this.txtUsuario.Focus();
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                DataTable dato;
                dato = CUsuario.Validar_acceso(this.txtUsuario.Text, this.txtContraseña.Text);
                if (dato == null)
                {
                    MessageBox.Show("No hay Conexión al Servidor", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                 if (dato.Rows.Count > 0)
                {
                    DataRow dr;
                    dr = dato.Rows[0];
                    if (dr["Resultado"].ToString() == "Acceso Exitoso")
                    {
                        Rol = dato.Rows[0][1].ToString();
                        nombre = dato.Rows[0][3].ToString();
                        codigoUsuario = dato.Rows[0][2].ToString();
                        MessageBox.Show("Bienvenido al Sistema", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 fc = new Form1(nombre,Rol);
                        fc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtUsuario.Text = string.Empty;
                        this.txtContraseña.Text = string.Empty;
                        this.txtUsuario.Focus();
                    }




                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}

