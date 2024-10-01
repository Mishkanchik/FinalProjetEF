using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.PublishingCRUD
{
    public class PublishingDelete : IDelete
    {
        public void Delete()
        {
            Console.Write("Enter the Publishing ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var publishing = context.Publishing.Find(id);
                if (publishing != null)
                {
                    context.Publishing.Remove(publishing);
                    context.SaveChanges();
                    Console.WriteLine("Publishing deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Publishing not found.");
                }
            }
        }
    }
}
