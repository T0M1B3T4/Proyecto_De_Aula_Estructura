using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Gestión_Museo
{
    public partial class FrmPersonal : Form
    {
        private const string ConnectionString = "Data Source=T0M1_PC\\SQLEXPRESS;Initial Catalog=pinturas;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True";

        LinkedList<Image> Pinturas;
        LinkedListNode<Image> Pintura_Actual;
        List<Categoria> Categorias;

        public FrmPersonal()
        {
            InitializeComponent();
            Pinturas = new LinkedList<Image>();// O(1)
            Categorias = new List<Categoria>();// O(1)
        }

        private void FrmPersonal_Load(object sender, EventArgs e) { }// O(1)

        private void btnAñadir_Pintura_Click(object sender, EventArgs e)
        {
            // O(1) - Abrir el cuadro de diálogo y cargar la imagen
            // O(1) - Agregar imagen a la lista enlazada
            // O(1) - Actualizar la imagen mostrada
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Imagenes|*.jpg; *.png; *.jpeg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Title = "Seleccionar Imagen"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image Nueva_Pintura = Image.FromFile(ofd.FileName);
                Pinturas.AddLast(Nueva_Pintura);
                Pintura_Actual = Pinturas.Last;

                pctImagen.Image = Pintura_Actual.Value;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // O(1) - Validación de campos
            // O(n) - Convertir la imagen a bytes (donde n es el tamaño de la imagen)
            // O(1) - Guardar los datos en la base de datos
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text) ||
                    string.IsNullOrWhiteSpace(txtAno.Text) || string.IsNullOrWhiteSpace(txtGenero.Text) ||
                    string.IsNullOrWhiteSpace(txtDimensiones.Text) || string.IsNullOrWhiteSpace(txtFechaIngreso.Text) ||
                    string.IsNullOrWhiteSpace(txtMovimiento.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    pctImagen.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imagenBytes = ms.ToArray();

                    // Guardar la pintura en la base de datos
                    GuardarPintura(imagenBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la pintura: " + ex.Message);
            }
        }
        private void GuardarPintura(byte[] imagenBytes)
        {
            // O(1) - Conexión a la base de datos
            // O(1) - Crear la consulta SQL
            // O(1) - Ejecutar el comando de inserción
            try
            {
                using (SqlConnection Conexion = new SqlConnection(ConnectionString))
                {
                    Conexion.Open();
                    string query = @"INSERT INTO ObrasArte (Titulo_Obra, Autor, Año, Genero, Dimensiones, Fecha_Ingreso, Movimiento_Artistico, Imagen) 
                             VALUES (@Titulo, @Autor, @Año, @Genero, @Dimensiones, @Fecha_Ingreso, @Movimiento_Artistico, @Imagen)";

                    SqlCommand comando = new SqlCommand(query, Conexion);
                    comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                    comando.Parameters.AddWithValue("@Autor", txtAutor.Text);
                    comando.Parameters.AddWithValue("@Año", int.Parse(txtAno.Text));
                    comando.Parameters.AddWithValue("@Genero", txtGenero.Text);
                    comando.Parameters.AddWithValue("@Dimensiones", txtDimensiones.Text);
                    comando.Parameters.AddWithValue("@Fecha_Ingreso", DateTime.Parse(txtFechaIngreso.Text));
                    comando.Parameters.AddWithValue("@Movimiento_Artistico", txtMovimiento.Text);
                    comando.Parameters.AddWithValue("@Imagen", imagenBytes);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Pintura guardada con éxito en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la pintura: " + ex.Message);
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            // O(1) - Verificar los campos
            // O(1) - Consultar en la base de datos
            // O(1) - Leer los resultados de la consulta
            // O(n) - Convertir la imagen a Image (donde n es el tamaño de la imagen)
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text) && string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, ingrese el ID de la obra o el título de la pintura.");
                    return;
                }

                using (SqlConnection Conexion = new SqlConnection(ConnectionString))
                {
                    Conexion.Open();

                    string query = "SELECT * FROM ObrasArte WHERE Titulo_Obra = @TituloObra OR ID = @IdObra";

                    using (SqlCommand comando = new SqlCommand(query, Conexion))
                    {
                        comando.Parameters.AddWithValue("@TituloObra", txtTitulo.Text);
                        comando.Parameters.AddWithValue("@IdObra", txtId.Text);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Rellenar los campos del formulario con los datos de la obra
                                    txtId.Text = reader["ID"].ToString();
                                    txtTitulo.Text = reader["Titulo_Obra"].ToString();
                                    txtAutor.Text = reader["Autor"].ToString();
                                    txtAno.Text = reader["Año"].ToString();
                                    txtGenero.Text = reader["Genero"].ToString();
                                    txtDimensiones.Text = reader["Dimensiones"].ToString();
                                    txtFechaIngreso.Text = Convert.ToDateTime(reader["Fecha_Ingreso"]).ToString("yyyy-MM-dd");
                                    txtMovimiento.Text = reader["Movimiento_Artistico"].ToString();

                                    // Convertir la imagen de bytes a Image y mostrarla
                                    if (reader["Imagen"] != DBNull.Value)
                                    {
                                        byte[] imagenBytes = (byte[])reader["Imagen"];
                                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                                        {
                                            pctImagen.Image = Image.FromStream(ms);
                                        }
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Pintura no encontrada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pintura: " + ex.Message);
            }
        }
        private void btnEliminar_Pintura_Click(object sender, EventArgs e)
        {
            // O(1) - Verificar campos
            // O(1) - Mostrar mensaje de confirmación
            // O(1) - Eliminar de la base de datos
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un título de pintura para eliminar.");
                    return;
                }
                // Confirmar si el usuario está seguro de eliminar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar esta pintura?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection Conexion = new SqlConnection(ConnectionString))
                    {
                        Conexion.Open();

                        // Query para eliminar toda la fila (toda la información) asociada a la pintura
                        string query = "DELETE FROM ObrasArte WHERE Titulo_Obra = @Titulo";

                        SqlCommand comando = new SqlCommand(query, Conexion);
                        comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pintura eliminada con éxito.");
                            // Limpiar los campos del formulario
                            LimpiarCampos();
                        }
                        else
                            MessageBox.Show("No se encontró la pintura para eliminar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la pintura: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            // O(1) - Limpiar todos los campos
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAno.Clear();
            txtGenero.Clear();
            txtDimensiones.Clear();
            txtFechaIngreso.Clear();
            txtMovimiento.Clear();
            pctImagen.Image = null;
        }
        private void grpInformacion_Enter(object sender, EventArgs e) { }
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver a iniciar sesión?", "Confirmar salida", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
                this.Hide();
                // Usar Clear() para limpiar el TextBox
            }
            else
                // Si el usuario responde que no, salir de la aplicación
                Application.Exit();
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void pctImagen_Click(object sender, EventArgs e)
        {

        }
    }
}