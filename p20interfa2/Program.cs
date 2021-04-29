using System;

namespace _20interfa2
{
    class Program
    {
        //clase orgranismo
        public class Organismo{
            public Organismo(string nombre)=>Nombre=nombre;
        public string Nombre {get; set;}
        public void Respiracion() => Console.WriteLine("Respirando"); 
        public void Movimiento() => Console.WriteLine("Moviendose"); 
        public void Crecimiento() => Console.WriteLine("Creciendo"); 
        }
public interface IAnimales {
    void MultiCelular();
    void SangreCaliente();
}
public interface ICanino : IAnimales{
void Correr();
void CuatroPatas();
}

public interface IAve : IAnimales{
    void Volar();
    void DosPatas();

}
        public class Perro : Organismo, ICanino {
            public Perro(string nombre) : base(nombre){}
            public void MultiCelular()=>Console.WriteLine("Multicelular perro");
            public void SangreCaliente()=>Console.WriteLine("sangre calinte perro");
            public void Correr()=>Console.WriteLine("Corre perro");
            public void CuatroPatas()=>Console.WriteLine("Cuatro patas perro");
        }
        public class Perico : Organismo, IAve {
            public Perico(string nombre) : base(nombre) {}
             public void MultiCelular()=>Console.WriteLine("Multicelular Perico");
            public void SangreCaliente()=>Console.WriteLine("sangre calinte");
            public void Volar()=>Console.WriteLine("Vuela");
            public void DosPatas()=>Console.WriteLine("el Ave tiene dos patas");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("segundo ejemplo de interfaces!");
            Perro miperro = new Perro("lassie");
            Console.WriteLine($"mi perro llamado {miperro.Nombre} esta haciendo lo siguiente");
            miperro.Respiracion();
            miperro.Crecimiento();
            miperro.Movimiento();
            miperro.MultiCelular();
            miperro.SangreCaliente();
            miperro.Correr();
            miperro.CuatroPatas();

            Perico miperico = new Perico("Sparrow");
            Console.WriteLine($"mi perico se llamado: {miperico.Nombre}, esta haciendo lo siguiente ");
            miperico.Respiracion();
            miperico.Crecimiento();
            miperico.Movimiento();
            miperico.MultiCelular();
            miperico.SangreCaliente();
            miperico.Volar();
            miperico.DosPatas();
        }
    }
}
