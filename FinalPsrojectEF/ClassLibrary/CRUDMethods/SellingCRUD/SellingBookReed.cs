using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.SellingCRUD
{
    public class SellingBookReed : IReed
    {
        public void Read()
        {
            using (var context = new LibraryDbContext())
            {
                var sellingBooks = context.SellingBook.ToList();
                Console.WriteLine("SellingBooks:");
                foreach (var sellingBook in sellingBooks)
                {
                    Console.WriteLine($"ID: {sellingBook.Id}, Price: {sellingBook.PriceBook}");
                }
            }
        }
    }
}
