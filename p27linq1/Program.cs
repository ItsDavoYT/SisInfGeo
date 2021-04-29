using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace _27linq1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1. fuente datos
            int[] numeros = new int[] {10,25,-1,10,0,20,22,65,800,-4,28,1000,2000,-233}; 

            //imprimir numeros pares
            WriteLine("listado de numeros pares de manera convencional");
            for(int i=0; i<numeros.Length; i++){
                if((numeros[i]%2)==0)
                Write($"{numeros[i]}");
            }
            //2. crear consulta para obtener numeros pares
            IEnumerable<int> qrypares = from num in numeros where (num%2)==0 select num;

            //3. ejecutar consulta
            WriteLine("estado de nueros pares usando linq");
            foreach(int n in qrypares)
            Write($"{n}");
          
            
            WriteLine("listado de numeros impares ");
              var qryimpares = (from num in numeros where (num%2)!=0 select num).ToArray();
              foreach(int n in qryimpares)
             Write($"{n}"); 

                WriteLine("listadio de numeros mayores a 100 usando linq y usando formato de lista");           
                var mayores = (from num in numeros where (num>=20 && num<=1000) && num%2==0 select num).ToList();
                mayores.ForEach(n=>Write($"{n}"));
                
        }
    }
}
