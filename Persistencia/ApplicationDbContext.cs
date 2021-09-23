using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.Net.Security;
using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Persona> personas {get; set;}
        public DbSet<Empresa> empresas {get; set;}
        public DbSet<Empleado> empleados {get; set;}
        public DbSet<Cliente> clientes {get; set;}
        public DbSet<Categoria> categorias {get; set;}
        public DbSet<Cargo> cargos {get; set;}

        private const string ConnectionString =@"Data Source=localhost\sqlexpress; Initial catalog = Consultores;Integrated Security = True";
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(ConnectionString);

            }
    }  
            
            }
}