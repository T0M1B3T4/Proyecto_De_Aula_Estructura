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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioFinal));
            this.grpInformacionPinturas = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtInfoCompleta = new System.Windows.Forms.RichTextBox();
            this.txtNombreSeleccionado = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pictureBoxPintura = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnfiltro = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.grpInformacionPinturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPintura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformacionPinturas
            // 
            this.grpInformacionPinturas.BackgroundImage = global::Gestión_Museo.Properties.Resources.FONDO_4;
            this.grpInformacionPinturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpInformacionPinturas.Controls.Add(this.txtnombre);
            this.grpInformacionPinturas.Controls.Add(this.btnFinalizar);
            this.grpInformacionPinturas.Controls.Add(this.txtInfoCompleta);
            this.grpInformacionPinturas.Controls.Add(this.txtNombreSeleccionado);
            this.grpInformacionPinturas.Controls.Add(this.btnAnterior);
            this.grpInformacionPinturas.Controls.Add(this.btnSiguiente);
            this.grpInformacionPinturas.Controls.Add(this.pictureBoxPintura);
            this.grpInformacionPinturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacionPinturas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpInformacionPinturas.Location = new System.Drawing.Point(12, 41);
            this.grpInformacionPinturas.Name = "grpInformacionPinturas";
            this.grpInformacionPinturas.Size = new System.Drawing.Size(757, 420);
            this.grpInformacionPinturas.TabIndex = 0;
            this.grpInformacionPinturas.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Location = new System.Drawing.Point(465, 354);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(142, 30);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Sesion";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtInfoCompleta
            // 
            this.txtInfoCompleta.Location = new System.Drawing.Point(355, 58);
            this.txtInfoCompleta.Name = "txtInfoCompleta";
            this.txtInfoCompleta.Size = new System.Drawing.Size(355, 275);
            this.txtInfoCompleta.TabIndex = 5;
            this.txtInfoCompleta.Text = "";
            // 
            // txtNombreSeleccionado
            // 
            this.txtNombreSeleccionado.Location = new System.Drawing.Point(355, 18);
            this.txtNombreSeleccionado.Name = "txtNombreSeleccionado";
            this.txtNombreSeleccionado.ReadOnly = true;
            this.txtNombreSeleccionado.Size = new System.Drawing.Size(355, 22);
            this.txtNombreSeleccionado.TabIndex = 3;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Location = new System.Drawing.Point(19, 354);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(146, 30);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Pintura Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(171, 354);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente Pintura";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPintura
            // 
            this.pictureBoxPintura.Location = new System.Drawing.Point(19, 58);
            this.pictureBoxPintura.Name = "pictureBoxPintura";
            this.pictureBoxPintura.Size = new System.Drawing.Size(294, 275);
            this.pictureBoxPintura.TabIndex = 0;
            this.pictureBoxPintura.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(31, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(287, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Renacimiento",
            "Barroco",
            "Impresionismo",
            "Expresionismo",
            "Surrealismo"});
            this.cbCategoria.Location = new System.Drawing.Point(498, 14);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(224, 21);
            this.cbCategoria.TabIndex = 16;
            // 
            // btnfiltro
            // 
            this.btnfiltro.Image = global::Gestión_Museo.Properties.Resources.filtro;
            this.btnfiltro.Location = new System.Drawing.Point(739, 14);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(30, 21);
            this.btnfiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnfiltro.TabIndex = 14;
            this.btnfiltro.TabStop = false;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::Gestión_Museo.Properties.Resources.Lupa_1;
            this.pbBuscar.Location = new System.Drawing.Point(324, 14);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(29, 20);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(90, 21);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(144, 22);
            this.txtnombre.TabIndex = 7;
            this.txtnombre.Text = "Informaciòn Pintura";
            // 
            // FrmUsuarioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 472);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.grpInformacionPinturas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarioFinal";
            this.Text = "U S U A R I O";
            this.Click += new System.EventHandler(this.btnfiltro_Click);
            this.grpInformacionPinturas.ResumeLayout(false);
            this.grpInformacionPinturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPintura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfiltro)).EndInit();
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
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.RichTextBox txtInfoCompleta;
        private System.Windows.Forms.PictureBox btnfiltro;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtnombre;
    }
}
