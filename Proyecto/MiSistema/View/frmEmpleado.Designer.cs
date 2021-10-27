
namespace MiSistema.View
{
    partial class frmEmpleado
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
            this.dataEmpleado = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEmpleado
            // 
            this.dataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleado.Location = new System.Drawing.Point(12, 126);
            this.dataEmpleado.Name = "dataEmpleado";
            this.dataEmpleado.RowHeadersWidth = 51;
            this.dataEmpleado.RowTemplate.Height = 24;
            this.dataEmpleado.Size = new System.Drawing.Size(1205, 260);
            this.dataEmpleado.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(24, 92);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(461, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(523, 82);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(172, 32);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Cambiar Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 436);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataEmpleado);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmpleado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEstado;
    }
}