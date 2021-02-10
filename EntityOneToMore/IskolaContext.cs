using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityOneToMore
{
    class IskolaContext:DbContext
    {
        public DbSet<Osztaly> Osztaly { get; set; }

        public DbSet<Tanulo> Tanulo{ get; set; }

        //Adatbázishoz csatlakozás
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=iskolademo;uid=root;pwd=;");
        }
        //Alap adatok
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
