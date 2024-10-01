using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.BookCRUD
{
    public class BookUpdate : IUpdate
    {
        public void Update()
        {
            Console.Write("Enter the Book ID to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var book = context.Book.Find(id);
                if (book != null)
                {
                    Console.Write("Enter the new Title: ");
                    book.Title = Console.ReadLine();

                    Console.Write("Enter the new number of pages: ");
                    book.NumberOfPages = int.Parse(Console.ReadLine());

                    Console.Write("Enter the new year of publication: ");
                    book.YearOfPublication = DateTime.Parse(Console.ReadLine());

                    Console.Write("Is it a sequel? (true/false): ");
                    book.IsItSequel = bool.Parse(Console.ReadLine());

                    context.SaveChanges();
                    Console.WriteLine("Book updated successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }
    }
}
