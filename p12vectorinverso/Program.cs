using System;

namespace _12vectorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int TAM = 15;
            double[] vector = new double[TAM];
            double[] inverso = new double[TAM];
            vector = aleatorio(vector);
            int count = 0;
            for(int i = TAM; i>0;i--){
                inverso[count] = vector[i-1];
                count++;
            }
            Console.WriteLine("Vector original");
            imprimir(vector);
            Console.WriteLine("Vector inverso");
            imprimir(inverso);
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
