using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

public class Escuela{
    
    public string nombre{get;set;}
    public string encargado{get;set;}
    public string domicilio{get;set;}
    public int salariosTotales{get;set;} = 0;
    public int salarioMayor{get;set;} = 0;
    public int salarioMenor{get;set;} = 0;
    public List<Profesor> listaProfesores{get;set;}
    public List<Alumno> listaAlumnos{get;set;}

    public Escuela(){}

    public Escuela(string nombre, string encargado, string domicilio){
        this.nombre = nombre;
        this.encargado = encargado;
        this.domicilio = domicilio;
        listaProfesores = new List<Profesor>();
        listaAlumnos = new List<Alumno>();
    }

    public int getTotalBecados(){
        int conteo = 0;
        foreach(Alumno a in listaAlumnos){
            if(a.becado.ToLower().Equals("si")){
                conteo++;
            }
        }
        return conteo;
    }

    public void getSalarios(){
        foreach(Profesor p in listaProfesores){
            salarioMayor = p.salario;
            salarioMenor = p.salario;
            break;
        }
        foreach(Profesor p in listaProfesores){
            if(p.salario > salarioMayor){
                salarioMayor = p.salario;
            }else{
                salarioMenor = p.salario;
            }
            salariosTotales+=p.salario;
        }
    }

    public override string ToString(){
        return "Nombre  : "+nombre+"\n"+  "Encargado  : "+encargado +"\n"+ "Domicilio  : "+domicilio;
    }

}