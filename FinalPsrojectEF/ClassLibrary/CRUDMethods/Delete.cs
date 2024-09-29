using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods
{
    public class Delete
    {

        public void DeleteAuthor(int id)
        {
            using (var context = new LibraryDbContext())
            {
                var author = context.Author.Find(id);
                if (author != null)
                {
                    context.Author.Remove(author);
                    context.SaveChanges();
                    Console.WriteLine("Author deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Author not found.");
                }
            }
        }

        public void DeleteBook(int id)
        {
            using (var context = new LibraryDbContext())
            {
                var book = context.Book.Find(id);
                if (book != null)
                {
                    context.Book.Remove(book);
                    context.SaveChanges();
                    Console.WriteLine("Book deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }

        public void DeleteCostBook(int id)
        {
            using (var context = new LibraryDbContext())
            {
                var costBook = context.CostBook.Find(id);
                if (costBook != null)
                {
                    context.CostBook.Remove(costBook);
                    context.SaveChanges();
                    Console.WriteLine("CostBook deleted successfully.");
                }
                else
                {
                    Console.WriteLine("CostBook not found.");
                }
            }
        }

        public void DeleteGenre(int id)
        {
            using (var context = new LibraryDbContext())
            {
                var genre = context.Genre.Find(id);
                if (genre != null)
                {
                    context.Genre.Remove(genre);
                    context.SaveChanges();
                    Console.WriteLine("Genre deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Genre not found.");
                }
            }
        }

        public void DeletePublishing(int id)
        {
            using (var context = new LibraryDbContext())
            {
                var publishing = context.Publishing.Find(id);
                if (publishing != null)
                {
                    context.Publishing.Remove(publishing);
                    context.SaveChanges();
                    Console.WriteLine("Publishing deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Publishing not found.");
                }
            }
        }

        public void DeleteSellingBook(int id)
        {
            using (var context = new LibraryDbContext())
            {
                var sellingBook = context.SellingBook.Find(id);
                if (sellingBook != null)
                {
                    context.SellingBook.Remove(sellingBook);
                    context.SaveChanges();
                    Console.WriteLine("SellingBook deleted successfully.");
                }
                else
                {
                    Console.WriteLine("SellingBook not found.");
                }
            }
        }


    }
}
