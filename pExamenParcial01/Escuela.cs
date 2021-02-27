using System;
using System.Collections.Generic;

public class Escuela{

    public Escuela(){
        Profesores = new List<Profesor>();
    }

    public Escuela(string nombre, string encargado, string domicilio) => (Nombre, Encargado, Domicilio) = (nombre, encargado, domicilio);

    public String Nombre {get; set;}
    public String Encargado {get; set;}
    public String Domicilio {get; set;}
    public List<Profesor> Profesores {get;set;}

    private string totalSalarioProfesores(){
        string total = " ";
        int sum = 0;
        foreach(Profesor p in Profesores){
            sum += Int16.Parse(p.Salario);
        }
        total = sum + "";
        return total;
    }

    private string totalAlumnos(){
        string total = " ";
        int sum = 0;
        foreach(Profesor p in Profesores){
            sum += p.totalAlumnosProf();
        }
        total = sum +"";
        return total;
    }

    private string totalBecados(){
        string total = " ";
        int sum = 0;
        foreach(Profesor p in Profesores){
            foreach(Grupo g in p.Grupos){
                foreach(Alumno a in g.Alumnos){
                    if(a.Becado == "Si"){
                        sum += 1;
                    }
                }
            }
        }
        total = sum +"";
        return total;
    }

    public string mayorSal(){
        string mayor = " ";
        int tmp = 0;
        foreach(Profesor p in Profesores){
            if(int.Parse(p.Salario) > tmp){
                tmp = int.Parse(p.Salario);
            }
        }
        mayor = tmp + "";
        return mayor;
    }

    public string menorSal(){
        string mayor = " ";
        int tmp = 0;
        foreach(Profesor p in Profesores){
            if(tmp < int.Parse(p.Salario)){
                tmp = int.Parse(p.Salario);
            }
        }
        mayor = tmp + "";
        return mayor;
    }

    public override string ToString() => 
        String.Format($"\nNombre: {Nombre}\nEncargado: {Encargado}\n domicilio: {Domicilio}\nTotal Profesores: {Profesores.Count}\nTotal Alumnos: {totalAlumnos()}\nTotal Becados: {totalBecados()}\nTotal Salario Profesores: {totalSalarioProfesores()}");
}