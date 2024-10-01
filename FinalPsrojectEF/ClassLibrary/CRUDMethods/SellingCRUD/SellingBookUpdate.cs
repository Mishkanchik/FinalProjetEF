using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.SellingCRUD
{
    public class SellingBookUpdate : IUpdate
    {
        public void Update()
        {
            Console.Write("Enter the SellingBook ID to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var sellingBook = context.SellingBook.Find(id);
                if (sellingBook != null)
                {
                    Console.Write("Enter new Price: ");
                    sellingBook.PriceBook = decimal.Parse(Console.ReadLine());
                    context.SaveChanges();
                    Console.WriteLine("SellingBook updated successfully.");
                }
                else
                {
                    Console.WriteLine("SellingBook not found.");
                }
            }
        }
    }
}
