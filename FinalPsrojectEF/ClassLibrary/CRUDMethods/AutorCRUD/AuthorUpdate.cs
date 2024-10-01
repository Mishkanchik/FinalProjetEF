using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.AutorCRUD
{
    public class AuthorUpdate : IUpdate
    {
        public void Update()
        {
            Console.Write("Enter the Author ID to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var author = context.Author.Find(id);
                if (author != null)
                {
                    Console.Write("Enter new Full Name: ");
                    author.FullName = Console.ReadLine();
                    Console.Write("Enter new number of books: ");
                    author.HowManyBooks = int.Parse(Console.ReadLine());

                    context.SaveChanges();
                    Console.WriteLine("Author updated successfully.");
                }
                else
                {
                    Console.WriteLine("Author not found.");
                }
            }
        }
    }
}

