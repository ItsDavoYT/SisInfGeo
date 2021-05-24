using System.Collections.Generic;

namespace pExamenParcial3{

    public class Categorias{
        public int CategoriasID{get;set;}
        public string NombreCategoria{get;set;}
        public string Url{get;set;}
        public List<Producto> productos{get;set;}// Campo de navegacion
        public override string ToString() => $"\nId: {CategoriasID}\nNombre: {NombreCategoria}\nUrl: {Url}";
    }

    //relacion 1 a muchos
    //aqui esta la tabala del 1 
    //categoria -> Producto




}