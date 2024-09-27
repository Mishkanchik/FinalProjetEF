namespace ClassLibrary.Entities
{
    public class Genre {
        
        public int Id { get; set; }
        public string? NameGenre { get; set; }


        public ICollection<Book>? Books { get; set; }


    }
}
