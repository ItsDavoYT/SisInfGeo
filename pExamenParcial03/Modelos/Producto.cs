namespace pExamenParcial3{

    public class Producto{

        public int ProductoID{get;set;}
        public string Url{get;set;}
        public string UrlImagen{get;set;}
        public string Titulo{get;set;}
        public string PrecioBase{get;set;}
        public string PrecioDescuento{get;set;}
        public string NombreCategoria{get;set;}
        public int CategoriasID{get;set;}//campo de navegacion
        public override string ToString() => 
            $"\nId: {ProductoID}\nUrl: {Url}\nUrl Imagen: {UrlImagen}"+
            $"\nTitulo: {Titulo}\nPrecio base:"+" $"+$"{PrecioBase}\nPrecio Oferta:"+" $"+$"{PrecioDescuento}\nCategoria: {NombreCategoria}\nCategoriaID: {CategoriasID}";

        //relacion muchos a 1 
        //aqui esta la tabla de muchos
        // producto <- Categorias
        

    }

}