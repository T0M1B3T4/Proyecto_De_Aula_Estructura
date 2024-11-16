using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Gestión_Museo;
using System.Data.SqlClient;

namespace Gestión_Museo
{
    public partial class FrmUsuarioFinal : Form
    {
        private LinkedList<Pintura> Pinturas;
        private LinkedListNode<Pintura> Pintura_Actual;
        private string ConnectionString = "Data Source=T0M1_PC\\SQLEXPRESS;Initial Catalog=pinturas;Integrated Security=True;Encrypt=False"; // Conexión a la base de datos

        public FrmUsuarioFinal()
        {
            InitializeComponent();
            Pinturas = new LinkedList<Pintura>();
        }
        public class Pintura
        {
            public int Id_Obra { get; set; }
            public string Titulo_Obra { get; set; }
            public string Autor { get; set; }
            public int Año { get; set; }
            public string Genero { get; set; }
            public string Dimensiones { get; set; }
            public string Descripcion { get; set; }
            public byte[] Imagen { get; set; } // Imagen como arreglo de bytes
        }
        private void FrmUsuarioFinal_Load(object sender, EventArgs e)
        {  CargarPinturas(); }
        private void CargarPinturas()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString))
                {
                    conexion.Open();

                    string query = "SELECT From ObrasArte Id_Obra, Titulo_Obra, Autor, Año, Genero, Dimensiones, Imagen FROM Pinturas";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pintura pintura = new Pintura
                            {
                                Id_Obra = Convert.ToInt32(reader["Id_Obra"]),
                                Titulo_Obra = reader["Titulo_Obra"].ToString(),
                                Autor = reader["Autor"].ToString(),
                                Año = Convert.ToInt32(reader["Año"]),
                                Genero = reader["Genero"].ToString(),
                                Dimensiones = reader["Dimensiones"].ToString(),
                                Imagen = reader["Imagen"] as byte[]
                            };
                            Pinturas.AddLast(pintura);
                        }
                    }
                }
                if (Pinturas.Count > 0)
                {
                    Pintura_Actual = Pinturas.First;
                    MostrarPintura(Pintura_Actual.Value);
                }
                else
                    MessageBox.Show("No se encontraron pinturas en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las pinturas: " + ex.Message);
            }
        }
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
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Pintura_Actual?.Next != null)
            {
                Pintura_Actual = Pintura_Actual.Next;
                MostrarPintura(Pintura_Actual.Value);
            }
            else
                MessageBox.Show("No hay más pinturas.");
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (Pintura_Actual?.Previous != null)
            {
                Pintura_Actual = Pintura_Actual.Previous;
                MostrarPintura(Pintura_Actual.Value);
            }
            else
                MessageBox.Show("No hay pinturas anteriores.");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string terminoBusqueda = txtBusqueda.Text.Trim().ToLower();

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString))
                {
                    conexion.Open();

                    bool esNumerico = int.TryParse(terminoBusqueda, out int idBusqueda);
                    string query = esNumerico
                        ? "SELECT Titulo_Obra, Autor, Año, Genero, Dimensiones, Imagen FROM ObrasArte WHERE Titulo_Obra = @Busqueda"
                        : "SELECT Titulo_Obra, Autor, Año, Genero, Dimensiones, Imagen FROM ObrasArte WHERE LOWER(Titulo_Obra) LIKE @Busqueda";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    if (esNumerico)
                        comando.Parameters.AddWithValue("@Busqueda", idBusqueda);
                    else
                        comando.Parameters.AddWithValue("@Busqueda", "%" + terminoBusqueda + "%");
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Pintura_Actual = null;
                            foreach (var nodo in Pinturas)
                            {
                                if (nodo.Titulo_Obra.ToLower().Contains(terminoBusqueda))
                                {
                                    Pintura_Actual = new LinkedListNode<Pintura>(nodo);
                                    break;
                                }
                            }

                            if (Pintura_Actual != null)
                            {
                                MostrarPintura(Pintura_Actual.Value);
                            }
                            else
                                MessageBox.Show("Pintura no encontrada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la pintura: " + ex.Message);
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
        private void btnfiltro_Click(object sender, EventArgs e) { }
    }
}