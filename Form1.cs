using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestión_Museo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public class Museo
        {
            // Credenciales del personal del museo
            private Dictionary<string, string> usuarios = new Dictionary<string, string>
            {
                { "Dario Borja Gamboa", "202110395" },
                { "Tomás Betancur Delgado", "202210279" },
                { "Samuel Bastidas Pamplona", "202210320" },
            };
            public bool ValidarUsuario(string nombre, string contrasena)
            {
                if (usuarios.ContainsKey(nombre) && usuarios[nombre] == contrasena)
                    return true;

                return ValidarUsuarioEnBaseDeDatos(nombre, contrasena);
            }
            private bool ValidarUsuarioEnBaseDeDatos(string nombre, string contrasena)
            {
                // Definir la cadena de conexión a la base de datos
                string connectionString = "Server=localhost;Database=museo;Uid=tu_usuario;Pwd=tu_contrasena;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre AND contrasena = @contrasena";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Definir los parámetros para evitar SQL injection
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@contrasena", contrasena);

                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count > 0; 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                        return false;
                    }
                }
            }
        }

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
            bool camposVacios = false;

            if (string.IsNullOrEmpty(txtUsuario1.Text))
            {
                txtUsuario1.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
            {
                txtUsuario1.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrEmpty(txtContrasena1.Text))
            {
                txtContrasena1.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
            {
                txtContrasena1.BackColor = System.Drawing.Color.White;
            }

            if (camposVacios)
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmPersonal form2 = new FrmPersonal();
            FrmUsuarioFinal form3 = new FrmUsuarioFinal();
            Museo museo = new Museo();
           

            if (museo.ValidarUsuario(txtUsuario1.Text, txtContrasena1.Text))
            {
                form2.ShowDialog();
            }
            else
            {
                try
                {
                    // Este Try-Catch verifica que en el caso de que el visitante ponga un string con forma de correo, lo deje ingresar al formulario correspondiente
                    string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (!Regex.IsMatch(txtUsuario1.Text, patronCorreo))
                        throw new Exception("Usuario o Contraseña no es válida.");

                    form3.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro CrearUsuario = new Registro();
            CrearUsuario.StartPosition = FormStartPosition.CenterScreen;
            CrearUsuario.ShowDialog();
        }
    }
}
