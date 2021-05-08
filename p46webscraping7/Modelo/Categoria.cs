using System.Collections.Generic;

namespace _44webscraping5
{
    public class Categoria {
        public int CategoriaID {get; set;}
        public string Nombre {get; set;}
        public string Url {get; set;}
          public List<Libro> Libros {get; set;} // Campo de navegacion
        public override string ToString() =>
            $"\nId: {CategoriaID}\nNombre: {Nombre}\nUrl: {Url}";
    }
}

// Relacion de 1 a Muchos
// De esta lado en esta tabla 
//   Categoria -> Libro