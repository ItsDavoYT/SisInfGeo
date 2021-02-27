using System;
using System.Collections.Generic;

public class Grupo{

    public Grupo(){
        Alumnos = new List<Alumno>();
    }
    
    public Grupo(string id) => (Id) = (id);
    public String Id {get; set;}
    public List<Alumno> Alumnos {get; set;}

    public int getAlumnos(){
        return Alumnos.Count;
    }
    public string mayorProm(){
        string mayor = " ";
        int tmp = 0;
        foreach(Alumno a in Alumnos){
            if(a.promedio() > tmp){
                tmp = a.promedio();
            }
        }
        mayor = tmp + "";
        return mayor;
    }

    public string menorProm(){
        string mayor = " ";
        int tmp = 0;
        foreach(Alumno a in Alumnos){
            if(tmp < a.promedio()){
                tmp = a.promedio();
            }
        }
        mayor = tmp + "";
        return mayor;
    }

    public string totalBecadosProf(){
        string totalBecados = " ";
        int count = 0;
        foreach(Alumno a in Alumnos){
            if(a.Becado == "Si"){
                count ++;
            }
        }
        totalBecados = count + "";
        return totalBecados;
    }

    public override string ToString() => 
        String.Format($"Mayor Promedio: {mayorProm()},\nMenor Promedio: {menorProm()},\nTotal Becados: {totalBecadosProf()}");
}