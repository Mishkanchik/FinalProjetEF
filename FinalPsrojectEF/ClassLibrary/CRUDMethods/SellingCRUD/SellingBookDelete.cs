using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.SellingCRUD
{
    public class SellingBookDelete : IDelete
    {
        public void Delete()
        {
            Console.Write("Enter the SellingBook ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var sellingBook = context.SellingBook.Find(id);
                if (sellingBook != null)
                {
                    context.SellingBook.Remove(sellingBook);
                    context.SaveChanges();
                    Console.WriteLine("SellingBook deleted successfully.");
                }
                else
                {
                    Console.WriteLine("SellingBook not found.");
                }
            }
        }
    }
}
