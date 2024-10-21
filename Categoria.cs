using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Museo
{
    class Categoria
    {    
        public string Nombre { get; set; }
        public LinkedList<Image> Pinturas { get; set; }

        public Categoria(string nombre) 
        {
            this.Nombre = nombre;
            this.Pinturas = new LinkedList<Image>();
        }
    }
}