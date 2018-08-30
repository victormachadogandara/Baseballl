using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseballl
{
    class equipo
    {
        public string Nombre {get; set;}
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public Estadio estadio { get; set; }

        public List<jugador> Jugadores { get; set; }

        public equipo()
        {
            Jugadores = new List<jugador>();

            Nombre = "Equipo Numero";
            Ciudad = "Ciudad Nueva";
            Entrenador = "Entrenador Nuevo";
        }

        public equipo(string nombre)
        {
            Jugadores = new List<jugador>();

            Nombre = Nombre;
            Ciudad = "Ciudad Nueva";
            Entrenador = "Entrenador Nuevo";

        }
    }
}
 