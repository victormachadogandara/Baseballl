using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseballl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<equipo> equipos = new List<equipo>();
            equipo equipo1 = new equipo();
            equipo1.Nombre = "Los bunkers";
            equipo1.Ciudad = "Saltadilla";

            equipo1.estadio = new Estadio();
            equipo1.estadio.Nombre = "Shea Stadium";
            equipo1.estadio.Capacidad = 123456;
            equipo1.estadio.Direccion = "dos puntos uve";

            equipo1.Entrenador = "(._.)";
            equipo1.Jugadores.Add(new jugador("Sebas"));
            equipo1.Jugadores.Add(new jugador("Andres"));
            equipo1.Jugadores.Add(new jugador("Juan"));
            equipo1.Jugadores.Add(new jugador("Reynaldo"));
            equipo1.Jugadores.Add(new jugador("Arturo"));
            equipos.Add(equipo1);


            equipo equipo2 = new equipo();
            equipo2.Nombre = "blue Team";
            equipo2.Ciudad = "asdf movie";
            equipo2.Entrenador = "mr. p";
            equipo2.Jugadores.Add(new jugador("Pene"));        //AGRGAR DATO A LISTA DE JUGADORES
            equipo2.Jugadores.Add(new jugador("Meza"));
            equipo2.Jugadores.Add(new jugador("Andrea"));
            equipo2.Jugadores.Add(new jugador("Jose"));
            equipo2.Jugadores.Add(new jugador("Patiño"));
            equipos.Add(equipo2);                              //AGREGAR EL DATO A LA LISTA DE MATERIAS
            foreach (equipo equipo in equipos)
            {
                Console.WriteLine("Nombre: " + equipo.Nombre);
                Console.WriteLine("Ciudad: " + equipo.Ciudad);
                Console.WriteLine("Entrenador: " + equipo.Entrenador);

                if (equipo.estadio != null)
                {
                    Console.WriteLine("Nombre" +equipo.estadio.Nombre);
                    Console.WriteLine("Nombre" + equipo.estadio.Direccion);
                    Console.WriteLine("Nombre" + equipo.estadio.Capacidad);
                }
                else
                {
                    Console.WriteLine("No todos los equipos tienen estadio .l.");
                }

                foreach (jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("Jugador: " + jugador.Nombre);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
