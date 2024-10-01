using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.GenreCRUD
{
    public class GenreDelete : IDelete
    {
        public void Delete()
        {
            Console.Write("Enter the Genre ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var genre = context.Genre.Find(id);
                if (genre != null)
                {
                    context.Genre.Remove(genre);
                    context.SaveChanges();
                    Console.WriteLine("Genre deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Genre not found.");
                }
            }
        }
    }
}
