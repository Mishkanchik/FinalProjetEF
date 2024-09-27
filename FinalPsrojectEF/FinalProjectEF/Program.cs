using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClassLibrary;
namespace FinalProjectEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LibraryDbContext  LibraryDbContext = new LibraryDbContext();


            var NameFor = LibraryDbContext.Genre.Select(s => s.NameGenre);

            foreach (var s in NameFor)
            {
                Console.WriteLine(s);
            }



        }
    }
}
