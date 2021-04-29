using System;
using static System.Console;
using System.IO;
using static System.IO.Path;
using static System.IO.Directory;
using static System.Environment;

namespace _30archivos
{
    class Program
        
    {
        static void Main(string[] args)
        {
            WriteLine("trabajando con informacion del sistema");
           // SistemaArchivos();
           //UnidadesDisco();
          // Directorios();
          Archivos();

        }
        static vid Archivos(){
        
        WriteLine("\n trabajando con arhcivos:");
        var nvaCarpeta= Combine(GetCurrentDirectory(),"datos","archivo");
        string archTexto = Combine(nvaCarpeta,"notas.txt");
        string archRespaldo = Combine(dir,"notas.bak");
        //revisar si existe la ruta donde estan los archivos
        if(!Exist(dir))
        CreateDirectory(dir);

        //revisar si existe el archivo texto
        WriteLine($"existe el archivo de texto:?"{File.Exist(archTexto)});
        //crear un archivo de teto nuevo y una linea nueva en el
        WriteLine("Creando archivo de texto .."); 
        StreamWrite txt = File.CreateText(archTexto);
        txt.WriteLine(saludos desde un archivo de texto creado en c #);
        txt.Close();
        WriteLine($"existe el archivo de texto ? {File.Exist(archTexto)}");
        //crear una copia de archivo original
        WriteLine("creando una copia del archivo ");
        File.Copy(sourceFileName:archTexto,destFileName:archRespaldo,overwrite:true);
        WriteLine($"existe el archivo de respaldo? {File.Exists(archRespaldo)}");
        WriteLine("Confirma que el archivo existe,uego preciona <Enter>");
        ReadLine();
        //borrar archivo
        File.Delete(archRespaldo);
        WriteLine($"existe el archivo de respaldo? {File.Exists(archRespaldo)}");
        //leer archivo de texto
        WriteLine($"leyendo contenido del archivo de texto: {GetFileName(archTexto)}");
        StreamReader res = File.OpenText(archTexto);
        WriteLine(res.ReadToEnd());
        res.Close();
        //informacion del archivo
        var info = new FileInfo(archTexto);
        WriteLine("\n informacion de un archivo exsitente");
        WriteLine($"el archivo {archTexto}");
        WriteLine($"nombre del archivo: {GetFileName(archTexto)}, Extencion:{GetExtension(archTexto)}");
        WriteLine($"Contiene {info.Length} bytes");
        WriteLine($"ultima vez que se acceso:{info.LastAccessTime}");
        WriteLine($"es de solo lectura?{info.IsReadOnly}");
        WriteLine($"fecha de creacion :{info.CreationTme}");
        //cambiar nombre al archivo
        WriteLine("cambiar el nombre del archivo");
        string nvoNombre = Combine(dir(),"apuntes.doc");
        File.Move(sourceFileName:archTexto,nvoNombre,overwrite:true);
        WriteLine($"existe el archivo renombrado? {File.Exists(nvoNombre)}");
        }
        static void Directorios(){
            WriteLine("\ntrabajando con directorios");
            var nvaCarpeta = Combine(GetCurrentDirectory(),"datos","codigofuente");
            WriteLine($"trabajando con : {nvaCarpeta}");
            //revisar si existe
            WriteLine($"el directorio ya existe?{Exist(nvaCarpeta)}");
            //creando directoeio
            WriteLine("creando directorio..");
            CreateDirectory(nvaCarpeta);
            WriteLine($"el directorio ya existe?{Exist(nvaCarpeta)}");
            WriteLine($"el directorio yconfirma que el directorio existe luego preciona <enter>");
            ReadLine();
            //borrar directorio
            WriteLine($"Borrando el directorio y sus contenidos");
            Delete(nvaCarpeta,recursive:true);
            WriteLine("el directorio ya existe? {Exists(nvaCarpeta)}");
        }
        static void UnidadesDisco(){
            WriteLine("\n");
            WriteLine("|{0,-30}|{1,-10}|{2.-7}|{3.18}|{4,18}","Nombre","Tipo","Formato","Tamaño");
            foreach(DriveInfo drive in DriveInfo.GetDrives()){
                if(drive.IS.Ready){
                WriteLine("{0,-30} {1,-10} {2,-7} {3,18:N0},{}4,18:N0",drive.Name,drive.DriveType,drive.DriveFormat,drive.TotalSize,drive.AvailableFreeSpace);
                }else{
                    WriteLine("{0,-30} {1,-10}",drive.Name,drive.DriveType);
                }
            }
        }
        static void SistemaArchivos(){
            WriteLine("\ntrabajando con informacion del sistema");
            WriteLine("{0,-33} {1}","separado de ruta :", PathSeparator);
            WriteLine("{0,-33} {1}","separado de directorios :", DirectorySeparatorChar);
            WriteLine("{0,-33} {1}","directorio actual :", GetCurrentDirectory());
            WriteLine("{0,-33} {1}","directorio del sitema :", SystemDirectory);
            WriteLine("{0,-33} {1}","directorio temporal :", GetTempPath());
            WriteLine("{0,-33} {1}","directorio de mis documentos :", GetFolderPath(SpecialFolder.System));
            WriteLine("{0,-33} {1}","directorio de mis documentos :", GetFolderPath(SpecialFolder.MyDocuments));
            WriteLine("{0,-33} {1}","directorio de mis documentos :", GetFolderPath(SpecialFolder.ApplicationData));
            WriteLine("{0,-33} {1}","directorio de mis documentos :", GetFolderPath(SpecialFolder.Personal));

        }
    }
}
