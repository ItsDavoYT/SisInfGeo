using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Threading;

namespace pExamenParcial3
{
    class Program
    {

        static DataContext db = new DataContext();

        static void Main(string[] args){
                Scraping();
                Consultas(1);
                Consultas(2);
                Consultas(3);
                Consultas(4);
                Consultas(5);
                Consultas(6);
                Consultas(7);
                Consultas(8);
        }

        static void Consultas(int nc){
            switch(nc){

                case 1:{
                    WriteLine("\n------------\nConsulta 1 - Todas las Categorias \n");
                    var catTotas = db.Categorias.ToList();
                    catTotas.ForEach(c=>WriteLine(c.ToString()));
                    WriteLine($"\n>>Total {catTotas.Count}");
                    break;
                }
                case 2:{
                    WriteLine("\n------------\nConsulta 2 - Todas las Categorias ordenadas por Nombre \n");
                    var catTotas = db.Categorias.OrderBy(c=>c.NombreCategoria).ToList();
                    catTotas.ForEach(c=>WriteLine(c.ToString()));
                    WriteLine($"\n>>Total {catTotas.Count}");
                    break;
                }
                case 3:{
                    WriteLine("\n------------\nConsulta 3 - Todas las Categorias ordenadas por un criterio - El nombre inicia con la letra 'a' \n");
                    string letra= "a";
                    var catLetra = db.Categorias.Where(c=>c.NombreCategoria.StartsWith(letra)).ToList();
                    catLetra.ForEach(c=>WriteLine(c.ToString()));
                    break;
                }
                case 4:{
                    WriteLine("\n------------\nConsulta 4 - Todas las Categorias  - El nombre inicia con la letra 'p' \n");
                    string letra= "p";
                    var catLetra = db.Categorias.Where(c=>c.NombreCategoria.StartsWith(letra)).ToList();
                    catLetra.ForEach(c=>WriteLine(c.ToString()));
                    break;
                }
                case 5:{
                    WriteLine("\n------------\nConsulta 5 - Todas las Categorias  - El nombre especifico \n");
                    string nombre= "tuning";
                    var catLetra = db.Categorias.Where(c=>c.NombreCategoria.StartsWith(nombre)).ToList();
                    catLetra.ForEach(c=>WriteLine(c.ToString()));
                    break;
                }
                case 6:{
                    WriteLine("\n------------\nConsulta 6 - Dada una categoria imprimir sus productos \n");
                    int categoriaid = 23;
                    var catProd = db.Categorias.Select(c=>new {c.CategoriasID, c.NombreCategoria, c.productos}).Where(c=>c.CategoriasID==categoriaid).ToList();
                    foreach(var cat in catProd){
                        WriteLine($"<< {cat.CategoriasID} - {cat.NombreCategoria} >>\n");
                        cat.productos.ForEach(l=>WriteLine(l.ToString()));
                        WriteLine($"\n>>Total {cat.productos.Count}");
                    }
                    
                    break;
                }
                case 7:{
                    WriteLine("\n------------\nConsulta 7 - Dada una categoria imprimir sus productos \n");
                    int categoriaid = 1;
                    var catProd = db.Categorias.Select(c=>new {c.CategoriasID, c.NombreCategoria, c.productos}).Where(c=>c.CategoriasID==categoriaid).ToList();
                    foreach(var cat in catProd){
                        WriteLine($"<< {cat.CategoriasID} - {cat.NombreCategoria} >>\n");
                        cat.productos.ForEach(l=>WriteLine(l.ToString()));
                        WriteLine($"\n>>Total {cat.productos.Count}");
                    }
                    break;
                }
                case 8:{
                    WriteLine("\n\nConsulta 8 - Todos los productos ordenados por titulo");
                    foreach(var l in db.Productos.OrderBy(l => l.Titulo)){
                        WriteLine(l.ToString());
                    }
                    WriteLine($"\n\n>> Total {db.Productos.Count()}");
                    break;
                }                
            }
        }


