using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.BookCRUD
{
    public class BookReed : IReed
    {
        public void Read()
        {
            using (var context = new LibraryDbContext())
            {
                var books = context.Book.ToList();
                Console.WriteLine("Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Pages: {book.NumberOfPages}, " +
                                      $"Year: {book.YearOfPublication.Year}, Sequel: {book.IsItSequel}, Author ID: {book.AuthorId}");
                }
            }
        }
    }
}

