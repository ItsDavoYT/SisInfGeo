using System;
//delegados simples
namespace _22delegados1 {

public delegate void MiDelegado(string msj);//crecion del dlegado
class program {
    public static void Main() {

    MiDelegado d;//crear instancia delegado
    d = Mensaje.Mensaje1;//apunto dlegado aun metodo o funcion que coincide con la firma del delegado
    d("juan");

    d = Mensaje.Mensaje2;//apunto dlegado aun metodo o funcion que coincide con la firma del delegado
    d("jose");

    d = (string msj) => Console.WriteLine($"{msj} - pagar todo para la fiesta");
    d("carlos");
    }
}   
public class Mensaje{
       public string void Mensaje1(string msj) => Console.WriteLine{$"{msj} - lleva el pastel"};
       public string void Mensaje2(string msj) => Console.WriteLine{$"{msj} - fue el culpable"};
   }
}