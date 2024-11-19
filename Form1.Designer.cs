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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.chkMostrar_Contrasena = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtContrasena1 = new System.Windows.Forms.TextBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct = new System.Windows.Forms.PictureBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnEntrar1 = new System.Windows.Forms.Button();
            this.chkMostrarContrasena1 = new System.Windows.Forms.CheckBox();
            this.lblContrasena1 = new System.Windows.Forms.Label();
            this.lblUsuario1 = new System.Windows.Forms.Label();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
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
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.Control;
            this.grpLogin.BackgroundImage = global::Gestión_Museo.Properties.Resources.FONDO_1;
            this.grpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpLogin.Controls.Add(this.txtContrasena1);
            this.grpLogin.Controls.Add(this.pct4);
            this.grpLogin.Controls.Add(this.pct3);
            this.grpLogin.Controls.Add(this.pct2);
            this.grpLogin.Controls.Add(this.pct);
            this.grpLogin.Controls.Add(this.btnCrearUsuario);
            this.grpLogin.Controls.Add(this.btnSalir1);
            this.grpLogin.Controls.Add(this.btnEntrar1);
            this.grpLogin.Controls.Add(this.chkMostrarContrasena1);
            this.grpLogin.Controls.Add(this.lblContrasena1);
            this.grpLogin.Controls.Add(this.lblUsuario1);
            this.grpLogin.Controls.Add(this.txtUsuario1);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(16, 15);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogin.Size = new System.Drawing.Size(819, 609);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Enter += new System.EventHandler(this.grpLogin_Enter);
            // 
            // txtContrasena1
            // 
            this.txtContrasena1.Location = new System.Drawing.Point(157, 214);
            this.txtContrasena1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasena1.Name = "txtContrasena1";
            this.txtContrasena1.PasswordChar = '*';
            this.txtContrasena1.Size = new System.Drawing.Size(465, 23);
            this.txtContrasena1.TabIndex = 11;
            // 
            // pct4
            // 
            this.pct4.Location = new System.Drawing.Point(627, 494);
            this.pct4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(167, 108);
            this.pct4.TabIndex = 10;
            this.pct4.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.Location = new System.Drawing.Point(428, 494);
            this.pct3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(167, 108);
            this.pct3.TabIndex = 9;
            this.pct3.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.Location = new System.Drawing.Point(229, 494);
            this.pct2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(167, 108);
            this.pct2.TabIndex = 8;
            this.pct2.TabStop = false;
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(23, 494);
            this.pct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(167, 108);
            this.pct.TabIndex = 7;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pct_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(157, 279);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(191, 41);
            this.btnCrearUsuario.TabIndex = 6;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnSalir1
            // 
            this.btnSalir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir1.Location = new System.Drawing.Point(157, 373);
            this.btnSalir1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(191, 41);
            this.btnSalir1.TabIndex = 5;
            this.btnSalir1.Text = "Cancelar";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // btnEntrar1
            // 
            this.btnEntrar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar1.Location = new System.Drawing.Point(432, 373);
            this.btnEntrar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.chkMostrarContrasena1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMostrarContrasena1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarContrasena1.Location = new System.Drawing.Point(399, 279);
            this.chkMostrarContrasena1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMostrarContrasena1.Name = "chkMostrarContrasena1";
            this.chkMostrarContrasena1.Size = new System.Drawing.Size(225, 29);
            this.chkMostrarContrasena1.TabIndex = 4;
            this.chkMostrarContrasena1.Text = "Mostrar Contraseña";
            this.chkMostrarContrasena1.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena1.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena1_CheckedChanged);
            // 
            // lblContrasena1
            // 
            this.lblContrasena1.AutoSize = true;
            this.lblContrasena1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblContrasena1.Location = new System.Drawing.Point(321, 149);
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
            this.lblUsuario1.Location = new System.Drawing.Point(340, 20);
            this.lblUsuario1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(111, 37);
            this.lblUsuario1.TabIndex = 2;
            this.lblUsuario1.Text = "Usuario";
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(157, 73);
            this.txtUsuario1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(465, 23);
            this.txtUsuario1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 639);
            this.Controls.Add(this.grpLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I N G R E S O   G O A M";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
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
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnEntrar1;
        private System.Windows.Forms.CheckBox chkMostrarContrasena1;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.PictureBox pct4;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.TextBox txtContrasena1;
    }
}