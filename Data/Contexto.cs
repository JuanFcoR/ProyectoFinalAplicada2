using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazorApp.Data
{
    public class Contexto:DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\Sqlexpress;Database=AgroVeterinariaDb;Trusted_Connection=True;");
        }
    }
}
