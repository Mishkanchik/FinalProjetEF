using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.PropertiesAndConnections
{
    public static class PropertiesAndConnections
    {
        public static void Author_P_A_C_(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.FullName).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Author>().HasIndex(a => a.FullName).HasDatabaseName("Search Authors Name");
        }
        public static void Book_P_A_C_(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Book>().HasIndex(b => b.Title).HasDatabaseName("Search Book Name");


            modelBuilder.Entity<Book>().HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);
            modelBuilder.Entity<Book>().HasOne(b => b.SellingBooks).WithMany(s => s.Books).HasForeignKey(b => b.SellingBooksId);
            modelBuilder.Entity<Book>().HasOne(b => b.Genres).WithMany(g => g.Books).HasForeignKey(b => b.GenresId);
            modelBuilder.Entity<Book>().HasOne(b => b.Publishings).WithMany(p => p.Books).HasForeignKey(b => b.PublishingsId);

        }
        public static void CostBook_P_A_C_(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CostBook>().HasOne(c => c.Books).WithOne(b => b.CostBooks).HasPrincipalKey<CostBook>(c => c.BookId);
        }
        public static void Genre_P_A_C_(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Genre>().Property(g => g.NameGenre).HasMaxLength(100).IsRequired();
        }
        public static void Publishing_P_A_C_(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publishing>().Property(p => p.NamePublishing).HasMaxLength(50).IsRequired();
        }

    }
}
