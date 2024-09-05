using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia.ClasesLibro
{
    internal class Prestamo : Libros
    {
        public readonly DateTime FechaPrestamo;
        public readonly DateTime FechaDevolucion;

        public virtual void RealizarPrestamo()
        {
            Console.WriteLine("Realizando el préstamo de un libro...");
        }
    }
}
