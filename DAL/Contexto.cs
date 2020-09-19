


using Microsoft.EntityFrameworkCore;
using RegistroCompleto.Entidades;


namespace RegistroCompleto.DAL
{

    public class Contexto:DbContext
    {
         public DbSet<Persona> Persona {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         base.OnConfiguring(optionsBuilder);
         optionsBuilder.UseSqlite(@"Data Source = Prueba.db");
    }   }
}   
