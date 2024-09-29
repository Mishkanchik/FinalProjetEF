using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods
{
    public class Reed
    {


        public void ReedAuthor()
        {
            using (var context = new LibraryDbContext())
            {
                var authors = context.Author.ToList();
                Console.WriteLine("Authors:");
                foreach (var author in authors)
                {
                    Console.WriteLine($"ID: {author.Id}, Full Name: {author.FullName}, How Many Books: {author.HowManyBooks}");
                }
            }
        }

        public void ReedBook()
        {
            using (var context = new LibraryDbContext())
            {
                var books = context.Book.ToList();
                Console.WriteLine("\nBooks:");
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Pages: {book.NumberOfPages}, Year: {book.YearOfPublication.Year}, Sequel: {book.IsItSequel}, " +
                                      $"Author ID: {book.AuthorId}, Genre ID: {book.GenresId}, Publishing ID: {book.PublishingsId}, SellingBook ID: {book.SellingBooksId}");
                }
            }
        }

        public void ReedCostBook()
        {
            using (var context = new LibraryDbContext())
            {
                var costBooks = context.CostBook.ToList();
                Console.WriteLine("\nBook Costs:");
                foreach (var cost in costBooks)
                {
                    Console.WriteLine($"ID: {cost.Id}, Paper Expenses: {cost.PaperExpenses}, Cardboard Expenses: {cost.СardboardExpenses}, Book ID: {cost.BookId}");
                }
            }
        }

        public void ReedGenre()
        {
            using (var context = new LibraryDbContext())
            {
                var genres = context.Genre.ToList();
                Console.WriteLine("\nGenres:");
                foreach (var genre in genres)
                {
                    Console.WriteLine($"ID: {genre.Id}, Genre Name: {genre.NameGenre}");
                }
            }
        }

        public void ReedPublishing()
        {
            using (var context = new LibraryDbContext())
            {
                var publishings = context.Publishing.ToList();
                Console.WriteLine("\nPublishing Houses:");
                foreach (var publishing in publishings)
                {
                    Console.WriteLine($"ID: {publishing.Id}, Name: {publishing.NamePublishing}");
                }
            }
        }

        public void ReedSellingBook()
        {
            using (var context = new LibraryDbContext())
            {
                var sellingBooks = context.SellingBook.ToList();
                Console.WriteLine("\nSelling Books:");
                foreach (var selling in sellingBooks)
                {
                    Console.WriteLine($"ID: {selling.Id}, Price: {selling.PriceBook}");
                }
            }
        }



    }
}
