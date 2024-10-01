using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.BookCRUD
{
    public class BookDelete : IDelete
    {
        public void Delete()
        {
            Console.Write("Enter the Book ID to delete: ");
            int id = int.Parse(Console.ReadLine());

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
    }
}

