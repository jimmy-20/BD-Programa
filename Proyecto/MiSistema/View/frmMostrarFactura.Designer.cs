
namespace MiSistema.View
{
    partial class frmMostrarFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.dtFactura = new System.Windows.Forms.DataGridView();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(180, 26);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(397, 22);
            this.txtIdFactura.TabIndex = 0;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(180, 66);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(397, 22);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(180, 107);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(397, 22);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // dtFactura
            // 
            this.dtFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFactura.Location = new System.Drawing.Point(46, 144);
            this.dtFactura.Name = "dtFactura";
            this.dtFactura.RowHeadersWidth = 51;
            this.dtFactura.RowTemplate.Height = 24;
            this.dtFactura.Size = new System.Drawing.Size(704, 150);
            this.dtFactura.TabIndex = 3;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(180, 310);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(397, 22);
            this.txtSubTotal.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(180, 347);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(397, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMostrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dtFactura);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdFactura);
            this.Name = "frmMostrarFactura";
            this.Text = "Buscar Factura";
            this.Load += new System.EventHandler(this.frmMostrarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.DataGridView dtFactura;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button1;
    }
}