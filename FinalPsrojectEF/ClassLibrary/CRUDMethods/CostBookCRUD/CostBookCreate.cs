using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;


namespace ClassLibrary.CRUDMethods.CostBookCRUD
{
    public class CostBookCreate : ICreate
    {
        public void Create()
        {
            Console.Write("Enter Paper Expenses: ");
            decimal paperExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Cardboard Expenses: ");
            decimal cardboardExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Book ID: ");
            int bookId = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var costBook = new CostBook
                {
                    PaperExpenses = paperExpenses,
                    СardboardExpenses = cardboardExpenses,
                    BookId = bookId
                };

                context.CostBook.Add(costBook);
                context.SaveChanges();
                Console.WriteLine("CostBook created successfully.");
            }
        }
    }
}
