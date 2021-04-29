using System;
using System.Collections.Generic;

namespace _21interfaz3
{
    
        class Empleado : IComparable<Empleado>, IFormattable {
        public string Paterno {get; set;}
        public string Materno {get; set;}
        public string Nombre {get; set;}
        public double Salario {get; set;}

        public  int CompareTo(Empleado otro){
           if(this.Salario < otro.Salario) return 1;
           else if(this.Salario > otro.Salario) return -1;
           else return 0;
        }
        public override string ToString() => $"{Nombre,-8} - {Salario,8:C}";
        public string ToString(string formato, IFormatProvider provveedor){
            switch(formato){
                case "PMNS" : return $"{Paterno,-16} - {Materno,-16} - {Nombre,-16} - {Salario:C}";
                case "NPMS" : return $"{Nombre,-16} - {Paterno,-16} - {Materno,-16} - {Salario:C}";
                case "PMN" : return $"{Paterno,-16} - {Materno,-16} - {Nombre,-16}";
                default : throw new FormatException("Formato desconocido");
            }
        }
    }
        class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de ejemplo de usuario de interfaces integradas en c#");  
            List<Empleado> emps = new List<Empleado> {
                new Empleado() {Paterno="Jaramillo",Materno="Leiva",     Nombre="Andrea", Salario=1005.67},
                new Empleado() {Paterno="Martinez", Materno="Marquez",   Nombre="maria",  Salario=1100.167},
                new Empleado() {Paterno="Morales",  Materno="Luevano",   Nombre="isabel", Salario=5110.657}, 
                new Empleado() {Paterno="Lopez",    Materno="castañeda", Nombre="carlos", Salario=1000.670}, 
                new Empleado() {Paterno="Carrillo", Materno="Rivera",    Nombre="hector", Salario=2110.673}, 
            };
            Console.WriteLine("\n Listado de empleados en oden del salario ascendent, nombre y salrio");
            emps.Sort();
            emps.ForEach(e=>Console.WriteLine(e.ToString()));
            Console.WriteLine("\n Listado de empleados en oden del salario descendent, nombre y salrio");
            emps.Reverse();
            emps.ForEach(e=>Console.WriteLine(e.ToString()));

            Console.WriteLine("\n Listado de empleados con formato personalizado,paterno,materno nombre,salario");
            emps.ForEach(e=>Console.WriteLine(e.ToString("PMNS",System.Globalization.CultureInfo.CurrentCulture)));

            Console.WriteLine("\n Listado de empleados con formato personalizado,paterno,materno nombre");
            emps.ForEach(e=>Console.WriteLine(e.ToString("PMN",System.Globalization.CultureInfo.CurrentCulture)));
        }
    }
}
