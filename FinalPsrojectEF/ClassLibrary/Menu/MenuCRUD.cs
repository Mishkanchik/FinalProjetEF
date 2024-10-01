using System;
using System.Collections.Generic;
using ClassLibrary.CRUDMethods;

namespace ClassLibrary.Menu
{
    public class MenuCRUD
    {
        private readonly Dictionary<string, ICrudFactory> _factories;

        public MenuCRUD(Dictionary<string, ICrudFactory> factories)
        {
            _factories = factories;
        }

        public void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("CRUD Menu:\n" +
                                  "1. Author\n" +
                                  "2. Book\n" +
                                  "3. CostBook\n" +
                                  "4. Genre\n" +
                                  "5. Publishing\n" +
                                  "6. SellingBook\n" +
                                  "7. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        DisplayCrudMenu("Author");
                        break;
                    case "2":
                        DisplayCrudMenu("Book");
                        break;
                    case "3":
                        DisplayCrudMenu("CostBook");
                        break;
                    case "4":
                        DisplayCrudMenu("Genre");
                        break;
                    case "5":
                        DisplayCrudMenu("Publishing");
                        break;
                    case "6":
                        DisplayCrudMenu("SellingBook");
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
        }

        private void DisplayCrudMenu(string entityName)
        {
            Console.Clear();
            Console.WriteLine($"CRUD Menu for {entityName}:\n" +
                              "1. Create\n" +
                              "2. Read\n" +
                              "3. Update\n" +
                              "4. Delete\n" +
                              "5. Back");
            Console.Write("Select an option: ");

            var factory = _factories[entityName];
            switch (Console.ReadLine())
            {
                case "1":
                    factory.Create().Create();
                    break;
                case "2":
                    factory.Read().Read();
                    break;
                case "3":
                    factory.Update().Update();
                    break;
                case "4":
                    factory.Delete().Delete();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
