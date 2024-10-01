using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ClassLibrary.CRUDMethods.SellingCRUD
{
    public class SellingBookCreate : ICreate
    {
        public void Create()
        {
            Console.Write("Enter the SellingBook Price: ");
            decimal priceBook = decimal.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var sellingBook = new SellingBook { PriceBook = priceBook };
                context.SellingBook.Add(sellingBook);
                context.SaveChanges();
                Console.WriteLine("SellingBook created successfully.");
            }
        }
    }
}
