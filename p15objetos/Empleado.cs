using System;
namespace _15objetos
{
    public class Empleado{
        private string nombre;
        private int edad;

        //Constructor
        public Empleado(){}

        public Empleado(string nombre, int edad){
            this.nombre = nombre;
            this.edad = edad;
        }

        //Getters y Setters
        public string Nombre{
            get{return nombre;}
            set{nombre = value;}
        }
        
        public int Edad{
            get{return edad;}
            set{edad = value;}
        }

        public void CalcularVacaciones(DateTime inicio, double dias){
            DateTime final;
            final = inicio.AddDays(dias);

            Console.WriteLine("Tienes vacaciones desde {0} hasta {1}", inicio.ToString(),final.ToString());
        }
    }
}