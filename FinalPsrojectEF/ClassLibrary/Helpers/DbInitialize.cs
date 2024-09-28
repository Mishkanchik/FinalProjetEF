using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ClassLibrary.Helpers
{
    public static class DbInitialize 
    {
        public static void SeedAuthors( this ModelBuilder modelBuilder) {


           
            var jsonData = File.ReadAllText(@"C:\Users\Ron\FinalProjetEFLibrary\FinalPsrojectEF\ClassLibrary\JsonInitializerFiles\AuthorInitializeFile.json");
            var authors = JsonConvert.DeserializeObject<Author[]>(jsonData);
            modelBuilder.Entity<Author>().HasData(authors);

        }
        public static void SeedBook(this ModelBuilder modelBuilder)
        {



            var jsonData = File.ReadAllText(@"C:\Users\Ron\FinalProjetEFLibrary\FinalPsrojectEF\ClassLibrary\JsonInitializerFiles\BookInitializeFile.json");
            var book = JsonConvert.DeserializeObject<Book[]>(jsonData);
            modelBuilder.Entity<Book>().HasData(book);

        }
        public static void SeedCostBook(this ModelBuilder modelBuilder)
        {
            var jsonData = File.ReadAllText(@"C:\Users\Ron\FinalProjetEFLibrary\FinalPsrojectEF\ClassLibrary\JsonInitializerFiles\CostBookInitializeFile.json");
            var costBook = JsonConvert.DeserializeObject<CostBook[]>(jsonData);
            modelBuilder.Entity<CostBook>().HasData(costBook);

        }
        public static void SeedGenre(this ModelBuilder modelBuilder)
        {



            var jsonData = File.ReadAllText(@"C:\Users\Ron\FinalProjetEFLibrary\FinalPsrojectEF\ClassLibrary\JsonInitializerFiles\GenreInitializeFile.json");
            var genre = JsonConvert.DeserializeObject<Genre[]>(jsonData);
            modelBuilder.Entity<Genre>().HasData(genre);

        }
        public static void SeedPublishing(this ModelBuilder modelBuilder)
        {



            var jsonData = File.ReadAllText(@"C:\Users\Ron\FinalProjetEFLibrary\FinalPsrojectEF\ClassLibrary\JsonInitializerFiles\PublishingInitializeFile.json");
            var publishing = JsonConvert.DeserializeObject<Publishing[]>(jsonData);
            modelBuilder.Entity<Publishing>().HasData(publishing);

        }
        public static void SeedSellingBook(this ModelBuilder modelBuilder)
        {



            var jsonData = File.ReadAllText(@"C:\Users\Ron\FinalProjetEFLibrary\FinalPsrojectEF\ClassLibrary\JsonInitializerFiles\SellingBookInitializeFile.json");
            var sellingBook = JsonConvert.DeserializeObject<SellingBook[]>(jsonData);
            modelBuilder.Entity<SellingBook>().HasData(sellingBook);

        }





    }
}
