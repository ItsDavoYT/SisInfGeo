using System;
//delegado generico

namespace _25delegados4
{
    public delegate T Suma<T>(T p1, T p2);
    class Program
    {
        static void Main(string[] args)
        {
            Suma<int>  d1 = Sumar;
            Suma<string> d2 = Concatena;
            //Suma<string> d3 = NoSePuede;
            Console.WriteLine($"la suma es: {d1(20,30)}");
            Console.WriteLine($"la concatenacion es: {d2("cepillin","se fue")}");
             Console.WriteLine($"diferente tipo de parametro es: {NoSePuede("aun nos queda chabelo",10)}");
        }
        public int Sumar(int a,int b) => a + b;
        public static string Concatena(string a,string b) => a + b;
    public static string NoSePuede(string a, int b) => $"{a} - {b.ToString()}";    
    }
}
