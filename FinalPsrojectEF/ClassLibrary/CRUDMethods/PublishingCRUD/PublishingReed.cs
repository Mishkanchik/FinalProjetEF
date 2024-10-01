using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.PublishingCRUD
{
    public class PublishingReed : IReed
    {
        public void Read()
        {
            using (var context = new LibraryDbContext())
            {
                var publishings = context.Publishing.ToList();
                Console.WriteLine("Publishings:");
                foreach (var publishing in publishings)
                {
                    Console.WriteLine($"ID: {publishing.Id}, Name: {publishing.NamePublishing}");
                }
            }
        }
    }
}
