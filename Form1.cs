using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestión_Museo
{
    public partial class FrmLogin : Form
    {
        private const string ConnectionString = "Data Source=T0M1_PC\\SQLEXPRESS;Initial Catalog=pinturas;Integrated Security=True;Encrypt=False";

        public FrmLogin()
        {
            InitializeComponent();
        }
        public class Museo
        {
            private Dictionary<string, string> usuarios = new Dictionary<string, string>
            {
                { "Darío Borja Gamboa", "202110395" },
                { "Tomás Betancur Delgado", "202210279" },
                { "Samuel Bastidas Pamplona", "202210320" },
            };

            public string ValidarUsuarioYObtenerRol(string nombre, string contrasena)
            {
                // Complejidad promedio: O(1) para buscar en el diccionario + O(log m) para consultar la base de datos.
                // Complejidad total: O(log m).

                // Primero, validamos si el usuario es uno de los locales con rol "Admin"
                if (usuarios.ContainsKey(nombre) && usuarios[nombre] == contrasena)
                {
                    return "Admin"; // Si es un usuario local, se asume rol "Admin"
                }

                // Si no es un usuario local, se valida en la base de datos para obtener el rol
                string rol = ObtenerRolUsuario(nombre, contrasena);

                // Si el rol obtenido no es nulo, se devuelve ese rol
                return rol != null ? rol : "Usuario"; // Si no se obtiene un rol, se devuelve "Usuario" por defecto
            }
            private string ObtenerRolUsuario(string nombre, string contrasena)
            {
                // Complejidad promedio: O(log m) si las columnas están indexadas.
                // Complejidad peor caso: O(m) si no hay índices y la base de datos tiene que recorrer toda la tabla.

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Rol FROM Usuarios WHERE Nombre = @nombre AND contrasena = @contrasena";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombre", nombre.Trim());
                            command.Parameters.AddWithValue("@contrasena", contrasena.Trim());

                            var rol = command.ExecuteScalar();
                            return rol != null ? rol.ToString() : null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                        return null;
                    }
                }
            }
        }
        private void btnEntrar1_Click(object sender, EventArgs e)
        {// Complejidad promedio: O(log m) dominado por la llamada a ValidarUsuario.

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(txtUsuario1.Text) || string.IsNullOrEmpty(txtContrasena1.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario1.BackColor = string.IsNullOrEmpty(txtUsuario1.Text) ? System.Drawing.Color.Red : System.Drawing.Color.White;
                txtContrasena1.BackColor = string.IsNullOrEmpty(txtContrasena1.Text) ? System.Drawing.Color.Red : System.Drawing.Color.White;
                return;
            }
            Museo museo = new Museo();
            string rol = museo.ValidarUsuarioYObtenerRol(txtUsuario1.Text, txtContrasena1.Text);

            if (!string.IsNullOrEmpty(rol))
            {
                if (rol == "Admin")
                {
                    FrmPersonal form2 = new FrmPersonal();
                    form2.ShowDialog();
                }
                else if (rol == "Usuario")
                {
                    FrmUsuarioFinal form3 = new FrmUsuarioFinal();
                    form3.ShowDialog();
                }
                else
                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Usuario o Contraseña no válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void chkMostrarContrasena1_CheckedChanged(object sender, EventArgs e)
        {
            // Complejidad: O(1).
            txtContrasena1.PasswordChar = txtContrasena1.PasswordChar == '*' ? '\0' : '*';
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // Complejidad: O(1).
            this.Hide();
            Registro crearUsuario = new Registro();
            crearUsuario.StartPosition = FormStartPosition.CenterScreen;
            crearUsuario.ShowDialog();
        }

        private void pct_Click(object sender, EventArgs e)
        {
            
        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}