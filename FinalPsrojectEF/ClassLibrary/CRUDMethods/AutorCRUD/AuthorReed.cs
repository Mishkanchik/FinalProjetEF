using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.AutorCRUD
{
    public class AuthorReed : IReed
    {
        public void Read()
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
    }
}
