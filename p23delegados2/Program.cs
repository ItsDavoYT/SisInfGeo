using System;
//ejemplo delegado multicast
namespace _23delegados2
{
    public delegate void MideLegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MideLegado d1,d2, d3, d;

            d1 = Mensaje.Mensaje1;
            d2 = Mensaje.Mensaje2;
            d3 = (string msj) => Console.WriteLine($"{msj} - pagar todo ");
            d = d1 + d2;
            d("el peje");
            d += d3;
            d("el borolas");
            d -= d2;
            d("peña");
            d -= d1;
            d("Tello");
        }
    }
        public class Mensaje{
            public static void Mensaje1(string msj) => Console.WriteLine($"{msj} - lleva el pastel");
            public static void Mensaje2(string msj) => Console.WriteLine($"{msj} - fue el culpable");
      
    }
}
