using System;

namespace _13multivector
{
    class Program
    {
        static void Main(string[] args)
        {   
            int TAM = 10;
            int count = 0;
            double[] vectorA = new double[TAM];
            double[] vectorB = new double[TAM];
            double[] vectorC = new double[TAM];
            Console.WriteLine("Multiplicacion de vectores");
            vectorA = aleatorio(vectorA);
            vectorB = aleatorio(vectorB);

            for(int i=TAM;i>0;i--){
                vectorC[count] = vectorA[i-1] * vectorB[count];
                count++;
            }

            Console.Write("Vector A\n");
            imprimir(vectorA);
            Console.Write("Vector B\n");
            imprimir(vectorB);
            Console.Write("Vector C\n");
            imprimir(vectorC);
        }

        static void imprimir(double[] v){
            for(int i=0; i<v.Length;i++){
                Console.Write("[{0}]",v[i]);
            }
            Console.Write("\n");
        }

        static double[] aleatorio(double[] v){
            Random rn = new Random();
            for(int i=0; i<v.Length;i++){
                v[i] = rn.Next(100);
            }
            return v;
        }
    }
}
