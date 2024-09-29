using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods
{
    public class Update
    {

        public void UpdateAuthor(int id, string fullName, int howManyBooks)
        {
            using (var context = new LibraryDbContext())
            {
                var author = context.Author.Find(id);
                if (author != null)
                {
                    author.FullName = fullName;
                    author.HowManyBooks = howManyBooks;
                    context.SaveChanges();
                    Console.WriteLine("Author updated successfully.");
                }
                else
                {
                    Console.WriteLine("Author not found.");
                }
            }
        }

        public void UpdateBook(int id, string title, int numberOfPages, DateTime yearOfPublication, bool isItSequel, int authorId, int genreId, int publishingId, int sellingBookId)
        {
            using (var context = new LibraryDbContext())
            {
                var book = context.Book.Find(id);
                if (book != null)
                {
                    book.Title = title;
                    book.NumberOfPages = numberOfPages;
                    book.YearOfPublication = yearOfPublication;
                    book.IsItSequel = isItSequel;
                    book.AuthorId = authorId;
                    book.GenresId = genreId;
                    book.PublishingsId = publishingId;
                    book.SellingBooksId = sellingBookId;
                    context.SaveChanges();
                    Console.WriteLine("Book updated successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }

        public void UpdateCostBook(int id, decimal paperExpenses, decimal cardboardExpenses, int bookId)
        {
            using (var context = new LibraryDbContext())
            {
                var costBook = context.CostBook.Find(id);
                if (costBook != null)
                {
                    costBook.PaperExpenses = paperExpenses;
                    costBook.СardboardExpenses = cardboardExpenses;
                    costBook.BookId = bookId;
                    context.SaveChanges();
                    Console.WriteLine("CostBook updated successfully.");
                }
                else
                {
                    Console.WriteLine("CostBook not found.");
                }
            }
        }

        public void UpdateGenre(int id, string nameGenre)
        {
            using (var context = new LibraryDbContext())
            {
                var genre = context.Genre.Find(id);
                if (genre != null)
                {
                    genre.NameGenre = nameGenre;
                    context.SaveChanges();
                    Console.WriteLine("Genre updated successfully.");
                }
                else
                {
                    Console.WriteLine("Genre not found.");
                }
            }
        }

        public void UpdatePublishing(int id, string namePublishing)
        {
            using (var context = new LibraryDbContext())
            {
                var publishing = context.Publishing.Find(id);
                if (publishing != null)
                {
                    publishing.NamePublishing = namePublishing;
                    context.SaveChanges();
                    Console.WriteLine("Publishing updated successfully.");
                }
                else
                {
                    Console.WriteLine("Publishing not found.");
                }
            }
        }

        public void UpdateSellingBook(int id, decimal priceBook)
        {
            using (var context = new LibraryDbContext())
            {
                var sellingBook = context.SellingBook.Find(id);
                if (sellingBook != null)
                {
                    sellingBook.PriceBook = priceBook;
                    context.SaveChanges();
                    Console.WriteLine("SellingBook updated successfully.");
                }
                else
                {
                    Console.WriteLine("SellingBook not found.");
                }
            }
        }


    }
}