        static void Scraping(){
            ChromeOptions opciones = new ChromeOptions();
            opciones.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(opciones);
            
            driver.Url = "https://www.mercadolibre.com.mx/";
            
            //se hace scraping de los productos en oferta relampago y se llenan las categorias

            List<string> urlsOfertas = new List<string>();
            List<Categorias> categorias = new List<Categorias>();
            List<Producto> productos = new List<Producto>();
            List<string> verificarCat = new List<string>();
            List<string> verificarUrlCat = new List<string>();

            for(int i = 1; i<= 1 ; i++){ urlsOfertas.Add($"https://www.mercadolibre.com.mx/ofertas?promotion_type=LIGHTNING_DEAL&page={i}");}

            foreach(var urlsO in urlsOfertas){
                driver.Navigate().GoToUrl(urlsO);
                List<String>urlProducto = new List<string>();
                var ligasProducto = driver.FindElements(By.XPath("/html/body/main/div/section[2]/div/div[2]/div/ol/li/a"));
                foreach(var l in ligasProducto) urlProducto.Add(l.GetAttribute("href"));
                foreach(var url in urlProducto){
                    driver.Navigate().GoToUrl(url);
                    Producto producto = new Producto();
                    
                    producto.Url = url;

                    driver.FindElement(By.XPath("/html/body")).SendKeys(Keys.Escape);
                    Thread.Sleep(1000);
                    producto.UrlImagen = driver.FindElement(By.ClassName("ui-pdp-image")).GetAttribute("src");
                    producto.Titulo = driver.FindElement(By.ClassName("ui-pdp-title")).Text;
                    
                    
                    var ListaPreciosTemp = driver.FindElements(By.ClassName("price-tag-fraction"));
                    producto.PrecioBase=ListaPreciosTemp[0].Text;
                    producto.PrecioDescuento = ListaPreciosTemp[1].Text;
                    
                    var ListaCategoriasTemp= driver.FindElements(By.ClassName("andes-breadcrumb__link"));
                    char[] delimitador = {'/'};
                    string urlCategoria = ListaCategoriasTemp[1].GetAttribute("href");
                    string[] trozos = urlCategoria.Split(delimitador);
                    
                    
                    
                    var categoriaTemporal = trozos[trozos.Length-2];

                    if(!verificarCat.Contains(categoriaTemporal)){
                        verificarCat.Add(categoriaTemporal);
                        verificarUrlCat.Add(urlCategoria);
                    }

                    producto.NombreCategoria = categoriaTemporal;

                    productos.Add(producto);
                    
                    
                }
                //opte por los nombres de clases en vez del XPATH ya que la pagina de mercado libre cambia mucho de articulo en articulo

            }

            //por el como se llena la tabla de categorias no puedo llenar las categorias de los productos al mismo tiempo 
            //por lo tanto fuera del ciclo inicial asignare las categorias
            //como no tengo una referencia clara de donde sacar el id de la categoria para fines practicos se lo agrego yo para poder asignarsele luego al producto

            List<Producto> productos2 = new List<Producto>();
            

            for(int i = 0;i<verificarCat.Count;i++){
                Categorias categoria = new Categorias();
                categoria.CategoriasID=i+1;
                categoria.NombreCategoria =verificarCat[i];
                categoria.Url = verificarUrlCat[i];
                categorias.Add(categoria);
            }
            
            
            foreach(var prod in productos){
                for(int i = 0;i<categorias.Count;i++){
                    var catLista = categorias[i].NombreCategoria;
                    var catProd = prod.NombreCategoria;
                    if(catLista.Equals(catProd)){
                        Producto productoNuevo= prod;
                        productoNuevo.CategoriasID=categorias[i].CategoriasID;
                        productos2.Add(productoNuevo);
                    }
                }
            }
            WriteLine("\n\n");
            //Vaciar la info a la BD
            WriteLine("Escribiendo en la bd:\n...");
            db.Database.EnsureCreated();//si no existe la crea
            //se guardan las categorias
            foreach(var c in categorias){ WriteLine(c.ToString()); db.Categorias.Add(c);}
            //se guardan los productos en oferta
            foreach(var p in productos2){ WriteLine(p.ToString());db.Productos.Add(p);}
            db.SaveChanges();
            WriteLine("Guardado con exito en la base de datos!");
            
        }
    }
}
