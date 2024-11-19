using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestión_Museo
{
    public partial class Registro : Form
    {
        private const string ConnectionString = "Data Source=T0M1_PC\\SQLEXPRESS;Initial Catalog=pinturas;Integrated Security=True;Encrypt=False";
        public Registro()
        {
            InitializeComponent();
        }
        private void btnConfirmarNuevo_Click(object sender, EventArgs e)
        {
            // O(1) - Verificar si los campos están vacíos
            // O(1) - Validar que las contraseñas coincidan
            // O(1) - Comprobar si el usuario ya existe
            // O(1) - Registrar el nuevo usuario
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
                txtNuevoUsuario.BackColor = System.Drawing.Color.White;

            if (string.IsNullOrEmpty(contrasena))
            {
                txtContrasenaNueva.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
                txtContrasenaNueva.BackColor = System.Drawing.Color.White;

            if (string.IsNullOrEmpty(confirmarContrasena))
            {
                txtConfirmarContrasena.BackColor = System.Drawing.Color.Red;
                camposVacios = true;
            }
            else
                txtConfirmarContrasena.BackColor = System.Drawing.Color.White;

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
                MessageBox.Show("Hubo un error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool UsuarioYaExiste(string usuario)
        {
            // O(1) - Consultar si el usuario ya existe en la base de datos
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @nombre";

            using (SqlConnection Conexion = new SqlConnection(ConnectionString))
            {
                Conexion.Open();
                SqlCommand cmd = new SqlCommand(query, Conexion);
                cmd.Parameters.AddWithValue("nombre", usuario);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private bool RegistrarNuevoUsuario(string usuario, string contrasena)
        {
            // O(1) - Crear la consulta SQL para insertar el nuevo usuario
            // O(1) - Ejecutar la consulta SQL
            string query = "INSERT INTO Usuarios (Nombre, Contrasena) VALUES (@nombre, @contrasena)";

            using (SqlConnection Conexion = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, Conexion);
                    cmd.Parameters.AddWithValue("@nombre", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena); // Aquí puedes cifrar la contraseña antes de insertarla, si lo deseas

                    Conexion.Open();
                    cmd.ExecuteNonQuery();

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
            // O(1) - Cerrar el formulario y abrir el de login
            // Cerrar el formulario actual
        
            this.Close();
            // Mostrar el formulario FrmLogin
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasenaNueva.PasswordChar = txtContrasenaNueva.PasswordChar == '*' ? '\0' : '*';
            txtConfirmarContrasena.PasswordChar = txtConfirmarContrasena.PasswordChar == '*' ? '\0' : '*';
        }

        private void grpNuevoUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}