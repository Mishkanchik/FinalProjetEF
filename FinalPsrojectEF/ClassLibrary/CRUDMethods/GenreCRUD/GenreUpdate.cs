using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.GenreCRUD
{
    public class GenreUpdate : IUpdate
    {
        public void Update()
        {
            Console.Write("Enter the Genre ID to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var genre = context.Genre.Find(id);
                if (genre != null)
                {
                    Console.Write("Enter new Genre Name: ");
                    genre.NameGenre = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine("Genre updated successfully.");
                }
                else
                {
                    Console.WriteLine("Genre not found.");
                }
            }
        }
    }
}
