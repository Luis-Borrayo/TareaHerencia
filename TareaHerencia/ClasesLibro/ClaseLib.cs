using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia.ClasesLibro
{
    internal class Libro : Libros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string Categoria { get; set; }
        public Libro(string Titulo, string Autor, int AñoPublicacion, string Categoria)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.AñoPublicacion = AñoPublicacion;
            this.Categoria = Categoria;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Año de publicación: {AñoPublicacion}, Categoría: {Categoria}");
        }

    }
    class LibroFIsico : Libro
    {
        public int CodigoProducto { get; set; }
        public string UbicacionBiblioteca { get; set; }
        public LibroFIsico(string Titulo, string Autor, int AñoPublicacion, string Categoria, int CodigoProducto, string UbicacionBiblioteca)
            : base(Titulo, Autor, AñoPublicacion, Categoria)
        {
            this.CodigoProducto = CodigoProducto;
            this.UbicacionBiblioteca = UbicacionBiblioteca;
        }
        public virtual void MostrarInformacion()
        {
            base.MostrarInformacion();
        Console.WriteLine ($"Codigo del libro: {CodigoProducto}, Ubicación de la biblioteca: {UbicacionBiblioteca} "); }
    }

    class LibroVirtual : Libro
    {
        public double TamanoArchivo { get; set; }
        public string Formato { get; set; }
        public LibroVirtual(string Titulo, string Autor, int AñoPublicacion, string Categoria, string TamañoArchivo, string Formato)
            : base(Titulo, Autor, AñoPublicacion, Categoria)
        { 
          this.TamanoArchivo = TamanoArchivo;
          this.Formato = Formato;
        }
        public virtual void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tamaño del Archivo: {TamanoArchivo}MB, Formato del Archivo: {Formato} ");
        }

    }

}

