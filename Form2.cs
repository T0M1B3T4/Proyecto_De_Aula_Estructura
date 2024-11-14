using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace Gestión_Museo
{
    public partial class FrmPersonal : Form
    {
        LinkedList<Image> Pinturas;
        LinkedListNode<Image> Pintura_Actual;
        List<Categoria> Categorias;

        public FrmPersonal()
        {
            InitializeComponent();
            Pinturas = new LinkedList<Image>();
            Categorias = new List<Categoria>();
        }

        private void FrmPersonal_Load(object sender, EventArgs e) { }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            if (Pintura_Actual?.Next != null)
            {
                Pintura_Actual = Pintura_Actual.Next;
                pctImagen.Image = Pintura_Actual.Value;
            }
            else
                MessageBox.Show("No hay más pinturas.");
        }

        private void btnAñadir_Pintura_Click(object sender, EventArgs e)
        {
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
            try
            {
                using (MySqlConnection conexionBD = new MySqlConnection("server=localhost;database=museo;uid=root;pwd=1234;"))
                {
                    conexionBD.Open();
                    string query = @"INSERT INTO Pinturas (Titulo_Obra, Autor, Año, Genero, Dimensiones, Fecha_Ingreso, Movimiento_Artistico, Imagen) 
                             VALUES (@Titulo, @Autor, @Año, @Genero, @Dimensiones, @Fecha_Ingreso, @Movimiento_Artistico, @Imagen)";

                    MySqlCommand comando = new MySqlCommand(query, conexionBD);
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
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un título de pintura.");
                    return;
                }

                using (MySqlConnection conexionBD = new MySqlConnection("server=localhost;database=museo;uid=root;pwd=1234;"))
                {
                    conexionBD.Open();
                    string query = "SELECT Imagen FROM Pinturas WHERE Titulo_Obra = @Titulo";

                    MySqlCommand comando = new MySqlCommand(query, conexionBD);
                    comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text);

                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        byte[] imagenBytes = (byte[])reader["Imagen"];
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            Image imagenCargada = Image.FromStream(ms);
                            pctImagen.Image = imagenCargada;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pintura no encontrada.");
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
                    using (MySqlConnection conexionBD = new MySqlConnection("server=localhost;database=museo;uid=root;pwd=1234;"))
                    {
                        conexionBD.Open();

                        // Query para eliminar toda la fila (toda la información) asociada a la pintura
                        string query = "DELETE FROM Pinturas WHERE Titulo_Obra = @Titulo";

                        MySqlCommand comando = new MySqlCommand(query, conexionBD);
                        comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pintura eliminada con éxito.");
                            // Limpiar los campos del formulario
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la pintura para eliminar.");
                        }
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
            {
                // Si el usuario responde que no, salir de la aplicación
                Application.Exit();
            }
        }

    }
}
