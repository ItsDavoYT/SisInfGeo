using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

public class Alumno{

    public string nombre{get;set;}
    public int edad{get;set;}
    public DateTime fechaing{get;set;}
    public string becado{get;set;} 
    public string calificaciones{get;set;}
 
    public int numProfesor{get;set;}

    public Alumno(){}

    public Alumno(int numProfesor,string nombre, int edad, DateTime fechaing, string becado, string calificaciones){
        this.nombre = nombre;
        this.edad = edad; 
        this.fechaing = fechaing; 
        this.calificaciones = calificaciones;
        this.becado = becado;
        this.numProfesor = numProfesor;
    }

    public int getPromedio(){
        int sumatoria = 0;
            String[] valores = calificaciones.Split(",");
            foreach(string cal in valores){
                sumatoria+= Int32.Parse(cal);
            }
        int prom = (sumatoria)/valores.Length;
        return prom;
    }

    public override string ToString(){
            int epocaActual = DateTime.Now.Year;
            int epocaIngreso = fechaing.Year;
            string mensaje="";
            int prom = getPromedio();
            if(prom>6){
                mensaje = "Aprobado";
            }else{
                mensaje = "Reprobado";
            }
        return "Nombre: "+nombre +", "+"Edad: "+edad+", "+"FechaIng: "+fechaing.Date.ToString("dd/MM/yyyy")+", "
        +"Becado: "+becado+", "+"Califs: "+calificaciones+", "+"Antiguedad: "+(epocaActual-epocaIngreso)+", "
        +"Prom: "+getPromedio()+ ", "+"Mensaje: "+mensaje;
        }

}

 