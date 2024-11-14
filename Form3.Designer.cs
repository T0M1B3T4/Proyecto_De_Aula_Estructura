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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNombreSeleccionado = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtInfoCompleta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnfiltro = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPintura = new System.Windows.Forms.PictureBox();
            this.grpInformacionPinturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnfiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPintura)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformacionPinturas
            // 
            this.grpInformacionPinturas.Controls.Add(this.textBox3);
            this.grpInformacionPinturas.Controls.Add(this.label3);
            this.grpInformacionPinturas.Controls.Add(this.pictureBox3);
            this.grpInformacionPinturas.Controls.Add(this.textBox2);
            this.grpInformacionPinturas.Controls.Add(this.label2);
            this.grpInformacionPinturas.Controls.Add(this.pictureBox2);
            this.grpInformacionPinturas.Controls.Add(this.textBox1);
            this.grpInformacionPinturas.Controls.Add(this.label1);
            this.grpInformacionPinturas.Controls.Add(this.pictureBox4);
            this.grpInformacionPinturas.Controls.Add(this.btnFinalizar);
            this.grpInformacionPinturas.Controls.Add(this.txtInfoCompleta);
            this.grpInformacionPinturas.Controls.Add(this.txtNombreSeleccionado);
            this.grpInformacionPinturas.Controls.Add(this.btnAnterior);
            this.grpInformacionPinturas.Controls.Add(this.btnSiguiente);
            this.grpInformacionPinturas.Controls.Add(this.pictureBoxPintura);
            this.grpInformacionPinturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacionPinturas.Location = new System.Drawing.Point(12, 58);
            this.grpInformacionPinturas.Name = "grpInformacionPinturas";
            this.grpInformacionPinturas.Size = new System.Drawing.Size(827, 403);
            this.grpInformacionPinturas.TabIndex = 0;
            this.grpInformacionPinturas.TabStop = false;
            this.grpInformacionPinturas.Text = "Información Pinturas";
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
            // txtNombreSeleccionado
            // 
            this.txtNombreSeleccionado.Location = new System.Drawing.Point(336, 17);
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
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(130, 30);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(287, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // txtInfoCompleta
            // 
            this.txtInfoCompleta.Location = new System.Drawing.Point(336, 57);
            this.txtInfoCompleta.Name = "txtInfoCompleta";
            this.txtInfoCompleta.Size = new System.Drawing.Size(302, 275);
            this.txtInfoCompleta.TabIndex = 5;
            this.txtInfoCompleta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(701, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Autor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(712, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Género";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Año",
            "Autor",
            "Género"});
            this.comboBox1.Location = new System.Drawing.Point(501, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // btnfiltro
            // 
            this.btnfiltro.Image = global::Gestión_Museo.Properties.Resources.filtro;
            this.btnfiltro.Location = new System.Drawing.Point(809, 29);
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
            this.pbBuscar.Location = new System.Drawing.Point(423, 30);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(29, 20);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(658, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 88);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(655, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 97);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gestión_Museo.Properties.Resources.LUPA;
            this.pictureBox4.Location = new System.Drawing.Point(655, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(157, 88);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxPintura
            // 
            this.pictureBoxPintura.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxPintura.Name = "pictureBoxPintura";
            this.pictureBoxPintura.Size = new System.Drawing.Size(294, 290);
            this.pictureBoxPintura.TabIndex = 0;
            this.pictureBoxPintura.TabStop = false;
            // 
            // FrmUsuarioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 472);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.grpInformacionPinturas);
            this.Name = "FrmUsuarioFinal";
            this.Text = "Usuario Final";
            this.Click += new System.EventHandler(this.btnfiltro_Click);
            this.grpInformacionPinturas.ResumeLayout(false);
            this.grpInformacionPinturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnfiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPintura)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnfiltro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
