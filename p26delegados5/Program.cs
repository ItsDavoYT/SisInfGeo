
//ejemlo de dlegado como parametro
using System;
namespace _26delegados5
{
public delegate void MiDelegado(string msj);

    class Program
    {
         static void Main(string[] args)
        {
        MiDelegado d1, d2,d3;
        d1 = A.MetodoA;
        d2 = B.MetodoB;
        d3 = (string msj) => Console.WriteLine($"llamando al metodo con exprecion lambada");
        d1("hola mundo");
        d2("hola mundo");
        d3("hola mundo");

        Invocar(d1);
        Invocar(d2);
        Invocar(d3);
        }
        static void Invocar(MiDelegado d){
                d("llamando desde el invocador");
        
        }
    
    }
    public class A{
        public static void MetodoA(string msj) => Console.WriteLine($"LLAMANDO A EL METODO DE LA CLASE A: {msj}");
    }
      public class B{
        public static void MetodoB(string msj) => Console.WriteLine($"LLAMANDO A EL METODO DE LA CLASE B: {msj}");
    }
}
