using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.CostBookCRUD
{
    public class CostBookReed : IReed
    {
        public void Read()
        {
            using (var context = new LibraryDbContext())
            {
                var costBooks = context.CostBook.ToList();
                Console.WriteLine("CostBooks:");
                foreach (var costBook in costBooks)
                {
                    Console.WriteLine($"ID: {costBook.Id}, Paper Expenses: {costBook.PaperExpenses}, " +
                                      $"Cardboard Expenses: {costBook.СardboardExpenses}, Book ID: {costBook.BookId}");
                }
            }
        }
    }
}

