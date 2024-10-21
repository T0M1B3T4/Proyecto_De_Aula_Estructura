namespace Gestión_Museo
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnEntrar1 = new System.Windows.Forms.Button();
            this.chkMostrarContrasena1 = new System.Windows.Forms.CheckBox();
            this.lblContrasena1 = new System.Windows.Forms.Label();
            this.lblUsuario1 = new System.Windows.Forms.Label();
            this.txtContrasena1 = new System.Windows.Forms.TextBox();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.chkMostrar_Contrasena = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(137, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(231, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(137, 190);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(231, 22);
            this.txtContrasena.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(137, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(134, 158);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(92, 18);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnSalir1);
            this.grpLogin.Controls.Add(this.btnEntrar1);
            this.grpLogin.Controls.Add(this.chkMostrarContrasena1);
            this.grpLogin.Controls.Add(this.lblContrasena1);
            this.grpLogin.Controls.Add(this.lblUsuario1);
            this.grpLogin.Controls.Add(this.txtContrasena1);
            this.grpLogin.Controls.Add(this.txtUsuario1);
            this.grpLogin.Location = new System.Drawing.Point(368, 197);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogin.Size = new System.Drawing.Size(632, 459);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Enter += new System.EventHandler(this.grpLogin_Enter_1);
            // 
            // btnSalir1
            // 
            this.btnSalir1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir1.Location = new System.Drawing.Point(135, 373);
            this.btnSalir1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(171, 41);
            this.btnSalir1.TabIndex = 5;
            this.btnSalir1.Text = "Cancelar";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // btnEntrar1
            // 
            this.btnEntrar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar1.Location = new System.Drawing.Point(376, 373);
            this.btnEntrar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar1.Name = "btnEntrar1";
            this.btnEntrar1.Size = new System.Drawing.Size(172, 41);
            this.btnEntrar1.TabIndex = 1;
            this.btnEntrar1.Text = "Ingresar";
            this.btnEntrar1.UseVisualStyleBackColor = true;
            this.btnEntrar1.Click += new System.EventHandler(this.btnEntrar1_Click);
            // 
            // chkMostrarContrasena1
            // 
            this.chkMostrarContrasena1.AutoSize = true;
            this.chkMostrarContrasena1.Location = new System.Drawing.Point(407, 308);
            this.chkMostrarContrasena1.Margin = new System.Windows.Forms.Padding(4);
            this.chkMostrarContrasena1.Name = "chkMostrarContrasena1";
            this.chkMostrarContrasena1.Size = new System.Drawing.Size(146, 20);
            this.chkMostrarContrasena1.TabIndex = 4;
            this.chkMostrarContrasena1.Text = "Mostrar Contraseña";
            this.chkMostrarContrasena1.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena1.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena1_CheckedChanged);
            // 
            // lblContrasena1
            // 
            this.lblContrasena1.AutoSize = true;
            this.lblContrasena1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblContrasena1.Location = new System.Drawing.Point(112, 210);
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
            this.lblUsuario1.Location = new System.Drawing.Point(112, 82);
            this.lblUsuario1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(111, 37);
            this.lblUsuario1.TabIndex = 2;
            this.lblUsuario1.Text = "Usuario";
            // 
            // txtContrasena1
            // 
            this.txtContrasena1.Location = new System.Drawing.Point(115, 251);
            this.txtContrasena1.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena1.Name = "txtContrasena1";
            this.txtContrasena1.PasswordChar = '*';
            this.txtContrasena1.Size = new System.Drawing.Size(376, 22);
            this.txtContrasena1.TabIndex = 1;
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(115, 123);
            this.txtUsuario1.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(376, 22);
            this.txtUsuario1.TabIndex = 0;
            this.txtUsuario1.TextChanged += new System.EventHandler(this.txtUsuario1_TextChanged);
            // 
            // chkMostrar_Contrasena
            // 
            this.chkMostrar_Contrasena.AutoSize = true;
            this.chkMostrar_Contrasena.Location = new System.Drawing.Point(274, 216);
            this.chkMostrar_Contrasena.Name = "chkMostrar_Contrasena";
            this.chkMostrar_Contrasena.Size = new System.Drawing.Size(118, 17);
            this.chkMostrar_Contrasena.TabIndex = 4;
            this.chkMostrar_Contrasena.Text = "Mostrar Contraseña";
            this.chkMostrar_Contrasena.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(274, 252);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Ingresar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(151, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 784);
            this.Controls.Add(this.grpLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "I n g r e s o   G M S";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.CheckBox chkMostrar_Contrasena;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.Label lblContrasena1;
        private System.Windows.Forms.Label lblUsuario1;
        private System.Windows.Forms.TextBox txtContrasena1;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnEntrar1;
        private System.Windows.Forms.CheckBox chkMostrarContrasena1;
    }
}