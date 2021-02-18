using System;

namespace _14vectorestadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            int n = 0;
            double[] valores = {10,20,30,40,50,60,70,80,90,100};
            double mayor = 0, menor = 0, promedio = 0, varianza = 0, desvest =0; 
            Console.WriteLine("Programa que genera estadisticas de numeros\n");

            Console.WriteLine("Cuantos elementos deseas calcular?"); 
            n = int.Parse(Console.ReadLine());
            if(n>MAX){
                Console.WriteLine("El maximo numero de elementos es {0}", MAX);
            }else{
                valores = new double[n];
                for(int i= 0; i<n;i++){
                    Console.WriteLine("valores[{0}] =", i+1);
                    valores[i] = double.Parse(Console.ReadLine());
                }
            }

            //Calculos
            mayor = Funciones.Mayor(valores);
            menor = Funciones.Menor(valores);
            promedio = Funciones.Promedio(valores);
            varianza = Funciones.Varianza(valores, promedio);
            desvest = Math.Sqrt(varianza);

            //Salida
            Console.WriteLine("El mayor es               : {0}",mayor);
            Console.WriteLine("El menor es               : {0}",menor);
            Console.WriteLine("El promedio es            : {0}",promedio);
            Console.WriteLine("La varianza es            : {0}",varianza);
            Console.WriteLine("La desviacion estandard   : {0}",desvest);
        }

}
