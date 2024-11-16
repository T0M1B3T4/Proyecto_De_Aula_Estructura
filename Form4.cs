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
            // Cerrar el formulario actual
            this.Close();
            // Mostrar el formulario FrmLogin
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}