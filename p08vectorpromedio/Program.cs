//Programa que calcula el promedio de un vector de 50 valores constantes
using System;

namespace _8vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55};
            int suma = 0, nmp = 0;
            float promedio = 0; 
            Console.WriteLine("Programa que calcula el promedio de un vector de 50 valores constantes");

            //calcular la suma de los elementos del arreglo
            for(int i=0; i< vector.Length; i++){
                Console.Write("{0}", vector[i]);
                suma += vector[i];
            }
            //Calcular promedio
            promedio = suma / vector.Length;
            //Contar cuantos elementos del arreglo son mayor al promedio
            Console.WriteLine("\n\nLa suma de los numeros del vector es     :{0}",suma);
            Console.WriteLine("\n\nEl promedio de los numeros del vector es :{0}",suma);
            Console.WriteLine("\n\nNumeros mayores al promedio");
            for(int i=0; i< vector.Length; i++){
                if(vector[i]>promedio){
                    Console.Write("{0} ",vector[i]);
                    nmp++;

                }
            }
            Console.WriteLine("\nLa cantidad de numeros mayores al promedio es {0}", nmp);
        }
    }
}
