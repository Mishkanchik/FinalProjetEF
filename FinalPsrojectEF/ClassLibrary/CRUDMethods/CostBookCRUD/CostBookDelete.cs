using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.CRUDMethods.CostBookCRUD
{
    public class CostBookDelete : IDelete
    {
        public void Delete()
        {
            Console.Write("Enter the CostBook ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var costBook = context.CostBook.Find(id);
                if (costBook != null)
                {
                    context.CostBook.Remove(costBook);
                    context.SaveChanges();
                    Console.WriteLine("CostBook deleted successfully.");
                }
                else
                {
                    Console.WriteLine("CostBook not found.");
                }
            }
        }
    }
}
