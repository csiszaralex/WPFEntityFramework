using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityOneToMore
{
    class IskolaContext : DbContext
    {
        public DbSet<Osztaly> Osztaly { get; set; }
        public DbSet<Tanulo> Tanulo { get; set; }

        //Adatbázishoz csatlakozás
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=iskolademo;uid=root;pwd=;");
        }

        //Alap adatok
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osztaly>().HasData(
                new Osztaly() { osztalyNev = "9A", osztalyFonok = "Józsi", osztalyId = 1 },
                new Osztaly() { osztalyNev = "13A", osztalyFonok = "Kowa", osztalyId = 2 }
                );
            modelBuilder.Entity<Tanulo>().HasData(
                new Tanulo() { tanuloNev = "Béla", szuletesiDatum = DateTime.Parse("2001.01.01"), osztalyId = 1, tanuloId = 1 },
                new Tanulo() { tanuloNev = "Cili", szuletesiDatum = DateTime.Parse("2005.03.22"), osztalyId = 1, tanuloId = 2 },
                new Tanulo() { tanuloNev = "Kata", szuletesiDatum = DateTime.Parse("2003.04.13"), osztalyId = 2, tanuloId = 3 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
