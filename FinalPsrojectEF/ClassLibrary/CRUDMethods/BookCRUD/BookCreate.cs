using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.CRUDMethods.BookCRUD
{
    public class BookCreate : ICreate
    {
        public void Create()
        {
            Console.Write("Enter the Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the number of pages: ");
            int numberOfPages = int.Parse(Console.ReadLine());

            Console.Write("Enter the year of publication: ");
            DateTime yearOfPublication = DateTime.Parse(Console.ReadLine());

            Console.Write("Is it a sequel? (true/false): ");
            bool isItSequel = bool.Parse(Console.ReadLine());

            Console.Write("Enter the Author ID: ");
            int authorId = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var book = new Book
                {
                    Title = title,
                    NumberOfPages = numberOfPages,
                    YearOfPublication = yearOfPublication,
                    IsItSequel = isItSequel,
                    AuthorId = authorId
                };

                context.Book.Add(book);
                context.SaveChanges();
                Console.WriteLine("Book created successfully.");
            }
        }
    }
}

