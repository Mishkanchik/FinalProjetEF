using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.CRUDMethods
{
    public class Create
    {

        public void CreateAuthor(string fullName, int howManyBooks)
        {
            using (var context = new LibraryDbContext())
            {
                var author = new Author
                {
                    FullName = fullName,
                    HowManyBooks = howManyBooks
                };

                context.Author.Add(author); 
                context.SaveChanges();   
            }
        }


        public void CreateBook(string Title, int NumberOfPages,DateTime YearOfPublication,bool IsItSequel,int AuthorId,int SellingBooksId,int GenresId,int PublishingsId)
        {
            using (var context = new LibraryDbContext())
            {
                var book = new Book
                {
                    Title = Title,
                    NumberOfPages = NumberOfPages,
                    YearOfPublication = YearOfPublication,
                    IsItSequel = IsItSequel,
                    AuthorId = AuthorId,
                    SellingBooksId = SellingBooksId,
                    GenresId = GenresId,
                    PublishingsId = PublishingsId
                };

                context.Book.Add(book);
                context.SaveChanges();    
            }
        }


        public void CreateCostBook(decimal PaperExpenses, decimal СardboardExpenses,int BookId)
        {
            using (var context = new LibraryDbContext())
            {
                var costBook = new CostBook
                {
                    PaperExpenses = PaperExpenses,
                    СardboardExpenses = СardboardExpenses,
                    BookId = BookId
                };

                context.CostBook.Add(costBook); 
                context.SaveChanges();      
            }
        }


        public void CreateGenre(string NameGenre)
        {
            using (var context = new LibraryDbContext())
            {
                var genre = new Genre
                {
                    NameGenre = NameGenre
                   
                };

                context.Genre.Add(genre); 
                context.SaveChanges();      
            }
        }


        public void CreatePublishing(string NamePublishing )
        {
            using (var context = new LibraryDbContext())
            {
                var publishing = new Publishing
                {
                    NamePublishing = NamePublishing
                    
                };

                context.Publishing.Add(publishing); 
                context.SaveChanges();      
            }
        }

        public void CreateSellingBook(decimal PriceBook)
        {
            using (var context = new LibraryDbContext())
            {
                var sellingBook = new SellingBook
                {
                    PriceBook = PriceBook
                   
                };

                context.SellingBook.Add(sellingBook); 
                context.SaveChanges();     
            }
        }



    }

}

