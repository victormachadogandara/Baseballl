using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseballl
{
    class jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public jugador ()
        {
            Nombre = "Midoriya";
            Numero = "420";
        }

        public jugador(string nombre)
        {
            Nombre = nombre;
            Numero = "420";
        }
    }
}
