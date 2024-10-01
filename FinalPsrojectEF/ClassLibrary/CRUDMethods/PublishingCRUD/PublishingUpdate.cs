using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.PublishingCRUD
{
    public class PublishingUpdate : IUpdate
    {
        public void Update()
        {
            Console.Write("Enter the Publishing ID to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var publishing = context.Publishing.Find(id);
                if (publishing != null)
                {
                    Console.Write("Enter new Publishing Name: ");
                    publishing.NamePublishing = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine("Publishing updated successfully.");
                }
                else
                {
                    Console.WriteLine("Publishing not found.");
                }
            }
        }
    }
}
