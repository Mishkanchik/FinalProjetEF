using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.CRUDMethods.AutorCRUD
{
    public class AuthorDelete : IDelete
    {
        public void Delete()
        {
            Console.Write("Enter the Author ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var author = context.Author.Find(id);
                if (author != null)
                {
                    context.Author.Remove(author);
                    context.SaveChanges();
                    Console.WriteLine("Author deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Author not found.");
                }
            }
        }
    }
}
