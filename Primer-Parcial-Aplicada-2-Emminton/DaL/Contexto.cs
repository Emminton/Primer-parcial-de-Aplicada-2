using Microsoft.EntityFrameworkCore;
using Primer_Parcial_Aplicada_2_Emminton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_2_Emminton.DaL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulo> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Data\Articulos.db");
        }
    }
}
