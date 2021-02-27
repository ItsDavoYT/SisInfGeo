using System;
using System.Collections.Generic;
public class Alumno{
    public Alumno(){
        Calificaciones = new List<int>();
    }
    
    public Alumno(string nomber, int edad, DateTime fechaIng, string becado) => (Nombre, Edad, FechaIng, Becado)=(nomber, edad,fechaIng,becado);
    public String Nombre {get; set;}
    public int Edad {get; set;}
    public DateTime FechaIng {get; set;}
    public String Becado {get; set;}
    public List<int> Calificaciones {get; set;}

    private string califString(){
        string calf = " ";
        foreach(int i in Calificaciones){
            calf = calf + "," + i;
        }
        return calf;
    }

    private int antiguedad()=> DateTime.Now.Year - FechaIng.Year;

    public int promedio(){
        int prom = 0;
        foreach(int i in Calificaciones){
            prom+=i;
        }
        prom = prom/Calificaciones.Count;
        return prom;
    }

    private string mensaje(){
        string mensaje = " ";
        if(promedio() > 7){
            mensaje = "Aprobado";
        }else{
            mensaje = "Reprobado";
        }
        return mensaje;
    }
    public override string ToString() => 
        String.Format($"Nombre: {Nombre},\tEdad: {Edad},\tFechaIng: {FechaIng.ToString("dd/mm/yy")},\tBecado: {Becado},\tCalificaciones: {califString()},\tAntiguedad: {antiguedad()},\nPromedio: {promedio()},\nMensaje: {mensaje()}");
}