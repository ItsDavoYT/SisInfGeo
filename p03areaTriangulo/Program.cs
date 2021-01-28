using System;

namespace areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
           float labase, laaltura;
           float area;

           Console.WriteLine("Dame la base"); labase = float.Parse(Console.ReadLine());
           Console.WriteLine("Dame la altura"); laaltura = float.Parse(Console.ReadLine());

           area = labase*laaltura/2;
           Console.WriteLine($"Un triangulo de base{labase} y altura{laaltura} tiene un area de {area}");
        }
    }
}
