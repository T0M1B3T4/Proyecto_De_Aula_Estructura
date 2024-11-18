namespace Gestión_Museo
{
    partial class FrmPersonal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonal));
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.GrpBotones = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar_Pintura = new System.Windows.Forms.Button();
            this.btnAñadir_Pintura = new System.Windows.Forms.Button();
            this.grpInfo_Pintura = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.txtMovimiento = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.lblGénero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.tipLimpiarCampos = new System.Windows.Forms.ToolTip(this.components);
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.grpInformacion.SuspendLayout();
            this.GrpBotones.SuspendLayout();
            this.grpInfo_Pintura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Archivos De Imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackgroundImage = global::Gestión_Museo.Properties.Resources.FONDO_2;
            this.grpInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpInformacion.Controls.Add(this.GrpBotones);
            this.grpInformacion.Controls.Add(this.grpInfo_Pintura);
            this.grpInformacion.Controls.Add(this.pctImagen);
            this.grpInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacion.Location = new System.Drawing.Point(12, 12);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(737, 514);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Enter += new System.EventHandler(this.grpInformacion_Enter);
            // 
            // GrpBotones
            // 
            this.GrpBotones.Controls.Add(this.Salir);
            this.GrpBotones.Controls.Add(this.btnGuardar);
            this.GrpBotones.Controls.Add(this.btnCargar);
            this.GrpBotones.Controls.Add(this.btnEliminar_Pintura);
            this.GrpBotones.Controls.Add(this.btnAñadir_Pintura);
            this.GrpBotones.Location = new System.Drawing.Point(16, 366);
            this.GrpBotones.Name = "GrpBotones";
            this.GrpBotones.Size = new System.Drawing.Size(297, 131);
            this.GrpBotones.TabIndex = 8;
            this.GrpBotones.TabStop = false;
            this.GrpBotones.Text = "Menú";
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(72, 90);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(131, 26);
            this.Salir.TabIndex = 8;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(156, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 26);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar Pintura";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Location = new System.Drawing.Point(6, 58);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(131, 26);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar Pintura";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminar_Pintura
            // 
            this.btnEliminar_Pintura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_Pintura.Location = new System.Drawing.Point(6, 22);
            this.btnEliminar_Pintura.Name = "btnEliminar_Pintura";
            this.btnEliminar_Pintura.Size = new System.Drawing.Size(131, 30);
            this.btnEliminar_Pintura.TabIndex = 1;
            this.btnEliminar_Pintura.Text = "Eliminar Pintura";
            this.btnEliminar_Pintura.UseVisualStyleBackColor = true;
            this.btnEliminar_Pintura.Click += new System.EventHandler(this.btnEliminar_Pintura_Click);
            // 
            // btnAñadir_Pintura
            // 
            this.btnAñadir_Pintura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir_Pintura.Location = new System.Drawing.Point(156, 22);
            this.btnAñadir_Pintura.Name = "btnAñadir_Pintura";
            this.btnAñadir_Pintura.Size = new System.Drawing.Size(125, 30);
            this.btnAñadir_Pintura.TabIndex = 0;
            this.btnAñadir_Pintura.Text = "Añadir Pintura";
            this.btnAñadir_Pintura.UseVisualStyleBackColor = true;
            this.btnAñadir_Pintura.Click += new System.EventHandler(this.btnAñadir_Pintura_Click);
            // 
            // grpInfo_Pintura
            // 
            this.grpInfo_Pintura.Controls.Add(this.btnLimpiarCampos);
            this.grpInfo_Pintura.Controls.Add(this.lblImagePath);
            this.grpInfo_Pintura.Controls.Add(this.txtImagePath);
            this.grpInfo_Pintura.Controls.Add(this.txtId);
            this.grpInfo_Pintura.Controls.Add(this.lblId);
            this.grpInfo_Pintura.Controls.Add(this.lblMovimiento);
            this.grpInfo_Pintura.Controls.Add(this.txtMovimiento);
            this.grpInfo_Pintura.Controls.Add(this.lblFechaIngreso);
            this.grpInfo_Pintura.Controls.Add(this.txtFechaIngreso);
            this.grpInfo_Pintura.Controls.Add(this.lblDimensiones);
            this.grpInfo_Pintura.Controls.Add(this.txtDimensiones);
            this.grpInfo_Pintura.Controls.Add(this.lblGénero);
            this.grpInfo_Pintura.Controls.Add(this.txtGenero);
            this.grpInfo_Pintura.Controls.Add(this.lblAño);
            this.grpInfo_Pintura.Controls.Add(this.txtAno);
            this.grpInfo_Pintura.Controls.Add(this.lblAutor);
            this.grpInfo_Pintura.Controls.Add(this.txtAutor);
            this.grpInfo_Pintura.Controls.Add(this.lblTitulo);
            this.grpInfo_Pintura.Controls.Add(this.txtTitulo);
            this.grpInfo_Pintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo_Pintura.Location = new System.Drawing.Point(331, 13);
            this.grpInfo_Pintura.Name = "grpInfo_Pintura";
            this.grpInfo_Pintura.Size = new System.Drawing.Size(386, 484);
            this.grpInfo_Pintura.TabIndex = 5;
            this.grpInfo_Pintura.TabStop = false;
            this.grpInfo_Pintura.Text = "Información Pintura";
            this.tipLimpiarCampos.SetToolTip(this.grpInfo_Pintura, "Es necesario despues de hacer una consulta, darle al botón de limpiar campos para" +
        " realizar otra");
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(18, 426);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(349, 30);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(15, 381);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(89, 15);
            this.lblImagePath.TabIndex = 17;
            this.lblImagePath.Text = "Ruta Imagen";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(170, 378);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(197, 21);
            this.txtImagePath.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(170, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(197, 21);
            this.txtId.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 15);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id Obra";
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(15, 339);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(136, 15);
            this.lblMovimiento.TabIndex = 13;
            this.lblMovimiento.Text = "Movimiento Artístico";
            // 
            // txtMovimiento
            // 
            this.txtMovimiento.Location = new System.Drawing.Point(170, 336);
            this.txtMovimiento.Name = "txtMovimiento";
            this.txtMovimiento.Size = new System.Drawing.Size(197, 21);
            this.txtMovimiento.TabIndex = 12;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(15, 297);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(98, 15);
            this.lblFechaIngreso.TabIndex = 11;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(170, 294);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(197, 21);
            this.txtFechaIngreso.TabIndex = 10;
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.Location = new System.Drawing.Point(15, 258);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(91, 15);
            this.lblDimensiones.TabIndex = 9;
            this.lblDimensiones.Text = "Dimensiones";
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Location = new System.Drawing.Point(170, 255);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(197, 21);
            this.txtDimensiones.TabIndex = 8;
            // 
            // lblGénero
            // 
            this.lblGénero.AutoSize = true;
            this.lblGénero.Location = new System.Drawing.Point(15, 219);
            this.lblGénero.Name = "lblGénero";
            this.lblGénero.Size = new System.Drawing.Size(132, 15);
            this.lblGénero.TabIndex = 7;
            this.lblGénero.Text = "Género o Categoría";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(170, 216);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(197, 21);
            this.txtGenero.TabIndex = 6;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(15, 177);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(31, 15);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(170, 174);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(197, 21);
            this.txtAno.TabIndex = 4;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(15, 133);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(40, 15);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(170, 130);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(197, 21);
            this.txtAutor.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 93);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título Obra";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(170, 90);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(197, 21);
            this.txtTitulo.TabIndex = 0;
            // 
            // tipLimpiarCampos
            // 
            this.tipLimpiarCampos.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipLimpiarCampos.ToolTipTitle = "Limpiar Campos";
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(16, 19);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(297, 329);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 4;
            this.pctImagen.TabStop = false;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 538);
            this.Controls.Add(this.grpInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P E R S O N A L  D E L  M U S E O";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.grpInformacion.ResumeLayout(false);
            this.GrpBotones.ResumeLayout(false);
            this.grpInfo_Pintura.ResumeLayout(false);
            this.grpInfo_Pintura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Button btnEliminar_Pintura;
        private System.Windows.Forms.Button btnAñadir_Pintura;
        private System.Windows.Forms.GroupBox grpInfo_Pintura;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox GrpBotones;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.TextBox txtMovimiento;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.Label lblDimensiones;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.Label lblGénero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ToolTip tipLimpiarCampos;
        private System.Windows.Forms.PictureBox pctImagen;
    }
}