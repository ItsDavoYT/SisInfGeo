using System;

namespace _11vectorcubo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int TAM = 30;
            int ceros= 0, positivos = 0, negativos = 0;
            double[] valores = new double[TAM];
            double sumPos = 0, sumNeg = 0;
            Console.WriteLine("Vector sumas");
            valores = aleatorio(valores);
            
            Console.Write("Vector original");
            imprimir(valores);

            for(int i=0; i<valores.Length;i++){
                if(valores[i] < 0){
                    negativos++;
                    sumNeg += valores[i];
                }else if(valores[i] > 0){
                    positivos++;
                    sumPos += valores[i];
                }else{
                    ceros++;
                }
            }

            Console.Write("Numero de positivos {0}\nNumero negativos {1}\nNumero 0s {2}",positivos, negativos, ceros);
            Console.Write("\nSuma positivos {0}\nSuma negativos {1}", sumPos, sumNeg);
            
        }
        static void imprimir(double[] v){
            for(int i=0; i<v.Length;i++){
                Console.Write("[{0}]",v[i]);
            }
            Console.Write("\n");
        }

        static double[] aleatorio(double[] v){
            Random rn = new Random();
            double MIN = -100;
            double MAX = 100;

            for(int i=0; i<v.Length;i++){
                v[i] = rn.NextDouble() * (MAX - MIN) + MIN;
            }
            return v;
        }
    }
}
