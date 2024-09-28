using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClassLibrary;
using ClassLibrary.CRUDMethods;
namespace FinalProjectEF
{





    using System;
    using System.Linq;
    using Azure;
    using ClassLibrary;
    using ClassLibrary.CRUDMethods;
    using global::FinalProjectEF.FinalProjectEF;

    namespace FinalProjectEF
    {
        public class MenuCRUD
        {
            private readonly LibraryDbContext _context;
            private readonly Create _create;

            public MenuCRUD(LibraryDbContext context, Create create)
            {
                _context = context;
                _create = create;
            }

            public void DisplayMenu()
            {
                bool exit = false;
                while (!exit)
                {
                    Console.Clear();
                    Console.WriteLine("CRUD Menu:\n" +
                                        "1.Create \n" +
                                        "2.Show All\n" +
                                        "3.Update\n" +
                                        "4.Delete\n" +
                                        "5.Exit"); 
                    Console.Write("Select an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("CRUD Menu:\n" +
                                                     "1.Create Author\n" +
                                                     "2.Create  Book\n" +
                                                     "3.Create CostBook\n" +
                                                     "4.Create Genre\n" +
                                                     "5.Create Publishing\n" +
                                                     "6.Create SellingBook\n" +
                                                     "7.Exit");
                            switch (Console.ReadLine())
                            {

                                case "1":

                                    MenuCreateAuthor();
                                    break;
                                case "2":
                                    MenuCreateBook();

                                    break;
                                case "3":
                                    MenuCreateCostBook();

                                    break;
                                case "4":
                                    MenuCreateGenre();

                                    break;
                                case "5":
                                    MenuCreatePublishing();
                                    break;

                                case "6":
                                    MenuCreateSellingBook();
                                    break;

                                case "7":
                                    exit = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid selection. Please try again.");
                                    break;
                            }

                            break;
                        case "2":
                         

                            break;
                        case "3":
                            

                            break;
                        case "4":
                            

                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                }
            }

            private void MenuCreateAuthor()
            {
                Console.Write("Enter the Authors Full Name: ");
                string fullName = Console.ReadLine();
                Console.Write("Enter the Authors How Many Books: ");

                int howManyBooks = (int.Parse(Console.ReadLine()));
                _create.CreateAuthor(fullName, howManyBooks); 
                Console.WriteLine("Author added. Press any key to return to the menu.");
                Console.ReadKey();
            }

            private void MenuCreateBook()
            {
                Console.Write("Enter the Book Title: ");
                string Title = Console.ReadLine();


                Console.Write("Enter the Book Number Of Pages: ");
                int NumberOfPages = (int.Parse(Console.ReadLine()));

                DateTime YearOfPublication = (DateTime.Parse(Console.ReadLine()));

                Console.Write("Enter the Book Number Of Pages: ");
                bool IsItSequel = (bool.Parse(Console.ReadLine()));



                Console.Write("Enter the AuthorId: ");
                int AuthorId = (int.Parse(Console.ReadLine()));

                Console.Write("Enter the SellingBooksId: ");
                int SellingBooksId = (int.Parse(Console.ReadLine()));

                Console.Write("Enter the GenresId: ");
                int GenresId = (int.Parse(Console.ReadLine()));

                Console.Write("Enter the PublishingsId: ");
                int PublishingsId = (int.Parse(Console.ReadLine()));

                _create.CreateBook(Title, NumberOfPages, YearOfPublication, IsItSequel, AuthorId, SellingBooksId, GenresId, PublishingsId); 
                Console.WriteLine("Book added. Press any key to return to the menu.");
                Console.ReadKey();
            }

            private void MenuCreateCostBook()
            {
                Console.Write("Enter the Paper Expenses : ");
                decimal PaperExpenses = (decimal.Parse(Console.ReadLine()));
                
                Console.Write("Enter the Сardboard Expenses: ");
                decimal СardboardExpenses = (decimal.Parse(Console.ReadLine()));

                int BookId = (int.Parse(Console.ReadLine()));

                _create.CreateCostBook(PaperExpenses, СardboardExpenses, BookId);
                Console.WriteLine("CostBook added. Press any key to return to the menu.");
                Console.ReadKey();
            }

            private void MenuCreateGenre()
            {
                Console.Write("Enter the Name Genre: ");
                string NameGenre = Console.ReadLine();
              
                _create.CreateGenre(NameGenre);
                Console.WriteLine("Genre added. Press any key to return to the menu.");
                Console.ReadKey();
            }
            private void MenuCreatePublishing()
            {
                Console.Write("Enter the Name Publishing: ");
                string NamePublishing = Console.ReadLine();
               
                _create.CreatePublishing(NamePublishing); 
                Console.WriteLine("Publishing added. Press any key to return to the menu.");
                Console.ReadKey();
            }
            private void MenuCreateSellingBook()
            {
               
                Console.Write("Enter the Authors How Many Books: ");
                decimal PriceBook = (decimal.Parse(Console.ReadLine()));

                _create.CreateSellingBook(PriceBook);
                Console.WriteLine("SellingBook added. Press any key to return to the menu.");
                Console.ReadKey();
            }
            //    private void ShowGenres()
            //    {
            //        var genres = _context.Genre.Select(g => g.NameGenre).ToList();
            //        Console.WriteLine("List of genres:");
            //        foreach (var genre in genres)
            //        {
            //            Console.WriteLine(genre);
            //        }
            //        Console.WriteLine("Press any key to return to the menu.");
            //        Console.ReadKey();
            //    }

            //    private void UpdateGenre()
            //    {
            //        Console.Write("Enter the genre name to update: ");
            //        string oldGenreName = Console.ReadLine();
            //        Console.Write("Enter the new genre name: ");
            //        string newGenreName = Console.ReadLine();
            //        _create.UpdateGenre(oldGenreName, newGenreName); // Method to update the genre
            //        Console.WriteLine("Genre updated. Press any key to return to the menu.");
            //        Console.ReadKey();
            //    }

            //    private void DeleteGenre()
            //    {
            //        Console.Write("Enter the genre name to delete: ");
            //        string genreName = Console.ReadLine();
            //        _create.DeleteGenre(genreName); // Method to delete the genre
            //        Console.WriteLine("Genre deleted. Press any key to return to the menu.");
            //        Console.ReadKey();
            //    }
            //}


        }
    }









    internal class Program
    {
        static void Main(string[] args)
        {
           LibraryDbContext  LibraryDbContext = new LibraryDbContext();
            Create create = new Create();

            MenuCRUD menu = new MenuCRUD(LibraryDbContext, create);
            menu.DisplayMenu();
            var NameFor = LibraryDbContext.Genre.Select(s => s.NameGenre);

            foreach (var s in NameFor)
            {
                Console.WriteLine(s);
            }


        }
    }
}
