//10 - Promgrama que genera un vector aleatorio de 20 elementos, lo eleva al cubo y lo guarda en otro vector
using System;

namespace _10vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 20;
            double[] A = new double[TAM];
            double[] B = new double[TAM];
            Random rnd = new Random();

            for(int i = 0; i<TAM; i++){
                A[i] = rnd.Next(-10,50);
                B[i] = Math.Pow(A[i],3);
            }
            Console.WriteLine("Promgrama que genera un vector aleatorio de 20 elementos, lo eleva al cubo y lo guarda en otro vector\n");

            Console.WriteLine("\nElementos en el vector A: "); imprime(A);
            Console.WriteLine("\nElementos en el vector B: "); imprime(B);
        }
        static void imprime(double[] v){
        for(int i=0;i<v.Length;i++){
            Console.Write("{0} ",v[1]);
        }
        Console.Write("\n");
        }
    }
}
