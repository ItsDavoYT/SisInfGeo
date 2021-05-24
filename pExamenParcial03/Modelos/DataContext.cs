using System;
using Microsoft.EntityFrameworkCore;

namespace pExamenParcial3{

    public class DataContext : DbContext{

        public DbSet<Categorias> Categorias{get;set;}
        public DbSet<Producto> Productos{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder opciones) => 
            opciones.UseSqlite(@"Data Source=MercadoLibre.db");


    }

}