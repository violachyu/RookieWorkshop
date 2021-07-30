using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RookieWorkshop.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        public DbSet<Data> Data { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>().HasKey(e => new { e.Data_Id });

            modelBuilder.Entity<Data>().HasData(
                new Data
                {
                    Data_Input = 6,
                    Data_Result = "Foo"
                },
               new Data
               {
                   Data_Input = 10,
                   Data_Result = "Bar",
               }
               );

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433;Database=Data;User Id=SA;Password=Strongpassword123");
    }
}

