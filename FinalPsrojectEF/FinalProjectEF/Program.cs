using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClassLibrary;
using ClassLibrary.CRUDMethods;
using ClassLibrary.Menu;
using ClassLibrary.CRUDMethods.Factory;


namespace FinalProjectEF
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var factories = new Dictionary<string, ICrudFactory>
        {
            { "Author", new AuthorCrudFactory() },
            { "Book", new BookCrudFactory() },
            { "CostBook", new CostBookCrudFactory() },
            { "Genre", new GenreCrudFactory() },
            { "Publishing", new PublishingCrudFactory() },
            { "SellingBook", new SellingBookCrudFactory() },
        };

            var menu = new MenuCRUD(factories);
            menu.DisplayMenu();
        }
    }
}
