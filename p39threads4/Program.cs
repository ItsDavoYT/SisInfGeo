using System;
using System.Threading;
namespace _39threads4
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("iniciando Thread principlal..");
            Thread t1 = new Thread(Metodo1) {Name = "Thread A"};
            Thread t2 = new Thread(Metodo2) {Name = "Thread B"};
            Thread t3 = new Thread(Metodo3) {Name = "Thread C"};
            t1.Start();
            t2.Start();
            t3.Start();
        }
        static void Metodo1(){
            Console.WriteLine($"metodo 1 iniciando usando {Thread.CurrentThread.Name}");
            for(int i=0;i<=5;i++){
                Console.WriteLine($"metodo1: {i}");
                }
                Console.WriteLine("$metodo 1 iniciando usando {Thread.CurrentThread.Name}");
            }            
                static void Metodo2(){
                    Console.WriteLine($"metodo 2 iniciando usando {Thread.CurrentThread.Name}");
                    for (int i=1;i<=5;i++){
                        Console.WriteLine($"metodo: 2 {i}");
                        if( i== 3) {
                            Console.WriteLine("iniciando operaciones sobre la base de datos...");
                            Thread.Sleep(10000);
                            Console.WriteLine("peracion sobre la base de datos terimnada");
                        }
                    }
                    Console.WriteLine($"metododo 2 iniciando usando {Thread.CurrentThread.Name}");
                    }
                static void Metodo3() {
                     Console.WriteLine($"metodo 3 iniciando usando {Thread.CurrentThread.Name}");
                     for(int i=0;i<=5;i++) { 
                     Console.WriteLine($"metodo 3: {i}");
                }
                Console.WriteLine($"metodo 3 iniciando usando {Thread.CurrentThread.Name}");
            }       
    }
}

