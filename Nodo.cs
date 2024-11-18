using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public class NodoImagen
{
    public int Id { get; set; }
    public Image Imagen { get; set; }

    public NodoImagen(int id, Image imagen)
    {
        Id = id;
        Imagen = imagen;
    }
}