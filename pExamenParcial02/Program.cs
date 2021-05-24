using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Escuela1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escPatito = new Escuela("Universidad Patito SA de CV","Juan Perez", "Av De la Juventud 348");
            Console.WriteLine(">> Datos generales de la Escuela: \n\n"+escPatito.ToString()+"\n");

            escPatito.listaProfesores.Add(new Profesor("Jose Diaz",DateTime.Parse("1/1/2018"),"1A","Fisica",1200));
            escPatito.listaProfesores.Add(new Profesor("Maria Perez",DateTime.Parse("10/2/2016"),"2A","Algebra",3400));
            escPatito.listaProfesores.Add(new Profesor("Claudia Sid",DateTime.Parse("1/4/2019"),"4B","Calculo",3800));
            escPatito.listaProfesores.Add(new Profesor("Carlos Lopez",DateTime.Parse("10/3/2016"),"8A","Quimica",1000));
        
            escPatito.listaAlumnos.Add(new Alumno(1,"Fatima Soto",23,DateTime.Parse("1/1/2019"),"Si","7,7,7"));
            escPatito.listaAlumnos.Add(new Alumno(1,"Damian Diaz",25,DateTime.Parse("1/1/2016"),"No","8,8,8"));
            escPatito.listaAlumnos.Add(new Alumno(1,"Fatima Soto",23,DateTime.Parse("1/1/2018"),"Si","6,6,6"));
            escPatito.listaAlumnos.Add(new Alumno(2,"Maria Ochoa",20,DateTime.Parse("1/10/2018"),"Si","9,9,9"));
            escPatito.listaAlumnos.Add(new Alumno(2,"Carlos Diaz",23,DateTime.Parse("1/10/2018"),"No","8,8,8"));
            escPatito.listaAlumnos.Add(new Alumno(4,"Jose Ochoa",19,DateTime.Parse("1/10/2016"),"No","6,6,6"));

            escPatito.getSalarios();
            int posiciones = 0;
            foreach(Profesor p in escPatito.listaProfesores){
                posiciones++;
                foreach(Alumno a in escPatito.listaAlumnos){
                    if(a.numProfesor == posiciones){//tiene un mismo profesor
                        p.listaAlumnos.Add(a);
                    }
                }
            }

            Console.WriteLine("Total profesores:  "+escPatito.listaProfesores.Count+
                                "\nTotal alumnos: "+escPatito.listaAlumnos.Count+
                                "\nTotal alumnos becados: "+escPatito.getTotalBecados()+
                                "\nTotal salario profesores: "+escPatito.salariosTotales.ToString("C", new CultureInfo("en-US"))+"\n\n >>Datos generales de los profesores\n");
           
            escPatito.listaProfesores.ForEach(p=>Console.WriteLine(p.ToString())); 

            Console.WriteLine("\nMayor salario: "+escPatito.salarioMayor.ToString("C", new CultureInfo("en-US"))+
                              "\nMenor salario: "+escPatito.salarioMenor.ToString("C", new CultureInfo("en-US")));
            
            Console.WriteLine("\n>> Alumnos por profesor: ");

            foreach(Profesor p in escPatito.listaProfesores){
                Console.WriteLine("\n > Nombre: "+p.nombre +",\t Grupo: "+p.grupo+"\n");
                p.getPromedios();
                if(p.listaAlumnos.Count >=1){
                    foreach(Alumno a in p.listaAlumnos){
                        Console.WriteLine(a.ToString());
                    }
                    Console.WriteLine("\nMayor promedio: "+p.mayorPromedio+"\nMenorPromedio: "+p.menorPromedio+"\nTotal becados : "+p.totalBecados);
                }else{
                    Console.WriteLine("No tiene alumnos aun.");
                }

            }
            

            
        Console.WriteLine("\n\n>>Datos generales de los profesores usando Linq\n\n"+ ">Profesores con una fecha de ingreso mayor e igual a 2016\n");

        IEnumerable<Profesor> profFechaIng = (from prof in escPatito.listaProfesores where prof.fechaing.Year >=2016 select prof);
        foreach(Profesor p in profFechaIng){
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine("\n>Profesores con un salario mayor e igual a 3000\n");
        IEnumerable<Profesor> profSalario = (from prof in escPatito.listaProfesores where prof.salario >= 3000 select prof);
    	foreach(Profesor p in profSalario){
            Console.WriteLine(p.ToString());
        }


        Console.WriteLine("\n\n >>Datos generales de los alumnos usando Linq\n\n>Alumnos con promedio menor a 8 \n");
        var alumPromedio = from alumn in escPatito.listaAlumnos where alumn.getPromedio() < 8 select "Nombre: "+alumn.nombre +", Calificaciones: "+ alumn.calificaciones +", Promedio: "+ alumn.getPromedio().ToString();
        foreach(String a in alumPromedio){
            Console.WriteLine(a);
        }    
        Console.WriteLine("\n>Alumnos menores de 20 anos\n");

        var alumMenores = from alumn in escPatito.listaAlumnos where alumn.edad < 20 select "Nombre: "+alumn.nombre+", Edad: "+alumn.edad+", Becado: "+alumn.becado;
        foreach(String a in alumMenores){
            Console.WriteLine(a);
        }

               //Serializacion de los datos en xml 

            Console.WriteLine("\n\n>>Serializando datos profesor en XML...\nSerializando datos alumnos en XML..."+"\n>>Serializando datos Escuela en XML...");
               
            string rutaProfesores= Path.Combine(Environment.CurrentDirectory,"datosProfesores.xml");
            string rutaAlumnos= Path.Combine(Environment.CurrentDirectory,"datosAlumnos.xml");
            string rutaEscuela= Path.Combine(Environment.CurrentDirectory,"datosEscuela.xml");

            //serializando los profesores.
            FileStream fs = File.Open(rutaProfesores,FileMode.Create);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Profesor>));
            xmlSer.Serialize(fs,escPatito.listaProfesores);
            fs.Close();
            //serializando los alumnos.
            fs = File.Open(rutaAlumnos,FileMode.Create);
            xmlSer = new XmlSerializer(typeof(List<Alumno>));
            xmlSer.Serialize(fs,escPatito.listaAlumnos);
            fs.Close();

            //serializando la escuela.
            fs = File.Open(rutaEscuela,FileMode.Create);
            xmlSer = new XmlSerializer(typeof(Escuela));
            xmlSer.Serialize(fs,escPatito);
            fs.Close();

            
            Console.WriteLine("\n\n>Deserealizando el archivo de XML de los profesores:\n");
            FileStream desFs = File.Open(rutaProfesores,FileMode.Open);
            XmlSerializer desXmlSer = new XmlSerializer(typeof(List<Profesor>));
            List<Profesor> desListaProfesores = (List<Profesor>)desXmlSer.Deserialize(desFs);
            desListaProfesores.ForEach(des=>Console.WriteLine(des.ToString()));
            desFs.Close();

            Console.WriteLine("\n>Deserealizando el archivo XML de los alumnos: \n");
            desFs = File.Open(rutaAlumnos,FileMode.Open);
            desXmlSer = new XmlSerializer(typeof(List<Alumno>));
            List<Alumno> desListaAlumnos = (List<Alumno>)desXmlSer.Deserialize(desFs);
            desListaAlumnos.ForEach(des=>Console.WriteLine(des.ToString()));
            desFs.Close();

            Console.WriteLine("\n>Deserealizando el archivo XML de la escuela: \n");
            desFs = File.Open(rutaEscuela,FileMode.Open);
            desXmlSer = new XmlSerializer(typeof(Escuela));
            Escuela desListaEscuela = (Escuela) desXmlSer.Deserialize(desFs);
            Console.WriteLine(desListaEscuela.ToString());
            desFs.Close();
            
            Console.WriteLine("\n\n >>Serializando datos in JSON\n\n>Serializando los datos de empleados en JSON...\nSerializando los datos de los alumnos en JSON...\nSerializando los datos de la escuela en JSON...");

            rutaProfesores= Path.Combine(Environment.CurrentDirectory,"datosProfesores.json");
            rutaAlumnos= Path.Combine(Environment.CurrentDirectory,"datosAlumnos.json");
            rutaEscuela= Path.Combine(Environment.CurrentDirectory,"datosEscuela.json");

            StreamWriter sw = File.CreateText(rutaProfesores);
            JsonSerializer js = new JsonSerializer();
            js.Serialize(sw,escPatito.listaProfesores);
            sw.Close();

            sw = File.CreateText(rutaAlumnos);
            js = new JsonSerializer();
            js.Serialize(sw,escPatito.listaAlumnos);
            sw.Close();

            sw = File.CreateText(rutaEscuela);
            js = new JsonSerializer();
            js.Serialize(sw,escPatito);
            sw.Close();

            Console.WriteLine("\n\n>>Deserealizando el archivo en JSON de datosProfesores...\n");
            StreamReader sr = File.OpenText(rutaProfesores);
            string txtDatos = sr.ReadToEnd();
            List<Profesor> desDatosProfesores = JsonConvert.DeserializeObject<List<Profesor>>(txtDatos);
            desDatosProfesores.ForEach(des=>Console.WriteLine(des.ToString()));

            Console.WriteLine("\n\n>>Deserealizando el archivo en JSON de datosAlumnos...\n");
            sr = File.OpenText(rutaAlumnos);
            txtDatos = sr.ReadToEnd();
            List<Alumno> desDatosAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(txtDatos);
            desDatosAlumnos.ForEach(des=>Console.WriteLine(des.ToString()));

            Console.WriteLine("\n\n>>Deserealizando el archivo en JSON de la escuela...\n");
            sr = File.OpenText(rutaEscuela);
            txtDatos = sr.ReadToEnd();
            Escuela escPato  = JsonConvert.DeserializeObject <Escuela>(txtDatos);
            Console.WriteLine(escPato.ToString());

        }
    }
}
