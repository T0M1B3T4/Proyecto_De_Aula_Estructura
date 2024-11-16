using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            private Dictionary<string, (string contrasena, bool esAdministrador)> usuariosLocales = new Dictionary<string, (string, bool)>
            {
                { "Dario Borja Gamboa", ("202110395", true) },
                { "Tomás Betancur Delgado", ("202210279", false) },
                { "Samuel Bastidas Pamplona", ("202210320", false) },
            };

            public (bool valido, bool esAdministrador) ValidarUsuario(string nombre, string contrasena)
            {
                // Verificar en usuarios locales
                if (usuariosLocales.ContainsKey(nombre))
                {
                    (string contrasenaGuardada, bool esAdministrador) = usuariosLocales[nombre];
                    if (contrasenaGuardada == contrasena)
                    {
                        return (true, esAdministrador);
                    }
                }

                // Verificar en la base de datos
                return ValidarUsuarioEnBaseDeDatos(nombre, contrasena);
            }

            private (bool valido, bool esAdministrador) ValidarUsuarioEnBaseDeDatos(string nombre, string contrasena)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT RolAdministrador FROM Usuarios WHERE nombre = @nombre AND contrasena = @contrasena";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@contrasena", contrasena);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Leer RolAdministrador como booleano
                                    bool esAdministrador = reader.GetBoolean(0);
                                    return (true, esAdministrador);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    }
                }
                return (false, false);
            }
        }

        private void btnEntrar1_Click(object sender, EventArgs e)
        {
            // Verificar campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario1.Text) || string.IsNullOrWhiteSpace(txtContrasena1.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usuario = txtUsuario1.Text.Trim();
            string contrasena = txtContrasena1.Text;

            Museo museo = new Museo();
            (bool valido, bool esAdministrador) resultado = museo.ValidarUsuario(usuario, contrasena);

            if (resultado.valido)
            {
                // Redirigir según el rol del usuario
                if (resultado.esAdministrador)
                {
                    FrmPersonal frmPersonal = new FrmPersonal();
                    this.Hide();
                    frmPersonal.ShowDialog();
                    this.Show();
                }
                else
                {
                    FrmUsuarioFinal frmUsuarioFinal = new FrmUsuarioFinal();
                    this.Hide();
                    frmUsuarioFinal.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMostrarContrasena1_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena1.PasswordChar = txtContrasena1.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registroForm = new Registro();
            registroForm.StartPosition = FormStartPosition.CenterScreen;
            registroForm.ShowDialog();
            this.Show();
        }
    }
}