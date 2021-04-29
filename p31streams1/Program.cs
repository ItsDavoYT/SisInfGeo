using System;
using System.IO;
using static System.Console;

namespace _31streams1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materias = new string[] {"Programacion","calculo","matematicas","quimica","fisica","seguridad","estadistica"};
            string ruta = Path.Combine(Environment.CurrentDirectory,"materias.txt");
            StreamWriter fMaterias = File.CreateText(ruta);


            WriteLine("escribir y leer datos de un stream texto \n\n");
            WriteLine("escribiendo la lista de materias en el rchivo {0}\n", ruta);
            foreach(string m in materias){
                WriteLine("{0}",m);
                fMaterias.WriteLine(m);
            }
            fMaterias.Close();
            if(File.Exists(ruta)){
                FileInfo fInfo = new FileInfo(ruta);
                StreamReader fLeer = File.OpenText(ruta);
                //string contenido = File.ReadAllText(ruta);
                WriteLine("leyendo contenido en el archivo: {0}",ruta);
                WriteLine("el tamañao del archivo es: {0} bytes", fInfo.Length);
                WriteLine("el contenido del archivo es: {0}");
            }else {WriteLine("el archivo no existe");}
           
        }
    }
}
