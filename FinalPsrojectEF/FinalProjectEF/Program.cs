using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClassLibrary;
using ClassLibrary.CRUDMethods;
using ClassLibrary.Menu;


namespace FinalProjectEF
{
    internal class Program
    {
        static void Main()
        {
           LibraryDbContext  LibraryDbContext = new LibraryDbContext();
            Create create = new Create();
            Reed reed = new Reed();
            Update update = new Update();
            Delete delete = new Delete();

            MenuCRUD menu = new MenuCRUD(LibraryDbContext, create, reed,update,delete);
            menu.DisplayMenu();
           

        }
    }
}
