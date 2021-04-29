using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _29linq3
{
    class Estudiante {
        public int Matricula {get; set;}
        public string Nombre {get;set;}
        public string Domicilio {get; set;}
        public List<float> Califs {get; set;}
        public override string ToString() => $"Matricula:{Matricula},Nombre:{Nombre},Domicilio{Domicilio},{string.Join(",",Califs)}";
    }

    class Program
    {
        static void Main(string[] args)
        {
          List<Estudiante> estudiantes = new List<Estudiante>(){
               new Estudiante {Matricula=111,Nombre="Juan Crrillo",Domicilio="Centro 34, zacatecas",Califs=new List<float>{98,97,87,98}},
               new Estudiante {Matricula=222,Nombre="Miguel Marquez",Domicilio="oriente 134, Fresnillo",Califs=new List<float>{88,97,87,98}},
               new Estudiante {Matricula=111,Nombre="Ana Murillo",Domicilio="lomas 334, Zacatecas",Califs=new List<float>{98,77,87,98}},
               new Estudiante {Matricula=222,Nombre="Alejandro Perez",Domicilio="bernardes 3444, Zacatecas",Califs=new List<float>{98,90,87,98}},
               new Estudiante {Matricula=666,Nombre="marco alvares",Domicilio="banderas 564, Zacatecas",Califs=new List<float>{68,60,77,98}},
          };  
          WriteLine("\ntodos los estudiantes tal cual se usa el almacenaiemnto ");
          estudiantes.ForEach(e=>WriteLine(e.ToString()));

          WriteLine("\nestudiantes que son de zacatecas");
          var estzac = (from e in estudiantes where e.Domicilio.Contains("Zacatecas") select e).ToList();
          WriteLine("\nEstudiantes que son de Zacatecas: {0}",estzac.Count());
          estzac.ForEach(e=>WriteLine(e.ToString()));

          var estprom = (from e in estudiantes where e.Califs.Average()>=70 orderby e.Nombre select e).ToList();
          estprom.ForEach(e=>WriteLine(e.ToString()));
          WriteLine("\nEstudiantes con promedio mayor a 70: {0}",estprom.Count());

          var estprom2 = (from e in estudiantes select $"nombre={e.Nombre} prom={e.Califs.Average()}").ToList();
          WriteLine("lista de alumnos y sus promedios");
          estprom2.ForEach(e=>Console.WriteLine(e));

          var gpoest = from e in estudiantes group e by e.Matricula;
          WriteLine("\nEstudiantes agrupados por matricula");
          foreach(var gpo in gpoest){
              WriteLine(gpo.Key);
              foreach(var est in gpo)
                WriteLine(est.ToString());
          }
        }
    }    

}
