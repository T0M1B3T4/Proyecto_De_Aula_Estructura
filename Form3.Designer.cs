namespace Gestión_Museo
{
    partial class FrmUsuarioFinal
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
            this.grpInformacionPinturas = new System.Windows.Forms.GroupBox();
            this.txtInfoCompleta = new System.Windows.Forms.RichTextBox();
            this.txtNombreSeleccionado = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pictureBoxPintura = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grpInformacionPinturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPintura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformacionPinturas
            // 
            this.grpInformacionPinturas.Controls.Add(this.btnFinalizar);
            this.grpInformacionPinturas.Controls.Add(this.txtInfoCompleta);
            this.grpInformacionPinturas.Controls.Add(this.txtNombreSeleccionado);
            this.grpInformacionPinturas.Controls.Add(this.btnAnterior);
            this.grpInformacionPinturas.Controls.Add(this.btnSiguiente);
            this.grpInformacionPinturas.Controls.Add(this.pictureBoxPintura);
            this.grpInformacionPinturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacionPinturas.Location = new System.Drawing.Point(12, 58);
            this.grpInformacionPinturas.Name = "grpInformacionPinturas";
            this.grpInformacionPinturas.Size = new System.Drawing.Size(676, 404);
            this.grpInformacionPinturas.TabIndex = 0;
            this.grpInformacionPinturas.TabStop = false;
            this.grpInformacionPinturas.Text = "Información Pinturas";
            // 
            // txtInfoCompleta
            // 
            this.txtInfoCompleta.Location = new System.Drawing.Point(349, 72);
            this.txtInfoCompleta.Name = "txtInfoCompleta";
            this.txtInfoCompleta.Size = new System.Drawing.Size(302, 275);
            this.txtInfoCompleta.TabIndex = 5;
            this.txtInfoCompleta.Text = "";
            // 
            // txtNombreSeleccionado
            // 
            this.txtNombreSeleccionado.Location = new System.Drawing.Point(349, 32);
            this.txtNombreSeleccionado.Name = "txtNombreSeleccionado";
            this.txtNombreSeleccionado.ReadOnly = true;
            this.txtNombreSeleccionado.Size = new System.Drawing.Size(302, 22);
            this.txtNombreSeleccionado.TabIndex = 3;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Location = new System.Drawing.Point(19, 325);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(146, 30);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Pintura Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(171, 325);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente Pintura";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPintura
            // 
            this.pictureBoxPintura.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxPintura.Name = "pictureBoxPintura";
            this.pictureBoxPintura.Size = new System.Drawing.Size(294, 290);
            this.pictureBoxPintura.TabIndex = 0;
            this.pictureBoxPintura.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(361, 32);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(287, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::Gestión_Museo.Properties.Resources.LUPA;
            this.pbBuscar.Location = new System.Drawing.Point(659, 32);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(29, 20);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Location = new System.Drawing.Point(87, 361);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(142, 30);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Sesion";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FrmUsuarioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 474);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.grpInformacionPinturas);
            this.Name = "FrmUsuarioFinal";
            this.Text = "Usuario Final";
            this.grpInformacionPinturas.ResumeLayout(false);
            this.grpInformacionPinturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPintura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacionPinturas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pictureBoxPintura;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtNombreSeleccionado;
        private System.Windows.Forms.RichTextBox txtInfoCompleta;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
