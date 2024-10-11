using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Console;
using static System.Convert;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestión_Museo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void grpLogin_Enter(object sender, EventArgs e)
        { }
        //Credenciales Del "Personal Del Museo"
        private Dictionary<string, string> usuarios = new Dictionary<string, string> //Implementación de HashMap para gestionar mejor las claves de acceso del personal del museo
        {
            { "Dario Borja Gamboa", "202110395" },
            { "Tomás Betancur Delgado", "202210279" },
            { "Samuel Bastidas Pamplona", "202210320" },
            { "Andrés Camilo Vélez Moncada", "202020074" }
        };
        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void chkMostrarContrasena1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContrasena1.PasswordChar == '*')
                txtContrasena1.PasswordChar = '\0';
            else if (txtContrasena1.PasswordChar == '\0')
                txtContrasena1.PasswordChar = '*';
        }
        private void btnEntrar1_Click(object sender, EventArgs e)
        {
            FrmPersonal form2 = new FrmPersonal();
            FrmUsuarioFinal form3 = new FrmUsuarioFinal();

            if (usuarios.ContainsKey(txtUsuario1.Text) && usuarios[txtUsuario1.Text] == txtContrasena1.Text)
                form2.ShowDialog();

            else
                try
                {
                    // Este Try-Catch verifica que en el caso de que el visitante ponga un string con forma de correo, lo deje ingresar al formulario correspondiente
                    string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (!Regex.IsMatch(txtUsuario1.Text, patronCorreo))
                        throw new Exception("El formato del correo electrónico es inválido.");

                    form3.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}