using System;

namespace _7tablas
{
    class Program
    {
        static int Main(string[] args)
        {
            int tf, ns, nt, resultado = 0; //tf es tabla final - ns numero superior - nt numero de tabla
            if(args.Length == 0){
                Menu();
                return 1;
            }
            else if(args.Length==1){
                nt = int.Parse(args[0]);
                for(int i=1;i<=10; i++){
                    if(i%5 == 0){
                        Console.Write("\n");
                    }
                    resultado = i * nt;
                    Console.Write("[{0}] X [{1}] = {2}\t",nt,i,resultado);
                }
            }else if(args.Length==2){
                tf = int.Parse(args[0]);
                ns = int.Parse(args[1]);
                for(int i = 1;i<=tf;i++ ){
                    for(int j =1; j <=ns; j++){
                        if(j%5 == 0){
                            Console.Write("\n");  
                        }
                        resultado = i *j ;
                        Console.Write("[{0}] X [{1}] = {2}\t",i,j,resultado);
                    }
                    Console.Write("\n");
                }
            }
            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] Para ver una tabla tabla especifica ");
            Console.WriteLine("Escribe la tabla que quieres ver");
            Console.WriteLine("[2] Para ver una serie de tablas hasta el numero que deseas");
            Console.WriteLine("Escribe la tabla hasta la que quieres llegar, seguida del numero deseado");
        }
    }
}
