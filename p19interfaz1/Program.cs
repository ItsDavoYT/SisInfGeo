using System;
namespace _19interfaz1
{
    class Program
    {
        public interface IAnimal {
        string Nombre {get; set;}
        void Llorar();
        }

        class Perro : IAnimal {
            public Perro(string nombre) => Nombre = nombre;
            public string Nombre {get; set;} 
            public void Llorar() => Console.WriteLine(" Woff woff");
        }
            class Gato : IAnimal {
                public Gato(string nombre, string raza) => (Nombre,Raza) = (nombre, raza);
                public string Nombre {get; set;}
                public string Raza {get; set;}
                public void Llorar() => Console.WriteLine("miau miau");
            }
        static void Main(string[] args)
        {
            Console.WriteLine("primer ejemplo interfaces");
           Perro miperro = new Perro("el capitan");
              Console.whileLine($"el perro {miperro.Nombre}, llora asi: ");
            miperro.Llora();
             
            Gato migato = new Gato("cat","angora");
            Console.whileLine($"el gato {migato.Nombre}, de raza {migato.Raza} llora asi: ");
            migato.Llora();
        }
    }
}
