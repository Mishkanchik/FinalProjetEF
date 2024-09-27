using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using ClassLibrary.Helpers;
using ClassLibrary.PropertiesAndConnections;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary
{
   public class LibraryDbContext : DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<CostBook> CostBook { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Publishing> Publishing { get; set; }
        public DbSet<SellingBook> SellingBook { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=Library5942.mssql.somee.com;packet size=4096;user id=Mishka_SQLLogin_1;pwd=zcz7wqcb7x;data source=Library5942.mssql.somee.com;persist security info=False;initial catalog=Library5942;TrustServerCertificate=True");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedAuthors();
            modelBuilder.SeedBook();
            modelBuilder.SeedCostBook();
            modelBuilder.SeedGenre();
            modelBuilder.SeedPublishing();
            modelBuilder.SeedSellingBook();

            modelBuilder.Author_P_A_C_();
            modelBuilder.Book_P_A_C_();
            modelBuilder.CostBook_P_A_C_();
            modelBuilder.Genre_P_A_C_();
            modelBuilder.Publishing_P_A_C_();
       

        }



    }


   



}
