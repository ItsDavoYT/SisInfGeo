using System;

namespace _5ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, c, suma;
            if(args.Length==0){
                Menu();
                return 1;
            }
            op = int.Parse(args[0]);
            switch(op){
                case 1: c=1; suma = 0;
                    while(c<=100){
                        Console.Write("{0} ",c);
                        suma += c;
                        c++;
                    }
                    Console.WriteLine("\nLa suma es {0}",suma);
                    break;
                case 2: c=100; suma = 0;
                    do{
                        Console.Write("{0} ",c);
                        suma += c;
                        c--;
                    }while(c >= 1);
                    Console.WriteLine("\nLa suma es {0}",suma);
                    break;
                case 3: 
                    suma = 0;
                    for (c=50; c<=200; c++){
                        Console.Write("{0} ",c);
                        suma+=c;
                    }
                    Console.WriteLine("\nLa suma es {0}",suma);
                    break;
                case 4:
                    suma = 0;
                    for(c=2; c<=100; c+=2){
                        Console.Write("{0} ",c);
                        suma+=c;
                    }
                    Console.WriteLine("\nLa suma es {0}",suma);
                    break;
                case 5:
                    suma = 0;
                    for(c=99; c>=1; c-=2){
                        Console.Write("{0} ",c);
                        suma+=c;
                    }
                    Console.WriteLine("\nLa suma es {0}",suma);
                    break;
                case 6:
                    c=272; suma = 0;
                    do{
                        Console.Write("{0} ",c);
                        suma += c;
                        c-=4;
                    }while(c >= 4);
                    Console.WriteLine("\nLa suma es {0}",suma);
                    break;
                default:
                    Console.WriteLine("Opcion no implementada");
                    Menu();
                    break;
            }
            return 0;
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] Numero del 1 al 100 usando un ciclo wile");
            Console.WriteLine("[2] Numero del 100 al 1 usando un ciclo do .. wile");
            Console.WriteLine("[3] Numero del 50 al 200 usando un ciclo for");
            Console.WriteLine("[4] Numero del 2 al 100 solo pares usando un ciclo for");
            Console.WriteLine("[5] Numero del 99 al 1 solo impares usando un ciclo for");
            Console.WriteLine("[6] Numero del 272 al 4 en decrementos de 4 con ciclo wile");
        }
    }
}
