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
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.Añadir_Info_Pintura = new System.Windows.Forms.ListBox();
            this.Informacion_Pintura = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.btnEliminar_Pintura = new System.Windows.Forms.Button();
            this.btnAñadir_Pintura = new System.Windows.Forms.Button();
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.Añadir_Info_Pintura);
            this.grpInformacion.Controls.Add(this.Informacion_Pintura);
            this.grpInformacion.Controls.Add(this.pictureBox1);
            this.grpInformacion.Controls.Add(this.btn_Anterior);
            this.grpInformacion.Controls.Add(this.btn_Siguiente);
            this.grpInformacion.Controls.Add(this.btnEliminar_Pintura);
            this.grpInformacion.Controls.Add(this.btnAñadir_Pintura);
            this.grpInformacion.Location = new System.Drawing.Point(16, 28);
            this.grpInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInformacion.Size = new System.Drawing.Size(1212, 505);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            // 
            // Añadir_Info_Pintura
            // 
            this.Añadir_Info_Pintura.FormattingEnabled = true;
            this.Añadir_Info_Pintura.ItemHeight = 16;
            this.Añadir_Info_Pintura.Location = new System.Drawing.Point(833, 23);
            this.Añadir_Info_Pintura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Añadir_Info_Pintura.Name = "Añadir_Info_Pintura";
            this.Añadir_Info_Pintura.Size = new System.Drawing.Size(345, 468);
            this.Añadir_Info_Pintura.TabIndex = 6;
            // 
            // Informacion_Pintura
            // 
            this.Informacion_Pintura.FormattingEnabled = true;
            this.Informacion_Pintura.ItemHeight = 16;
            this.Informacion_Pintura.Location = new System.Drawing.Point(459, 23);
            this.Informacion_Pintura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Informacion_Pintura.Name = "Informacion_Pintura";
            this.Informacion_Pintura.Size = new System.Drawing.Size(345, 468);
            this.Informacion_Pintura.TabIndex = 5;
            this.Informacion_Pintura.SelectedIndexChanged += new System.EventHandler(this.Informacion_Pintura_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 359);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(36, 390);
            this.btn_Anterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(140, 28);
            this.btn_Anterior.TabIndex = 3;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Location = new System.Drawing.Point(248, 390);
            this.btn_Siguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(151, 28);
            this.btn_Siguiente.TabIndex = 2;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            // 
            // btnEliminar_Pintura
            // 
            this.btnEliminar_Pintura.Location = new System.Drawing.Point(36, 469);
            this.btnEliminar_Pintura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar_Pintura.Name = "btnEliminar_Pintura";
            this.btnEliminar_Pintura.Size = new System.Drawing.Size(140, 28);
            this.btnEliminar_Pintura.TabIndex = 1;
            this.btnEliminar_Pintura.Text = "Eliminar Pintura";
            this.btnEliminar_Pintura.UseVisualStyleBackColor = true;
            // 
            // btnAñadir_Pintura
            // 
            this.btnAñadir_Pintura.Location = new System.Drawing.Point(248, 469);
            this.btnAñadir_Pintura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir_Pintura.Name = "btnAñadir_Pintura";
            this.btnAñadir_Pintura.Size = new System.Drawing.Size(151, 28);
            this.btnAñadir_Pintura.TabIndex = 0;
            this.btnAñadir_Pintura.Text = "Añadir Pintura";
            this.btnAñadir_Pintura.UseVisualStyleBackColor = true;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 588);
            this.Controls.Add(this.grpInformacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Museo";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.grpInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.Button btnEliminar_Pintura;
        private System.Windows.Forms.Button btnAñadir_Pintura;
        private System.Windows.Forms.ListBox Informacion_Pintura;
        private System.Windows.Forms.ListBox Añadir_Info_Pintura;
    }
}