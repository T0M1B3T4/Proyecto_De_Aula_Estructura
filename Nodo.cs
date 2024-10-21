using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Museo
{
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int dato)
        {
            this.Dato = dato;
            this.Siguiente = null;
        }
    }
}