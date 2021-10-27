using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiSistema.View;

namespace MiSistema
{
    public partial class Form1 : Form
    {
        string rol;
        string nombre;

        public string Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string nombre,string rol)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.rol = rol;
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente(rol);
            fc.MdiParent = this;
            fc.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
         //   this.txtRol.Text = frmInicio.Rol;
         
            if(rol == "Administrador")
            {
               // this.catálogosToolStripMenuItem.Enabled = false;
               // this.reportesToolStripMenuItem.Enabled = false;
               //this.reservasToolStripMenuItem.Enabled = false;
               // this.cancelacionesToolStripMenuItem.Enabled = false;
            }else if (rol == "Facturador")
            {
                this.catálogosToolStripMenuItem.Enabled = false;
                this.reportesToolStripMenuItem.Enabled = false;
                this.seguridadToolStripMenuItem.Enabled = false;
            }else if (rol == "Vendedor")
            {
                this.empleadoToolStripMenuItem.Enabled = false;
                this.habitaciónToolStripMenuItem.Enabled = false;
                this.serviciosToolStripMenuItem.Enabled = false;
                this.huespedToolStripMenuItem.Enabled = false;

                this.operacionesToolStripMenuItem.Enabled = false;
                this.reportesToolStripMenuItem.Enabled = false;
            }

            this.lblUsuario.Text = Nombre;
            this.lblRol.Text = Rol;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fc = new frmUsuario();
            fc.MdiParent = this;
            fc.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura fc = new frmFactura();
            fc.MdiParent = this;
            fc.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado fc = new frmEmpleado();
            fc.MdiParent = this;
            fc.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
