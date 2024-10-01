using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.CRUDMethods.GenreCRUD
{
    public class GenreCreate : ICreate
    {
        public void Create()
        {
            Console.Write("Enter the Genre Name: ");
            string nameGenre = Console.ReadLine();

            using (var context = new LibraryDbContext())
            {
                var genre = new Genre { NameGenre = nameGenre };
                context.Genre.Add(genre);
                context.SaveChanges();
                Console.WriteLine("Genre created successfully.");
            }
        }
    }
}

