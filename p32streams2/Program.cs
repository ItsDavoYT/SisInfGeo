using System;
using System.IO;
using static System.Console;
namespace _32streams2
{
    class Program
    {
        static string ruta=Path.Combine(Environment.CurrentDirectory,"opcion.bin");
        static void Main(string[] args)
        {
            Console.WriteLine("\n Lectura y escritura de datos en archivo binario");
            Escribir();
            Leer();
        }
        static void Escribir() {
            WriteLine("\n escribirndo datos e un archivo en formato binario");
            BinaryWriter fOps = new BinaryWriter( File.Open(ruta,FileMode.Create) );
            fOps.Write(1.25f);
            fOps.Write(@"c:\Temp");
            fOps.Write(10);
            fOps.Write(true);
            fOps.Close();
        }
        static void Leer(){
            float radio;
            string folder;
            int periodo;
            bool estado;
            WriteLine("leyendo datos del archivo binario {0}", ruta);
            BinaryReader fOps = new BinaryReader( File.Open(ruta,FileMode.Open) );
            radio = fOps.ReadSingle();
            folder = fOps.ReadString();
            periodo = fOps.ReadInt32();
            estado = fOps.ReadBoolean();
            WriteLine("\nRadio    ={0}", radio);
            WriteLine("\nRuta     ={0}", folder);
            WriteLine("\nPeriodo  ={0}", periodo);
            WriteLine("\nEstado    ={0}", estado);
            fOps.Close();
            
        }
    }
}
