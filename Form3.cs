using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Gestión_Museo
{
    public partial class FrmUsuarioFinal : Form
    {
        // Cadena de conexión a la base de datos
        private const string ConnectionString = "Data Source=T0M1_PC\\SQLEXPRESS;Initial Catalog=pinturas;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True";

        // Clase Pintura
        public class Pintura
        {
            public int ID { get; set; }
            public string Titulo_Obra { get; set; }
            public string Autor { get; set; }
            public int Año { get; set; }
            public string Genero { get; set; }
            public string Dimensiones { get; set; }
            public string Descripcion { get; set; }
            public byte[] Imagen { get; set; }
        }

        // Nodo de la lista doblemente enlazada
        public class Nodo
        {
            public Image Imagen { get; set; }
            public Nodo Siguiente { get; set; }
            public Nodo Anterior { get; set; }
        }
        // Listas para gestionar las pinturas e imágenes
        private LinkedList<Pintura> Pinturas;
        private Nodo cabeza;
        private Nodo cola;
        private Nodo nodoActual;

        public FrmUsuarioFinal()
        {
            InitializeComponent();
            Pinturas = new LinkedList<Pintura>();  // Inicializamos la lista de pinturas
        }
        private void FrmUsuarioFinal_Load(object sender, EventArgs e)
        {
            CargarPinturas();
            CargarImagenes();
        }
        // Cargar pinturas desde la base de datos a la lista enlazada
        private void CargarPinturas()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString))
                {
                    conexion.Open();
                    string query = "SELECT ID, Titulo_Obra, Autor, Año, Genero, Dimensiones, Imagen FROM ObrasArte";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pintura pintura = new Pintura
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Titulo_Obra = reader["Titulo_Obra"].ToString(),
                                Autor = reader["Autor"].ToString(),
                                Año = Convert.ToInt32(reader["Año"]),
                                Genero = reader["Genero"].ToString(),
                                Dimensiones = reader["Dimensiones"].ToString(),
                            };

                            Pinturas.AddLast(pintura);  // Agregar la pintura al final de la lista enlazada
                        }
                    }
                }

                if (Pinturas.Count > 0)
                {
                    MostrarPintura(Pinturas.First.Value); // Mostrar la primera pintura
                }
                else
                {
                    MessageBox.Show("No se encontraron pinturas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las pinturas: " + ex.Message);
            }
        }
        // Cargar las imágenes desde la base de datos en una lista doblemente enlazada
        private void CargarImagenes()
        {
            try
            {
                string query = "SELECT Imagen FROM ObrasArte"; // Consulta para obtener las imágenes
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpiar la lista enlazada antes de agregar nuevas imágenes
                        cabeza = null;
                        cola = null;
                        nodoActual = null;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                byte[] imageBytes = reader["Imagen"] as byte[]; // Datos de la imagen

                                if (imageBytes != null && imageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        Image image = Image.FromStream(ms);
                                        Nodo nuevoNodo = new Nodo { Imagen = image };

                                        if (cabeza == null)
                                        {
                                            cabeza = nuevoNodo;
                                            cola = nuevoNodo;
                                        }
                                        else
                                        {
                                            cola.Siguiente = nuevoNodo;
                                            nuevoNodo.Anterior = cola;
                                            cola = nuevoNodo;
                                        }
                                    }
                                }
                                else
                                    MessageBox.Show("Se encontraron datos nulos en la columna Imagen.");
                            }

                            if (cabeza != null)
                            {
                                nodoActual = cabeza;
                                pictureBoxPintura.Image = nodoActual.Imagen;
                            }
                            else
                                MessageBox.Show("No se encontraron imágenes válidas.");
                        }
                        else
                            MessageBox.Show("No se encontraron imágenes en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las imágenes: " + ex.Message);
            }
        }
        // Mostrar pintura seleccionada
        private void MostrarPintura(Pintura pintura)
        {
            txtNombreSeleccionado.Text = pintura.Titulo_Obra;
            txtInfoCompleta.Text = $"Nombre: {pintura.Titulo_Obra}\n" +
                                   $"Artista: {pintura.Autor}\n" +
                                   $"Año: {pintura.Año}\n" +
                                   $"Género: {pintura.Genero}\n" +
                                   $"Dimensiones: {pintura.Dimensiones}\n";

            if (pintura.Imagen != null && pintura.Imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(pintura.Imagen))
                {
                    pictureBoxPintura.Image = Image.FromStream(ms);
                }
            }
            else
                pictureBoxPintura.Image = null;
        }
        // Navegar a la siguiente pintura
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                pictureBoxPintura.Image = nodoActual.Imagen;
            }
            else
                MessageBox.Show("No hay más imágenes.");
        }
        // Navegar a la pintura anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.Anterior != null)
            {
                nodoActual = nodoActual.Anterior;
                pictureBoxPintura.Image = nodoActual.Imagen;
            }
            else
                MessageBox.Show("Ya estás en la primera imagen.");
        }
        // Finalizar y cerrar la aplicación
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
        // Botón para recargar las pinturas
        private void pbBuscar_Click(object sender, EventArgs e)
        {
            CargarPinturas(); // Volver a cargar las pinturas (si es necesario)
        }
    }
}