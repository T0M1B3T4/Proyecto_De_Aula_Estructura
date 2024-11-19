namespace Gestión_Museo
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.grpNuevoUsuario = new System.Windows.Forms.GroupBox();
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.btnConfirmarNuevo = new System.Windows.Forms.Button();
            this.btnCarcelarUsuario = new System.Windows.Forms.Button();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContrasena1 = new System.Windows.Forms.Label();
            this.lblUsuario1 = new System.Windows.Forms.Label();
            this.grpNuevoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNuevoUsuario
            // 
            this.grpNuevoUsuario.BackgroundImage = global::Gestión_Museo.Properties.Resources.FONDO_3;
            this.grpNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpNuevoUsuario.Controls.Add(this.chkMostrarContrasena);
            this.grpNuevoUsuario.Controls.Add(this.btnConfirmarNuevo);
            this.grpNuevoUsuario.Controls.Add(this.btnCarcelarUsuario);
            this.grpNuevoUsuario.Controls.Add(this.txtConfirmarContrasena);
            this.grpNuevoUsuario.Controls.Add(this.txtContrasenaNueva);
            this.grpNuevoUsuario.Controls.Add(this.txtNuevoUsuario);
            this.grpNuevoUsuario.Controls.Add(this.label1);
            this.grpNuevoUsuario.Controls.Add(this.lblContrasena1);
            this.grpNuevoUsuario.Controls.Add(this.lblUsuario1);
            this.grpNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoUsuario.Location = new System.Drawing.Point(16, 15);
            this.grpNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuevoUsuario.Name = "grpNuevoUsuario";
            this.grpNuevoUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuevoUsuario.Size = new System.Drawing.Size(568, 481);
            this.grpNuevoUsuario.TabIndex = 3;
            this.grpNuevoUsuario.TabStop = false;
            this.grpNuevoUsuario.Enter += new System.EventHandler(this.grpNuevoUsuario_Enter);
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.AutoSize = true;
            this.chkMostrarContrasena.Location = new System.Drawing.Point(308, 345);
            this.chkMostrarContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(173, 21);
            this.chkMostrarContrasena.TabIndex = 12;
            this.chkMostrarContrasena.Text = "Mostrar Contraseña";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena_CheckedChanged);
            // 
            // btnConfirmarNuevo
            // 
            this.btnConfirmarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarNuevo.Location = new System.Drawing.Point(308, 390);
            this.btnConfirmarNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarNuevo.Name = "btnConfirmarNuevo";
            this.btnConfirmarNuevo.Size = new System.Drawing.Size(175, 41);
            this.btnConfirmarNuevo.TabIndex = 11;
            this.btnConfirmarNuevo.Text = "Confirmar";
            this.btnConfirmarNuevo.UseVisualStyleBackColor = true;
            this.btnConfirmarNuevo.Click += new System.EventHandler(this.btnConfirmarNuevo_Click);
            // 
            // btnCarcelarUsuario
            // 
            this.btnCarcelarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarcelarUsuario.Location = new System.Drawing.Point(81, 390);
            this.btnCarcelarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarcelarUsuario.Name = "btnCarcelarUsuario";
            this.btnCarcelarUsuario.Size = new System.Drawing.Size(172, 41);
            this.btnCarcelarUsuario.TabIndex = 10;
            this.btnCarcelarUsuario.Text = "Cancelar";
            this.btnCarcelarUsuario.UseVisualStyleBackColor = true;
            this.btnCarcelarUsuario.Click += new System.EventHandler(this.btnCarcelarUsuario_Click);
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(81, 300);
            this.txtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(400, 23);
            this.txtConfirmarContrasena.TabIndex = 9;
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.Location = new System.Drawing.Point(81, 193);
            this.txtContrasenaNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.PasswordChar = '*';
            this.txtContrasenaNueva.Size = new System.Drawing.Size(400, 23);
            this.txtContrasenaNueva.TabIndex = 8;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(81, 85);
            this.txtNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(400, 23);
            this.txtNuevoUsuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmar Contraseña";
            // 
            // lblContrasena1
            // 
            this.lblContrasena1.AutoSize = true;
            this.lblContrasena1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblContrasena1.Location = new System.Drawing.Point(205, 153);
            this.lblContrasena1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena1.Name = "lblContrasena1";
            this.lblContrasena1.Size = new System.Drawing.Size(156, 37);
            this.lblContrasena1.TabIndex = 3;
            this.lblContrasena1.Text = "Contraseña";
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario1.Location = new System.Drawing.Point(224, 44);
            this.lblUsuario1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(111, 37);
            this.lblUsuario1.TabIndex = 2;
            this.lblUsuario1.Text = "Usuario";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 506);
            this.Controls.Add(this.grpNuevoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro";
            this.Text = "R E G I S T R O  D E  U S U A R I O";
            this.grpNuevoUsuario.ResumeLayout(false);
            this.grpNuevoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContrasena1;
        private System.Windows.Forms.Label lblUsuario1;
        private System.Windows.Forms.Button btnConfirmarNuevo;
        private System.Windows.Forms.Button btnCarcelarUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.CheckBox chkMostrarContrasena;
    }
}