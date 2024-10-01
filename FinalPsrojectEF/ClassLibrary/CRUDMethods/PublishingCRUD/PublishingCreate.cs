using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.CRUDMethods.PublishingCRUD
{
    public class PublishingCreate : ICreate
    {
        public void Create()
        {
            Console.Write("Enter the Publishing Name: ");
            string namePublishing = Console.ReadLine();

            using (var context = new LibraryDbContext())
            {
                var publishing = new Publishing { NamePublishing = namePublishing };
                context.Publishing.Add(publishing);
                context.SaveChanges();
                Console.WriteLine("Publishing created successfully.");
            }
        }
    }
}
