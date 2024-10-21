using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Convert;
using static System.Console;
using System.IO;
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
        private void FrmPersonal_Load(object sender, EventArgs e)
        { }
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg; *.png; *.jpeg";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Title = "Seleccionar Imagen";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image Nueva_Pintura = Image.FromFile(ofd.FileName);
                pctImagen.Image = Image.FromFile(ofd.FileName);
                Pinturas.AddLast(Nueva_Pintura);
                Pintura_Actual = Pinturas.Last;

                pctImagen.Image = Pintura_Actual.Value;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pctImagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            MySqlConnection conexionBD = new MySqlConnection();
            conexionBD.Open();
            try
            {
                string query = @"INSERT INTO Pinturas (Titulo_Obra, Autor, Año, Genero, Dimensiones, Fecha_Ingreso, Movimiento_Artistico, ImagenPath) 
                                     VALUES (@Titulo, @Autor, @Año, @Genero, @Dimensiones, @Fecha_Ingreso, @Movimiento_Artistico, @ImagenPath)";
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                comando.Parameters.AddWithValue("@Autor", txtAutor.Text);
                comando.Parameters.AddWithValue("@Año", int.Parse(txtAno.Text));
                comando.Parameters.AddWithValue("@Genero", txtGenero.Text);
                comando.Parameters.AddWithValue("@Dimensiones", txtDimensiones.Text);
                comando.Parameters.AddWithValue("@Fecha_Ingreso", txtFechaIngreso.Text.ToString());
                comando.Parameters.AddWithValue("@Movimiento_Artistico", txtMovimiento.Text);
                comando.Parameters.AddWithValue("@ImagenPath", txtImagePath);
                pctImagen.Image = null;
                comando.ExecuteNonQuery();
                MessageBox.Show("Pintura guardada con éxito en la base de datos.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar la pintura: " + ex.Message);
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = new MySqlConnection();
            try
            {
                conexionBD.Open();
                string query = "SELECT ImagenPath FROM Pinturas WHERE Titulo_Obra = @Titulo";

                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.Parameters.AddWithValue("@Titulo", txtTitulo.Text);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    string imagePath = reader["ImagenPath"].ToString();
                    Image imagenCargada = Image.FromFile(imagePath);
                    pctImagen.Image = imagenCargada;
                }
                else
                    MessageBox.Show("Pintura no encontrada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pintura: " + ex.Message);
            }
        }
        private void grpInformacion_Enter(object sender, EventArgs e)
        { }
    }
}