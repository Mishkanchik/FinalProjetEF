using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.CRUDMethods.AutorCRUD
{
    public class AuthorCreate : ICreate
    {
        public void Create()
        {
            Console.Write("Enter the Author's Full Name: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter the number of books by the author: ");
            int howManyBooks = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var author = new Author { FullName = fullName, HowManyBooks = howManyBooks };
                context.Author.Add(author);
                context.SaveChanges();
                Console.WriteLine("Author created successfully.");
            }
        }
    }
}
