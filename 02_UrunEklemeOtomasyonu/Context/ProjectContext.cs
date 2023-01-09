using _02_UrunEklemeOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_UrunEklemeOtomasyonu.Context
{
    internal class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=UrunEklemeDB;Trusted_Connection=true;encrypt=false");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
    }
}
