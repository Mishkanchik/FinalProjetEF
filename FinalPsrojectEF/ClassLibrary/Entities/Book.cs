namespace ClassLibrary.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public int NumberOfPages { get; set; }
        public DateTime YearOfPublication { get; set; }
        public bool IsItSequel { get; set; }
        public Author? Author { get; set; }
        public int AuthorId { get; set; }

        public SellingBook? SellingBooks { get; set; }
        public int SellingBooksId { get; set; } 
        public CostBook? CostBooks { get; set; }


        public Genre? Genres { get; set; }
        public int GenresId { get; set; }

        public Publishing? Publishings { get; set; }
        public int PublishingsId { get; set; }

    }
}
