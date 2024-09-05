using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia.ClasesLibro
{
    internal class Miembro : Prestamo
    {
        public string Nombre { get; set; }
        public int NoDeMiembro { get; set; }
        public List<Prestamo> HistoriaPrestamo { get; set; }
        public Miembro(string Nombre, int NoDeMiembro,) 

        {
            this.Nombre = Nombre;
            this.NoDeMiembro = NoDeMiembro;
            this.HistoriaPrestamo = new List<Prestamo>();
        }

            public void Historial()
            {
                Console.WriteLine($"Historial de prestamos de {Nombre}:");
                foreach (var prestamo in HistoriaPrestamo)
                {
                    Console.WriteLine($"El Titulo es: {Nombre}, El codigo es: {CodigoLiblro}, Fecha Entrega: {FechaDeEntrega}, Fecha de Salida: {FechaDeSalida}");
                }
            }
        }

}