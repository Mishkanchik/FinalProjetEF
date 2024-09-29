using ClassLibrary;
using ClassLibrary.CRUDMethods;

namespace ClassLibrary.Menu
{
    public class MenuCRUD
    {
        private readonly LibraryDbContext _context;
        private readonly Create _create;
        private readonly Reed _reed;
        private readonly Update _update;
        private readonly Delete _delete;

        public MenuCRUD(LibraryDbContext context, Create create, Reed reed, Update update, Delete delete)
        {
            _context = context;
            _create = create;
            _reed = reed;
            _update = update;
            _delete = delete;
        }

        public void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("CRUD Menu:\n" +
                                    "1. Create \n" +
                                    "2. Show All\n" +
                                    "3. Update\n" +
                                    "4. Delete\n" +
                                    "5. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        DisplayCreateMenu();
                        break;
                    case "2":
                        DisplayReadMenu();
                        break;
                    case "3":
                        DisplayUpdateMenu();
                        break;
                    case "4":
                        DisplayDeleteMenu();
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

        private void DisplayCreateMenu()
        {
            Console.Clear();
            Console.WriteLine("CRUD Menu:\n" +
                                "1. Create Author\n" +
                                "2. Create Book\n" +
                                "3. Create CostBook\n" +
                                "4. Create Genre\n" +
                                "5. Create Publishing\n" +
                                "6. Create SellingBook\n" +
                                "7. Exit");
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
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        private void DisplayReadMenu()
        {
            Console.Clear();
            Console.WriteLine("CRUD Menu:\n" +
                                "1. Reed Author\n" +
                                "2. Reed Book\n" +
                                "3. Reed CostBook\n" +
                                "4. Reed Genre\n" +
                                "5. Reed Publishing\n" +
                                "6. Reed SellingBook\n" +
                                "7. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    _reed.ReedAuthor();
                    Console.ReadKey();
                    break;
                case "2":
                    _reed.ReedBook();
                    Console.ReadKey();
                    break;
                case "3":
                    _reed.ReedCostBook();
                    Console.ReadKey();
                    break;
                case "4":
                    _reed.ReedGenre();
                    Console.ReadKey();
                    break;
                case "5":
                    _reed.ReedPublishing();
                    Console.ReadKey();
                    break;
                case "6":
                    _reed.ReedSellingBook();
                    Console.ReadKey();
                    break;
                case "7":
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        private void DisplayUpdateMenu()
        {
            Console.Clear();
            Console.WriteLine("CRUD Menu:\n" +
                                "1. Update Author\n" +
                                "2. Update Book\n" +
                                "3. Update CostBook\n" +
                                "4. Update Genre\n" +
                                "5. Update Publishing\n" +
                                "6. Update SellingBook\n" +
                                "7. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    MenuUpdateAuthor();
                    break;
                case "2":
                    MenuUpdateBook();
                    break;
                case "3":
                    MenuUpdateCostBook();
                    break;
                case "4":
                    MenuUpdateGenre();
                    break;
                case "5":
                    MenuUpdatePublishing();
                    break;
                case "6":
                    MenuUpdateSellingBook();
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        private void DisplayDeleteMenu()
        {
            Console.Clear();
            Console.WriteLine("CRUD Menu:\n" +
                                "1. Delete Author\n" +
                                "2. Delete Book\n" +
                                "3. Delete CostBook\n" +
                                "4. Delete Genre\n" +
                                "5. Delete Publishing\n" +
                                "6. Delete SellingBook\n" +
                                "7. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    MenuDeleteAuthor();
                    break;
                case "2":
                    MenuDeleteBook();
                    break;
                case "3":
                    MenuDeleteCostBook();
                    break;
                case "4":
                    MenuDeleteGenre();
                    break;
                case "5":
                    MenuDeletePublishing();
                    break;
                case "6":
                    MenuDeleteSellingBook();
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        private void MenuCreateAuthor()
        {
            Console.Write("Enter the Author's Full Name: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter the number of books by the author: ");
            int howManyBooks = int.Parse(Console.ReadLine());

            _create.CreateAuthor(fullName, howManyBooks);
            Console.WriteLine("Author created. Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void MenuCreateBook()
        {
            Console.Write("Enter the Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the Book Number Of Pages: ");
            int numberOfPages = int.Parse(Console.ReadLine());

            Console.Write("Enter the Year Of Publication: ");
            DateTime yearOfPublication = DateTime.Parse(Console.ReadLine());

            Console.Write("Is it a sequel? (true/false): ");
            bool isItSequel = bool.Parse(Console.ReadLine());

            Console.Write("Enter the Author ID: ");
            int authorId = int.Parse(Console.ReadLine());

            Console.Write("Enter the Selling Books ID: ");
            int sellingBooksId = int.Parse(Console.ReadLine());

            Console.Write("Enter the Genres ID: ");
            int genresId = int.Parse(Console.ReadLine());

            Console.Write("Enter the Publishing ID: ");
            int publishingId = int.Parse(Console.ReadLine());

            _create.CreateBook(title, numberOfPages, yearOfPublication, isItSequel, authorId, sellingBooksId, genresId, publishingId);
            Console.WriteLine("Book created. Press any key to return to the menu.");
            Console.ReadKey();
        }



        private void MenuCreateCostBook()
        {
            Console.Write("Enter the Paper Expenses: ");
            decimal paperExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the Cardboard Expenses: ");
            decimal cardboardExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the Book ID: ");
            int bookId = int.Parse(Console.ReadLine());

            _create.CreateCostBook(paperExpenses, cardboardExpenses, bookId);
            Console.WriteLine("CostBook created. Press any key to return to the menu.");
            Console.ReadKey();
        }



        private void MenuCreateGenre()
        {
            Console.Write("Enter the Genre Name: ");
            string nameGenre = Console.ReadLine();

            _create.CreateGenre(nameGenre);
            Console.WriteLine("Genre created. Press any key to return to the menu.");
            Console.ReadKey();
        }




        private void MenuCreatePublishing()
        {
            Console.Write("Enter the Publishing Name: ");
            string namePublishing = Console.ReadLine();

            _create.CreatePublishing(namePublishing);
            Console.WriteLine("Publishing created. Press any key to return to the menu.");
            Console.ReadKey();
        }


        private void MenuCreateSellingBook()
        {
            Console.Write("Enter the Book Price: ");
            decimal priceBook = decimal.Parse(Console.ReadLine());

            _create.CreateSellingBook(priceBook);
            Console.WriteLine("SellingBook created. Press any key to return to the menu.");
            Console.ReadKey();
        }






        private void MenuUpdateAuthor()
        {
            Console.Write("Enter the Author ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter the new number of books: ");
            int howManyBooks = int.Parse(Console.ReadLine());

            _update.UpdateAuthor(id, fullName, howManyBooks);
            Console.WriteLine("Author updated. Press any key to return to the menu.");
            Console.ReadKey();
        }




        private void MenuUpdateBook()
        {
            Console.Write("Enter the Book ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the new Number Of Pages: ");
            int numberOfPages = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Year Of Publication: ");
            DateTime yearOfPublication = DateTime.Parse(Console.ReadLine());

            Console.Write("Is it a sequel? (true/false): ");
            bool isItSequel = bool.Parse(Console.ReadLine());

            Console.Write("Enter the new Author ID: ");
            int authorId = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Selling Books ID: ");
            int sellingBooksId = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Genres ID: ");
            int genresId = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Publishing ID: ");
            int publishingId = int.Parse(Console.ReadLine());

            _update.UpdateBook(id, title, numberOfPages, yearOfPublication, isItSequel, authorId, sellingBooksId, genresId, publishingId);
            Console.WriteLine("Book updated. Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void MenuUpdateCostBook()
        {
            Console.Write("Enter the CostBook ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Paper Expenses: ");
            decimal paperExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the new Cardboard Expenses: ");
            decimal cardboardExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the new Book ID: ");
            int bookId = int.Parse(Console.ReadLine());

            _update.UpdateCostBook(id, paperExpenses, cardboardExpenses, bookId);
            Console.WriteLine("CostBook updated. Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void MenuUpdateGenre()
        {
            Console.Write("Enter the Genre ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Genre Name: ");
            string nameGenre = Console.ReadLine();

            _update.UpdateGenre(id, nameGenre);
            Console.WriteLine("Genre updated. Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void MenuUpdatePublishing()
        {
            Console.Write("Enter the Publishing ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Publishing Name: ");
            string namePublishing = Console.ReadLine();

            _update.UpdatePublishing(id, namePublishing);
            Console.WriteLine("Publishing updated. Press any key to return to the menu.");
            Console.ReadKey();
        }



        private void MenuUpdateSellingBook()
        {
            Console.Write("Enter the SellingBook ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter the new Book Price: ");
            decimal priceBook = decimal.Parse(Console.ReadLine());

            _update.UpdateSellingBook(id, priceBook);
            Console.WriteLine("SellingBook updated. Press any key to return to the menu.");
            Console.ReadKey();
        }










        private void MenuDeleteAuthor()
        {
            Console.Write("Enter the Author ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            _delete.DeleteAuthor(id);
            Console.WriteLine("Author deleted. Press any key to return to the menu.");
            Console.ReadKey();
        }



        private void MenuDeleteBook()
        {
            Console.Write("Enter the Book ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            _delete.DeleteBook(id);
            Console.WriteLine("Book deleted. Press any key to return to the menu.");
            Console.ReadKey();
        }




        private void MenuDeleteCostBook()
        {
            Console.Write("Enter the CostBook ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            _delete.DeleteCostBook(id);
            Console.WriteLine("CostBook deleted. Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void MenuDeleteGenre()
        {
            Console.Write("Enter the Genre ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            _delete.DeleteGenre(id);
            Console.WriteLine("Genre deleted. Press any key to return to the menu.");
            Console.ReadKey();
        }



        private void MenuDeletePublishing()
        {
            Console.Write("Enter the Publishing ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            _delete.DeletePublishing(id);
            Console.WriteLine("Publishing deleted. Press any key to return to the menu.");
            Console.ReadKey();
        }

        private void MenuDeleteSellingBook()
        {
            Console.Write("Enter the SellingBook ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            _delete.DeleteSellingBook(id);
            Console.WriteLine("SellingBook deleted. Press any key to return to the menu.");
            Console.ReadKey();
        }





    }
}
