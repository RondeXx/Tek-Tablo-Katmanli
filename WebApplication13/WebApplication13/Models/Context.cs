using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-95UI604; database=Birim; integrated security=true;");
        }
        public DbSet<Birim> Birimis { get; set; }
        public DbSet<Personel> Personelis { get; set; }
    }
}
