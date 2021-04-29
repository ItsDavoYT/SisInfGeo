using System;
using System.Threading;
namespace _37threads2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=3; i++){
                Thread t =  new Thread(Imprime); 
                t.Start(i);
            }
            
        }
        static void Imprime(object o){
            int s=0;
            for (int i=0; i<=10; i++){
                Console.WriteLine($"imprime el Thream {o} / {i}");
                s += i;
                }
                Console.WriteLine($"la suma de Thread {o} = {s}");
        }
    }
}
