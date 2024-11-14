using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestión_Museo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnConfirmarNuevo_Click(object sender, EventArgs e)
        {
            string usuario = txtNuevoUsuario.Text;
            string contrasena = txtContrasenaNueva.Text;
            string confirmarContrasena = txtConfirmarContrasena.Text;

            bool camposVacios = false;
            if (string.IsNullOrEmpty(usuario))
            {
                txtNuevoUsuario.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
            {
                txtNuevoUsuario.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                txtContrasenaNueva.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
            {
                txtContrasenaNueva.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrEmpty(confirmarContrasena))
            {
                txtConfirmarContrasena.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
            {
                txtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            }

            if (camposVacios)
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UsuarioYaExiste(usuario))
            {
                MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar a la función para guardar el nuevo usuario en la base de datos
            if (RegistrarNuevoUsuario(usuario, contrasena))
            {
                MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioYaExiste(string usuario)
        {
            string connectionString = "server=localhost;database=museo;uid=root;pwd=1234;";  // Cambia esto por tu cadena de conexión real
            string query = "SELECT COUNT(*) FROM Usuarios WHERE nombre = @nombre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count > 0; // Si el usuario existe, devuelve true
            }
        }

        private bool RegistrarNuevoUsuario(string usuario, string contrasena)
        {
            string connectionString = "server=localhost;database=museo;uid=root;pwd=1234;";  // Cambia esto por tu cadena de conexión real
            string query = "INSERT INTO Usuarios (nombre, Contrasena) VALUES (@nombre, @contrasena)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena); // Aquí puedes cifrar la contraseña antes de insertarla, si lo deseas

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void btnCarcelarUsuario_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();

            // Mostrar el formulario FrmLogin
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
