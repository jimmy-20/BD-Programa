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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        public static int cont_fila = 0;
        public static double total;
        public static string codigoUsuario;
        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto fc = new frmBuscarProducto();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtCodigoProducto.Text = fc.dtProducto.Rows[fc.dtProducto.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtDescripcion.Text = fc.dtProducto.Rows[fc.dtProducto.CurrentRow.Index].Cells[1].Value.ToString();
                this.txtPrecio.Text = fc.dtProducto.Rows[fc.dtProducto.CurrentRow.Index].Cells[2].Value.ToString();
                
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente fc = new frmBuscarCliente();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtCodigoCliente.Text = fc.dtCliente.Rows[fc.dtCliente.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtNombreCliente.Text = fc.dtCliente.Rows[fc.dtCliente.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if ( this.txtCantidad.Text !="")
            {
                bool existe = false;
                int num_fila = 0;
                if (cont_fila == 0)
                {
                    this.dtFactura.Rows.Add(this.txtCodigoProducto.Text, this.txtDescripcion.Text,
                                            this.txtPrecio.Text, this.txtCantidad.Text);
                    double importe = Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[2].Value) *
                                                  Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[3].Value);
                    dtFactura.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                    LimpiarProducto();
                }
                else
                {
                    foreach (DataGridViewRow Fila in dtFactura.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == this.txtCodigoProducto.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        this.dtFactura.Rows[num_fila].Cells[3].Value =
                        (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(this.dtFactura.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(this.dtFactura.Rows[num_fila].Cells[2].Value) *
                                                Convert.ToDouble(this.dtFactura.Rows[num_fila].Cells[3].Value);
                        dtFactura.Rows[num_fila].Cells[4].Value = importe;
                        LimpiarProducto();
                    }
                    else
                    {
                        this.dtFactura.Rows.Add(this.txtCodigoProducto.Text, this.txtDescripcion.Text,
                                                this.txtPrecio.Text, this.txtCantidad.Text);
                        double importe = Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[2].Value) *
                                                      Convert.ToDouble(this.dtFactura.Rows[cont_fila].Cells[3].Value);
                        dtFactura.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                        LimpiarProducto();

                    }

                }
                total = 0;
                foreach (DataGridViewRow Fila in dtFactura.Rows)
                {
                    total = total + Convert.ToDouble(Fila.Cells[4].Value);
                }
                this.lblSubTotal.Text = "C$ " + total.ToString();
                this.lblIVA.Text = "C$ " + (total * 1.15).ToString();



            }
            else
            {
                MessageBox.Show("Debe Ingresar la Cantidad", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(this.dtFactura.Rows[dtFactura.CurrentRow.Index].Cells[4].Value));
                this.lblSubTotal.Text = "C$ " + total.ToString();
                this.lblIVA.Text = "C$ " + (total * 1.15).ToString();
                dtFactura.Rows.RemoveAt(dtFactura.CurrentRow.Index);
                cont_fila--;
            }
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = frmInicio.Nombre;
            codigoUsuario = frmInicio.CodigoUsuario;
            this.txtUsuario.Enabled = false;
            this.txtCodigoCliente.Enabled = false;
            this.txtNombreCliente.Enabled = false;
            this.txtCodigoProducto.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.lblSubTotal.Text = "C$ 0.00 ";
            this.lblIVA.Text = "C$ 0.00 ";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0)
            {
                try
                {
                    DataTable Datos = CFactura.InsertarFactura(Convert.ToInt32(codigoUsuario),
                                                                     Convert.ToInt32(this.txtCodigoCliente.Text.Trim()));
                  string idFactura;
                  
                
                     
                    idFactura = Datos.Rows[0][0].ToString();
                    foreach (DataGridViewRow Fila in dtFactura.Rows)
                    {
                        // Fila.Cells[4].Value.ToString();

                        
                       CFactura.InsertarDetalleFactura(Convert.ToInt32(idFactura), Convert.ToInt32(Fila.Cells[0].Value.ToString()), float.Parse(Fila.Cells[2].Value.ToString()), float.Parse(Fila.Cells[3].Value.ToString()));

                           }

                    MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception error) { }
                Limpiar();

            }
            else
            {
                MessageBox.Show("La Factura está vacía", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Limpiar()
        {

            this.txtCodigoCliente.Text = string.Empty;
            this.txtNombreCliente.Text = string.Empty;
            this.txtCodigoProducto.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.dtFactura.Rows.Clear();
            this.lblSubTotal.Text = "C$ 0.00 ";
             this.lblIVA.Text = "C$ 0.00 ";
        }
        private void LimpiarProducto()
        {
            this.txtCodigoProducto.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMostrarFactura fc = new frmMostrarFactura();
            fc.ShowDialog();
           
        }
    }
}
