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
            this.grpInformacion.Location = new System.Drawing.Point(12, 23);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(909, 410);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            // 
            // Añadir_Info_Pintura
            // 
            this.Añadir_Info_Pintura.FormattingEnabled = true;
            this.Añadir_Info_Pintura.Location = new System.Drawing.Point(625, 19);
            this.Añadir_Info_Pintura.Name = "Añadir_Info_Pintura";
            this.Añadir_Info_Pintura.Size = new System.Drawing.Size(260, 381);
            this.Añadir_Info_Pintura.TabIndex = 6;
            // 
            // Informacion_Pintura
            // 
            this.Informacion_Pintura.FormattingEnabled = true;
            this.Informacion_Pintura.Location = new System.Drawing.Point(344, 19);
            this.Informacion_Pintura.Name = "Informacion_Pintura";
            this.Informacion_Pintura.Size = new System.Drawing.Size(260, 381);
            this.Informacion_Pintura.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 292);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(27, 317);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(105, 23);
            this.btn_Anterior.TabIndex = 3;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Location = new System.Drawing.Point(186, 317);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(113, 23);
            this.btn_Siguiente.TabIndex = 2;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            // 
            // btnEliminar_Pintura
            // 
            this.btnEliminar_Pintura.Location = new System.Drawing.Point(27, 381);
            this.btnEliminar_Pintura.Name = "btnEliminar_Pintura";
            this.btnEliminar_Pintura.Size = new System.Drawing.Size(105, 23);
            this.btnEliminar_Pintura.TabIndex = 1;
            this.btnEliminar_Pintura.Text = "Eliminar Pintura";
            this.btnEliminar_Pintura.UseVisualStyleBackColor = true;
            // 
            // btnAñadir_Pintura
            // 
            this.btnAñadir_Pintura.Location = new System.Drawing.Point(186, 381);
            this.btnAñadir_Pintura.Name = "btnAñadir_Pintura";
            this.btnAñadir_Pintura.Size = new System.Drawing.Size(113, 23);
            this.btnAñadir_Pintura.TabIndex = 0;
            this.btnAñadir_Pintura.Text = "Añadir Pintura";
            this.btnAñadir_Pintura.UseVisualStyleBackColor = true;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 478);
            this.Controls.Add(this.grpInformacion);
            this.Name = "FrmPersonal";
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