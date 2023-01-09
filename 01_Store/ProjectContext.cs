using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Store
{
    internal class ProjectContext : DbContext
    {
        /*
         * 1. Nuget console manager üzerinden EfCore yükle,desing,sqlserver,tools yükle
           2. Classlarını yazın
           3. Context class'ını yaz ve DBContext'ten miras al
           4. Context class'ının içine DbSet ile classlarını yaz
           5. Context class'ına ya da ilgili class'a ConnectionString'inizi yazınız.
           6. package manager console içinde default project olarak migration yapacağımız projeyi seçiyoruz.
           7. PMC add-migration isim yazıyoruz
           8. PMC update-database
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=StoreDB;Trusted_Connection=true;encrypt=false");
            }
        }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Store> Dukkanlar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}
