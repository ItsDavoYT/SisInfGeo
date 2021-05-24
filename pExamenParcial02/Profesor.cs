using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

public class Profesor{
    public string nombre{get;set;}
    public string grupo {get;set;}
    public string materia{get;set;}
    public DateTime fechaing{get;set;}
    public int salario{get;set;}
    public List<Alumno> listaAlumnos{get;set;}
    public int mayorPromedio{get;set;}
    public int menorPromedio{get;set;}
    public int totalBecados{get;set;}
     public Profesor(){}

    public Profesor(string nombre, DateTime fechaing, string grupo, string materia, int salario){
        this.nombre = nombre;
        this.fechaing = fechaing;
        this.grupo = grupo;
        this.materia = materia;
        this.salario = salario;
        listaAlumnos = new List<Alumno>();
    }

    public void getPromedios(){
        foreach(Alumno a in listaAlumnos){
            mayorPromedio = a.getPromedio();
            menorPromedio = a.getPromedio();
            break;
        }
        foreach(Alumno a in listaAlumnos){
            if(a.getPromedio() > mayorPromedio){
                mayorPromedio = a.getPromedio();
            }else{
                menorPromedio = a.getPromedio();
            }
            if(a.becado.ToLower().Equals("si")){
                totalBecados++;
            }
        }
    }

    public override string ToString(){
        int epocaActual = DateTime.Now.Year;
        int epocaIngreso = fechaing.Year;
        return "Nombre: "+nombre + ", "+"  FechaIng:   "+fechaing.Date.ToString("dd/MM/yyyy")+ ", "+"  Grupo:  "+grupo+ ", "+"  Materia: "+materia+", "+"  Salario: "+salario.ToString("C", new CultureInfo("en-US"))+", "+"  Alumnos: "+listaAlumnos.Count+", "+"  Antiguedad: "+(epocaActual-epocaIngreso);
    }
}