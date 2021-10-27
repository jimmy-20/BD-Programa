
namespace MiSistema.View
{
    partial class frmBuscarCliente
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
            this.dtCliente = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCliente
            // 
            this.dtCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCliente.Location = new System.Drawing.Point(16, 82);
            this.dtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.RowHeadersWidth = 51;
            this.dtCliente.Size = new System.Drawing.Size(900, 191);
            this.dtCliente.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(399, 282);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(193, 28);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 22);
            this.textBox1.TabIndex = 2;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dtCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuscarCliente";
            this.Text = "frmBuscarCliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dtCliente;
    }
}