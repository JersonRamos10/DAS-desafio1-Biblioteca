using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class GlobalData
    {
        public static List<Libro> Libros { get; set; } = new List<Libro>();
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public static List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

    }

    public class Libro
    {
        public string IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Idioma { get; set; }
        public int NumeroEjemplares { get; set; }
        public bool Prestado { get; set; } //  
    }

    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

    public class Prestamo
    {
        public string IdPrestamo { get; set; }
        public string IdUsuario { get; set; }
        public string IdLibro { get; set; }
        public string Titulo { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
