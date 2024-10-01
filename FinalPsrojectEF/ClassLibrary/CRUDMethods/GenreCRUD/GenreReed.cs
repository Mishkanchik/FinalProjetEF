using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.GenreCRUD
{
    public class GenreReed : IReed
    {
        public void Read()
        {
            using (var context = new LibraryDbContext())
            {
                var genres = context.Genre.ToList();
                Console.WriteLine("Genres:");
                foreach (var genre in genres)
                {
                    Console.WriteLine($"ID: {genre.Id}, Genre Name: {genre.NameGenre}");
                }
            }
        }
    }
}

