using System;
using System.Collections.Generic;
public class Profesor{

    public Profesor(){
        Grupos = new List<Grupo>();
    }

    public Profesor(string nombre, DateTime fechaIng, string materia, string salario, Escuela escuela)=> (Nombre, FechaIng, Materia, Salario, Escuela)=(nombre, fechaIng, materia, salario, escuela);
    public String Nombre {get; set;}
    public DateTime FechaIng {get; set;}
    public List<Grupo> Grupos {get; set;}
    public String Materia {get; set;}
    public String Salario {get; set;}
    public Escuela Escuela {get; set;}

    public int totalAlumnosProf(){
        int count = 0;
        foreach(Grupo g in Grupos){
            count += g.getAlumnos();
        }
        return count;
    }

    private int antiguedad()=> DateTime.Now.Year - FechaIng.Year;

    public override string ToString() => 
        String.Format($"Nombre: {Nombre},\tFechaIng: {FechaIng.ToString("dd/mm/yy")},\tGrupo: {Grupos[0].Id},\tMateria: {Materia},\tSalario: {Salario},\tAlumnos: {totalAlumnosProf()},\tAntiguedad: {antiguedad()}");

}