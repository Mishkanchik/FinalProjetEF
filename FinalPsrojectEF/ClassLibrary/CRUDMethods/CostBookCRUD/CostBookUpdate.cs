using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CRUDMethods.CostBookCRUD
{
    public class CostBookUpdate : IUpdate
    {
        public void Update()
        {
            Console.Write("Enter the CostBook ID to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LibraryDbContext())
            {
                var costBook = context.CostBook.Find(id);
                if (costBook != null)
                {
                    Console.Write("Enter new Paper Expenses: ");
                    costBook.PaperExpenses = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter new Cardboard Expenses: ");
                    costBook.СardboardExpenses = decimal.Parse(Console.ReadLine());

                    context.SaveChanges();
                    Console.WriteLine("CostBook updated successfully.");
                }
                else
                {
                    Console.WriteLine("CostBook not found.");
                }
            }
        }
    }
}

