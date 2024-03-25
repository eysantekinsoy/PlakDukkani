using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.DAL.Entities;

namespace Uygulama.DAL.Context
{
    public class UygulamaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANK3-YZLMORT-15\\MSSQLSERVERANK16; Database=PlakDukkan;Trusted_Connection=true;trustservercertificate=true");
            
        }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Sanatci> Sanatcis { get; set; }
    public DbSet<Kullanici> Kullanicis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sanatci>().HasData
                (
                new Sanatci() { Id = 1 ,Adi = "Barış Manço", CreatedDate = DateTime.Now },
                new Sanatci() { Id = 2, Adi = "Barış Akarsu", CreatedDate = DateTime.Now },
                new Sanatci() { Id = 3 ,Adi = "Sıla", CreatedDate = DateTime.Now }

                );
        }
    }
}
